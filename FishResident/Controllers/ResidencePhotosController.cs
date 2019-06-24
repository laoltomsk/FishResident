using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FishResident.Data;
using FishResident.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Net.Http.Headers;
using FishResident.Models.EditModels;

namespace FishResident.Controllers
{
    [Authorize]
    public class ResidencePhotosController : Controller
    {
        private static readonly HashSet<String> AllowedExtensions = new HashSet<String> { ".jpg", ".jpeg", ".png", ".gif" };

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ResidencePhotosController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: ResidencePhotos/Create
        public async Task<IActionResult> Create(Guid? residenceId)
        {
            if (residenceId == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences
                .SingleOrDefaultAsync(m => m.Id == residenceId);
            if (residence == null)
            {
                return NotFound();
            }

            ViewBag.Residence = residence;
            return View(new ResidencePhotoEditModel());
        }

        // POST: ResidencePhotos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Guid? residenceId, ResidencePhotoEditModel model)
        {
            if (residenceId == null)
            {
                return NotFound();
            }

            var residence = await _context.Residences
                .SingleOrDefaultAsync(m => m.Id == residenceId);
            if (residence == null)
            {
                return NotFound();
            }

            var fileName = Path.GetFileName(ContentDispositionHeaderValue.Parse(model.File.ContentDisposition).FileName.Value.Trim('"'));
            var fileExt = Path.GetExtension(fileName).ToLower();
            if (!AllowedExtensions.Contains(fileExt))
            {
                ModelState.AddModelError(nameof(model.File), "This file type is prohibited");
            }

            if (ModelState.IsValid)
            {
                var residencePhoto = new ResidencePhoto
                {
                    ResidenceId = residence.Id
                };

                var attachmentPath = Path.Combine(_hostingEnvironment.WebRootPath, "attachments", residencePhoto.Id.ToString("N") + fileExt);
                residencePhoto.Path = $"/attachments/{residencePhoto.Id:N}{fileExt}";
                residencePhoto.FileName = $"{residencePhoto.Id:N}{fileExt}";
                using (var fileStream = new FileStream(attachmentPath, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Read))
                {
                    await model.File.CopyToAsync(fileStream);
                }

                _context.Add(residencePhoto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Residences", new { id = residence.Id });
            }

            ViewBag.Residence = residence;
            return View(model);
        }

        // GET: ResidencePhotos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var residencePhoto = await _context.ResidencePhotos
                .Include(p => p.Residence)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (residencePhoto == null)
            {
                return NotFound();
            }

            return this.View(residencePhoto);
        }

        // POST: ResidencePhotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residencePhoto = await _context.ResidencePhotos
                .Include(p => p.Residence)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (residencePhoto == null)
            {
                return NotFound();
            }

            var attachmentPath = Path.Combine(_hostingEnvironment.WebRootPath, "attachments", residencePhoto.Id.ToString("N") + Path.GetExtension(residencePhoto.Path));
            System.IO.File.Delete(attachmentPath);
            _context.ResidencePhotos.Remove(residencePhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Residences", new { id = residencePhoto.ResidenceId });
        }

        private bool ResidencePhotoExists(Guid id)
        {
            return _context.ResidencePhotos.Any(e => e.Id == id);
        }
    }
}
