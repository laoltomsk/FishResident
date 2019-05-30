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

        public String Address { get; set; }

        [Required]
        public String OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}
