using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class ResidencePhoto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ResidenceId { get; set; }

        public Residence Residence { get; set; }

        [Required]
        public String Path { get; set; }

        [Required]
        public String FileName { get; set; }
    }
}
