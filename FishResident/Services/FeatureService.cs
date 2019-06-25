using FishResident.Data;
using FishResident.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Services
{
    public class FeatureService
    {
        private readonly ApplicationDbContext _context;

        public FeatureService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<FeatureType> GetFeatureTypes()
        {
            var types =  _context.FeatureTypes
                .Include(r => r.AllowedValues)
                .OrderBy(r => r.Name)
                .ToList();

            types.ForEach(x => x.AllowedValues = x.AllowedValues.OrderBy(y => y.Value).ToList());

            return types;
        } 
    }
}
