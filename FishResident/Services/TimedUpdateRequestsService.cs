using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.Logging;
using FishResident.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FishResident.Models;

namespace FishResident.Services
{
    internal class TimedUpdateRequestsService : IHostedService, IDisposable
    {
        private const int ChunkSize = 50;
        private readonly ILogger _logger;
        private Timer _timer;
        private readonly IServiceScopeFactory _scopeFactory;

        public TimedUpdateRequestsService(ILogger<TimedUpdateRequestsService> logger, IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is starting.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(30));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            _logger.LogInformation("Timed Background Service is working.");

            using (var scope = _scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                var updatedIds = dbContext.TempResidences.Take(ChunkSize).Select(i => i.Id);
                var residences = dbContext.Residences
                    .Include(r => r.Features)
                    .ThenInclude(f => f.FeatureType)
                    .Where(r => updatedIds.Contains(r.Id));

                var requests = dbContext.SearchRequests
                    .Include(r => r.FeatureRequests)
                    .ToList();

                foreach (var residence in residences)
                {
                    foreach (var request in requests)
                    {
                        double criterias = 0, goodCriterias = 0;

                        goodCriterias += Math.Min(request.Area / residence.Area, residence.Area / request.Area);
                        criterias++;

                        goodCriterias += Math.Min(request.Cost / residence.Cost, residence.Cost / request.Cost);
                        criterias++;

                        foreach (var criteria in request.FeatureRequests)
                        {
                            var residenceValue = residence.Features.Where(f => f.FeatureTypeId == criteria.FeatureTypeId).First().Value;
                            if (criteria.Value == "Not Specified" || criteria.Value == residenceValue)
                            {
                                goodCriterias++;
                            }
                            criterias++;
                        }

                        if (goodCriterias / criterias > 0.75)
                        {
                            var requestResult = new RequestResult
                            {
                                Relevance = goodCriterias / criterias,
                                SearchRequestId = request.Id,
                                ResidenceId = residence.Id
                            };

                            dbContext.RequestResults.Add(requestResult);
                        }

                        dbContext.SaveChangesAsync();
                    }
                }

                dbContext.TempResidences.RemoveRange(dbContext.TempResidences.Where(rtemp => updatedIds.Contains(rtemp.Id)));

                dbContext.SaveChangesAsync();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
