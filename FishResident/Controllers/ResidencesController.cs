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
                .Include(r => r.ResidencePhotos)
                .Where(r => r.OwnerId == user.Id)
                .ToListAsync();

            return View(residences);
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
                .Include(r => r.ResidencePhotos)
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
            ViewBag.TypeId = new SelectList(_context.ResidenceTypes, "Id", "Name");
            return View(new ResidenceEditModel());
        }

        // POST: Residences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResidenceEditModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid && user != null)
            {
                var residence = new Residence
                {
                    TypeId = model.TypeId,
                    Address = model.Address,
                    Area = model.Area,
                    Cost = model.Cost,
                    OwnerId = user.Id
                };

                _context.Residences.Add(residence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.TypeId = new SelectList(_context.ResidenceTypes, "Id", "Name");
            return View(model);
        }

        // GET: Residences/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences.SingleOrDefaultAsync(m => m.Id == id);
            if (residence == null)  //TODO: add permission validation
            {
                return NotFound();
            }

            var model = new ResidenceEditModel
            {
                TypeId = residence.TypeId,
                Address = residence.Address,
                Area = residence.Area,
                Cost = residence.Cost
            };

            ViewBag.TypeId = new SelectList(_context.ResidenceTypes, "Id", "Name");
            return View(model);
        }

        // POST: Residences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid? id, ResidenceEditModel model)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences.SingleOrDefaultAsync(m => m.Id == id);
            if (residence == null)  //TODO: add permission validation
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                residence.TypeId = model.TypeId;
                residence.Address = model.Address;
                residence.Cost = model.Cost;
                residence.Area = model.Area;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.TypeId = new SelectList(_context.ResidenceTypes, "Id", "Name");
            return View(model);
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
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
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
