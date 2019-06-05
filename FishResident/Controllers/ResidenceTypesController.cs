using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FishResident.Data;
using FishResident.Models;
using Microsoft.AspNetCore.Authorization;

namespace FishResident.Controllers
{
    [Authorize]
    public class ResidenceTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResidenceTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ResidenceTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ResidenceTypes.ToListAsync());
        }

        // GET: ResidenceTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residenceType = await _context.ResidenceTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residenceType == null)
            {
                return NotFound();
            }

            return View(residenceType);
        }

        // GET: ResidenceTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResidenceTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ResidenceType residenceType)
        {
            if (ModelState.IsValid)
            {
                residenceType.Id = Guid.NewGuid();
                _context.Add(residenceType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(residenceType);
        }

        // GET: ResidenceTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residenceType = await _context.ResidenceTypes.FindAsync(id);
            if (residenceType == null)
            {
                return NotFound();
            }
            return View(residenceType);
        }

        // POST: ResidenceTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] ResidenceType residenceType)
        {
            if (id != residenceType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residenceType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidenceTypeExists(residenceType.Id))
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
            return View(residenceType);
        }

        // GET: ResidenceTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residenceType = await _context.ResidenceTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residenceType == null)
            {
                return NotFound();
            }

            return View(residenceType);
        }

        // POST: ResidenceTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var residenceType = await _context.ResidenceTypes.FindAsync(id);
            _context.ResidenceTypes.Remove(residenceType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidenceTypeExists(Guid id)
        {
            return _context.ResidenceTypes.Any(e => e.Id == id);
        }
    }
}
