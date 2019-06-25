using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FishResident.Data;
using FishResident.Models;
using FishResident.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FishResident.Controllers
{
    [Authorize]
    public class AgreementsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMailSenderService _mailSenderService;

        public AgreementsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IMailSenderService mailSenderService)
        {
            _context = context;
            _userManager = userManager;
            _mailSenderService = mailSenderService;
        }

        // POST: Agreements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Guid? residenceId)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (residenceId == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences
                .Include(r => r.Owner)
                .SingleOrDefaultAsync(m => m.Id == residenceId);

            if (residence == null || residence.OwnerId == user.Id)
            {
                return NotFound();
            }

            Agreement agreement = new Agreement();

            agreement.OwnerId = residence.OwnerId;
            agreement.ResidenceId = residence.Id;
            agreement.ResidentId = user.Id;
            agreement.isDone = false;
            agreement.Date = DateTime.UtcNow;

            _context.Add(agreement);
            await _context.SaveChangesAsync();
            _mailSenderService.AnybodyWantYou(residence.Owner.Email);
            return RedirectToAction("Details", "Residences", new { id = residence.Id });
        }

        // POST: Agreements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements
                .Include(r => r.Owner)
                .Include(r => r.Resident)
                .Include(r => r.Residence)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (agreement == null || agreement.OwnerId != user.Id)
            {
                return NotFound();
            }

            agreement.isDone = true;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Residences");
        }

        // POST: Agreements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements
                .Include(r => r.Owner)
                .Include(r => r.Resident)
                .Include(r => r.Residence)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (agreement == null || (agreement.OwnerId != user.Id && agreement.ResidentId != user.Id))
            {
                return NotFound();
            }

            _context.Agreements.Remove(agreement);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Residences", new { id = agreement.Residence.Id });
        }
    }
}
