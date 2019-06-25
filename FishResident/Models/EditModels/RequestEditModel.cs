using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Models.EditModels
{
    public class RequestEditModel
    {
        public Double Area { get; set; }

        public Double Cost { get; set; }

        public String Address { get; set; }

        public Dictionary<Guid, String> Features { get; set; }
    }
}
