using System;
using System.Collections.Generic;
using System.Text;
using FishResident.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FishResident.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Residence> Residences { get; set; }

        public DbSet<Agreement> Agreements { get; set; }

        public DbSet<ResidenceType> ResidenceTypes { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<FeatureAllowedValue> FeatureAllowedValues { get; set; }

        public DbSet<FeatureType> FeatureTypes { get; set; }

        public DbSet<SearchRequest> SearchRequests { get; set; }

        public DbSet<FeatureRequest> FeatureRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
