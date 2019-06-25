using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class Agreement
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime Date { get; set; }

        [Required]
        public Guid ResidenceId { get; set; }

        public Residence Residence { get; set; }

        [Required]
        public String ResidentId { get; set; }

        public ApplicationUser Resident { get; set; }

        [Required]
        public String OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }

        public Boolean isDone { get; set; }
    }
}
