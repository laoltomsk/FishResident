using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models
{
    public class Residence
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        //basic fields here?
        //как мне кажется, как минимум вещественные величины (площадь и всякое такое) нужно вынести сюда

        public Double Area { get; set; }

        public Double Cost { get; set; }

        public String Address { get; set; }

        [Required]
        public String OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }

        [Required]
        public Guid TypeId { get; set; }

        public ResidenceType Type { get; set; }

        public ICollection<Agreement> Agreements { get; set; }

        public ICollection<ResidencePhoto> ResidencePhotos { get; set; }

        public ICollection<Feature> Features { get; set; }

        public ICollection<RequestResult> Requests { get; set; }
    }
}
