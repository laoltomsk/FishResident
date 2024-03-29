﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FishResident.Data;
using FishResident.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using FishResident.Models.EditModels;
using FishResident.Services;


namespace FishResident.Controllers
{
    [Authorize]
    public class RequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IPermissionService _userPermissions;
        private readonly UpdateRequestsService _updateRequestsService;

        public RequestsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IPermissionService userPermissions, UpdateRequestsService updateRequestsService)
        {
            _context = context;
            _userManager = userManager;
            _userPermissions = userPermissions;
            _updateRequestsService = updateRequestsService;
        }

        // GET: Requests
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var residences = await _context.SearchRequests
                .Include(r => r.User)
                .Include(r => r.Results)
                .Where(r => r.UserId == user.Id)
                .ToListAsync();

            return View(residences);
        }

        // GET: Residences/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            var model = new RequestEditModel();
            model.Results = new List<RequestResult>();

            var residences = _context.Residences
                .Include(r => r.Features)
                .Include(r => r.ResidencePhotos)
                .Include(r => r.Type)
                .Take(5);

            foreach (var residence in residences)
            {
                model.Results.Add(new RequestResult
                {
                    Relevance = (new Random()).NextDouble(),
                    ResidenceId = residence.Id,
                    Residence = residence
                });
            }

            return View(model);
        }

        // POST: Residences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequestEditModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            model.Results = new List<RequestResult>();

            if (ModelState.IsValid)
            {
                var request = new SearchRequest
                {
                    Address = model.Address,
                    Area = model.Area,
                    Cost = model.Cost
                };

                if (user != null)
                {
                    request.UserId = user.Id;
                    _context.SearchRequests.Add(request);

                    foreach (KeyValuePair<Guid, String> kvp in model.Features)
                    {
                        var feature = new FeatureRequest
                        {
                            SearchRequestId = request.Id,
                            FeatureTypeId = kvp.Key,
                            Value = kvp.Value
                        };

                        _context.FeatureRequests.Add(feature);
                    }
                }

                var residences = await _context.Residences
                    .Where (r => r.Cost < 1.25 * model.Cost && r.Area > 0.75 * model.Area)
                    .Include(r => r.Features)
                    .ThenInclude(f => f.FeatureType)
                    .ToListAsync();

                foreach (var residence in residences)
                {
                    double criterias = 0, goodCriterias = 0;

                    goodCriterias += Math.Min(model.Area / residence.Area, residence.Area / model.Area);
                    criterias++;

                    goodCriterias += Math.Min(model.Cost / residence.Cost, residence.Cost / model.Cost);
                    criterias++;

                    foreach (var criteria in model.Features)
                    {
                        var residenceValue = residence.Features.Where(f => f.FeatureTypeId == criteria.Key).First().Value;
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

                        if (user != null)
                        {
                            _context.RequestResults.Add(requestResult);
                        }

                        model.Results.Add(new RequestResult
                        {
                            Relevance = goodCriterias / criterias,
                            ResidenceId = residence.Id,
                            Residence = await _context.Residences
                                .Where(r => r.Id == residence.Id)
                                .Include(r => r.Type)
                                .Include(r => r.Features)
                                .Include(r => r.ResidencePhotos)
                                .SingleOrDefaultAsync()
                        });
                    }
                }

                await _context.SaveChangesAsync();

                if (user != null)
                {
                    return Redirect("/Requests/Edit/" + request.Id.ToString());
                }

            }

            return View(model);
        }

        // GET: Residences/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.SearchRequests
                .Include(r => r.User)
                .Include(r => r.FeatureRequests)
                .ThenInclude(f => f.FeatureType)
                .Include(r => r.Results)
                .ThenInclude(r => r.Residence)
                .ThenInclude(r => r.Type)
                .Include(r => r.Results)
                .ThenInclude(r => r.Residence)
                .ThenInclude(r => r.ResidencePhotos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (request == null || !_userPermissions.IsOwnerOfRequest(request))
            {
                return NotFound();
            }

            var model = new RequestEditModel
            {
                Address = request.Address,
                Area = request.Area,
                Cost = request.Cost,
                Features = new Dictionary<Guid, string>(),
                Results = request.Results
            };

            foreach (var feature in request.FeatureRequests)
            {
                model.Features[feature.FeatureType.Id] = feature.Value;
            }

            return View(model);
        }

        // POST: Residences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid? id, RequestEditModel model)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.SearchRequests
                .Include(r => r.Results)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (request == null || !_userPermissions.IsOwnerOfRequest(request))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                request.Address = model.Address;
                request.Cost = model.Cost;
                request.Area = model.Area;

                foreach (KeyValuePair<Guid, String> kvp in model.Features)
                {
                    var feature = await _context.FeatureRequests
                        .SingleOrDefaultAsync(m => m.SearchRequestId == id && m.FeatureTypeId == kvp.Key);

                    feature.Value = kvp.Value;
                }

                await _context.SaveChangesAsync();

                await _updateRequestsService.UpdateRequest(null, request.Id);

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // POST: Residences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeAnonimize(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.SearchRequests
                .SingleOrDefaultAsync(m => m.Id == id);

            if (request == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);
            request.UserId = user.Id;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Residences/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.SearchRequests
                .Include(r => r.User)
                .Include(r => r.FeatureRequests)
                .ThenInclude(f => f.FeatureType)
                .Include(r => r.Results)
                .ThenInclude(r => r.Residence)
                .ThenInclude(r => r.Type)
                .Include(r => r.Results)
                .ThenInclude(r => r.Residence)
                .ThenInclude(r => r.ResidencePhotos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (request == null || !_userPermissions.IsOwnerOfRequest(request))
            {
                return NotFound();
            }

            return View(request);
        }

        // POST: Residences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            var request = await _context.SearchRequests.FindAsync(id);

            if (request == null || !_userPermissions.IsOwnerOfRequest(request))
            {
                return NotFound();
            }

            _context.RequestResults.RemoveRange(_context.RequestResults.Where(r => r.SearchRequestId == id));
            await _context.SaveChangesAsync();

            _context.SearchRequests.Remove(request);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestsExists(Guid id)
        {
            return _context.SearchRequests.Any(e => e.Id == id);
        }
    }
}
