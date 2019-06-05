using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class FeatureAllowedValue
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public FeatureType FeatureType { get; set; }

        public Guid FeatureTypeId { get; set; }

        public String Value { get; set; }
    }
}
