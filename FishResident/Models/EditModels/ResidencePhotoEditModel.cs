using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models.EditModels
{
    public class ResidencePhotoEditModel
    {
        public IFormFile File { get; set; }
    }
}
