using FishResident.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Services
{
    public interface IPermissionService
    {
        bool IsOwnerOfResidence(Residence residence);

        bool IsOwnerOfRequest(SearchRequest request);
    }
}
