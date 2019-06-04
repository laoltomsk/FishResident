using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class Subscription
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public String TimePeriod { get; set; }

        public DateTime PaymentDate { get; set; }

        public Double PaymentAmount { get; set; }

        public SubscriptionType Type { get; set; }

        [Required]
        public String SubscriberId { get; set; }

        public ApplicationUser Subscriber { get; set; }
    }
}
