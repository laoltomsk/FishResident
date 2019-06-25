using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishResident.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace FishResident.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;

        public PermissionService(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        private HttpContext HttpContext => _httpContextAccessor.HttpContext;

        public bool IsOwnerOfResidence(Residence residence)
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }

            return _userManager.GetUserId(_httpContextAccessor.HttpContext.User) == residence.OwnerId;
        }

        public bool IsOwnerOfRequest(SearchRequest request)
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }

            return _userManager.GetUserId(_httpContextAccessor.HttpContext.User) == request.UserId;
        }
    }
}
