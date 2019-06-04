using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class FeatureValue
    {
        public Guid Id { get; set; }

        public Feature Feature { get; set; }

        public Guid FeatureId { get; set; }

        public String Value { get; set; }
    }
}
