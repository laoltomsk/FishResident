using FishResident.Data;
using FishResident.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Services
{
    public class UpdateRequestsService
    {
        private readonly ApplicationDbContext _context;

        public UpdateRequestsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateRequest(Guid? ResidenceId, Guid? RequestId)
        {
            List<Residence> residences;
            List<SearchRequest> requests;

            if (ResidenceId == null)
            {
                residences = await _context.Residences
                    .Include(r => r.Features)
                    .ThenInclude(f => f.FeatureType)
                    .ToListAsync();
            }
            else
            {
                residences = await _context.Residences
                    .Where(r => r.Id == ResidenceId)
                    .Include(r => r.Features)
                    .ThenInclude(f => f.FeatureType)
                    .ToListAsync();
            }

            if (RequestId == null)
            {
                requests = await _context.SearchRequests
                    .Include(r => r.FeatureRequests)
                    .ThenInclude(r => r.FeatureType)
                    .ToListAsync();
            }
            else
            {
                requests = await _context.SearchRequests.Where(r => r.Id == RequestId).ToListAsync();
            }

            foreach (Residence residence in residences)
            {
                foreach (SearchRequest request in requests)
                {
                    _context.RequestResults.RemoveRange(_context.RequestResults.Where(r => r.ResidenceId == residence.Id && r.SearchRequestId == request.Id));

                    if (request.Cost > 1.25 * residence.Cost && request.Area < 0.75 * residence.Area)
                        continue;

                    double criterias = 0, goodCriterias = 0;

                    goodCriterias += 10 * Math.Min(request.Area / residence.Area, residence.Area / request.Area);
                    criterias += 10;

                    goodCriterias += 10 * Math.Min(request.Cost / residence.Cost, residence.Cost / request.Cost);
                    criterias += 10;

                    foreach (var criteria in request.FeatureRequests)
                    {
                        var residenceValue = residence.Features.Where(f => f.FeatureTypeId == criteria.FeatureTypeId).First().Value;
                        if (criteria.Value == "Not Specified")
                            continue;

                        if (criteria.Value == residenceValue)
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

                        _context.RequestResults.Add(requestResult);
                    }
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
