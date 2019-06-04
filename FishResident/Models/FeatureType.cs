using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class FeatureType
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public String Name { get; set; }

        public String AdditionalInfo { get; set; }

        public ICollection<FeatureAllowedValue> AllowedValues { get; set; }

        //TODO: public FeatureTypeComparator Comparator { get; set; }
    }
}
