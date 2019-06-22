using System;
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

        public RequestsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IPermissionService userPermissions)
        {
            _context = context;
            _userManager = userManager;
            _userPermissions = userPermissions;
        }

        // GET: Requests
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var residences = await _context.SearchRequests
                .Include(r => r.User)
                .Where(r => r.UserId == user.Id)
                .ToListAsync();

            return View(residences);
        }

        // GET: Requests/Details/5
        public async Task<IActionResult> Details(Guid? id)
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
                .FirstOrDefaultAsync(m => m.Id == id);

            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // GET: Residences/Create
        public IActionResult Create()
        {
            return View(new RequestEditModel());
        }

        // POST: Residences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequestEditModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid && user != null)
            {
                var request = new SearchRequest
                {
                    Address = model.Address,
                    Area = model.Area,
                    Cost = model.Cost,
                    UserId = user.Id
                };

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
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
                Features = new Dictionary<Guid, string>()
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

            var request = await _context.SearchRequests.SingleOrDefaultAsync(m => m.Id == id);
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
                return RedirectToAction(nameof(Index));
            }

            return View(model);
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
