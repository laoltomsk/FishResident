using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class Feature
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Feature LinkedFeature { get; set; }
        
        public Guid? LinkedFeatureId { get; set; }

        public Residence Residence { get; set; }

        public Guid? ResidenceId { get; set; }

        public FeatureType FeatureType { get; set; }

        public Guid? FeatureTypeId { get; set; }

        public String Value { get; set; }
    }
}
