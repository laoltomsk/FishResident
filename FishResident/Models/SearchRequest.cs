using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class SearchRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public String Address { get; set; }

        public Double Area { get; set; }

        public Double Cost { get; set; }

        [Required]
        public String UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Residence> Results { get; set; }

        public ICollection<FeatureRequest> FeatureRequests { get; set; }
    }
}
