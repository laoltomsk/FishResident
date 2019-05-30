using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public ICollection<Subscription> Subscriptions { get; set; }

        //public ICollection<Residence> Residences { get; set; }
    }
}
