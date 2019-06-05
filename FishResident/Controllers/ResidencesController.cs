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

namespace FishResident.Controllers
{
    [Authorize]
    public class ResidencesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ResidencesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Residences
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var residences = await _context.Residences
                .Include(r => r.Owner)
                .Include(r => r.Type)
                .Where(r => r.OwnerId == user.Id)
                .ToListAsync();

            return View(residences);
            //var applicationDbContext = _context.Residences.Include(r => r.Owner).Include(r => r.Type);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Residences/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences
                .Include(r => r.Owner)
                .Include(r => r.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residence == null)
            {
                return NotFound();
            }

            return View(residence);
        }

        // GET: Residences/Create
        public IActionResult Create()
        {
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["TypeId"] = new SelectList(_context.ResidenceTypes, "Id", "Id");
            return View();
        }

        // POST: Residences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Area,Cost,Address,OwnerId,TypeId")] Residence residence)
        {
            if (ModelState.IsValid)
            {
                residence.Id = Guid.NewGuid();
                _context.Add(residence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Id", residence.OwnerId);
            ViewData["TypeId"] = new SelectList(_context.ResidenceTypes, "Id", "Id", residence.TypeId);
            return View(residence);
        }

        // GET: Residences/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences.FindAsync(id);
            if (residence == null)
            {
                return NotFound();
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Id", residence.OwnerId);
            ViewData["TypeId"] = new SelectList(_context.ResidenceTypes, "Id", "Id", residence.TypeId);
            return View(residence);
        }

        // POST: Residences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Area,Cost,Address,OwnerId,TypeId")] Residence residence)
        {
            if (id != residence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidenceExists(residence.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Id", residence.OwnerId);
            ViewData["TypeId"] = new SelectList(_context.ResidenceTypes, "Id", "Id", residence.TypeId);
            return View(residence);
        }

        // GET: Residences/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences
                .Include(r => r.Owner)
                .Include(r => r.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residence == null)
            {
                return NotFound();
            }

            return View(residence);
        }

        // POST: Residences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var residence = await _context.Residences.FindAsync(id);
            _context.Residences.Remove(residence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidenceExists(Guid id)
        {
            return _context.Residences.Any(e => e.Id == id);
        }
    }
}
