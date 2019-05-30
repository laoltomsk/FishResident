using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String SecondaryEmail { get; set; }

        public String GeneralOfficePhone { get; set; }

        public String OfficePhoneExtension { get; set; }

        public String DirectOfficePhone { get; set; }

        public String CellPhone { get; set; }

        public String Contacts { get; set; }
    }
}
