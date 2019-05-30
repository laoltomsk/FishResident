using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class FeatureRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public String Value { get; set; }

        [Required]
        public Guid SearchRequestId { get; set; }

        public SearchRequest SearchRequest { get; set; }

        [Required]
        public Guid FeatureId { get; set; }

        public Feature Feature { get; set; }
    }
}
