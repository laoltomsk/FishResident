using FishResident.Data;
using FishResident.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Services
{
    public class AgreementService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;

        public AgreementService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        private HttpContext HttpContext => _httpContextAccessor.HttpContext;

        public String WhatCanIDoWithResidence(Residence residence)
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return "0";
            }

            if (_userManager.GetUserId(_httpContextAccessor.HttpContext.User) == residence.OwnerId)
            {
                return "0";
            }

            var agreements = _context.Agreements
                .Where(r => r.ResidenceId == residence.Id && r.ResidentId == _userManager.GetUserId(_httpContextAccessor.HttpContext.User))
                .ToList();

            if (agreements.Count() > 0)
            {
                return agreements.First().Id.ToString();
            }
            else
            {
                return "1";
            }
        }
    }
}
