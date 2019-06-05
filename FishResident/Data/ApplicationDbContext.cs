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

        public DbSet<FeatureValue> FeatureValues { get; set; }

        public DbSet<SearchRequest> SearchRequests { get; set; }

        public DbSet<FeatureRequest> FeatureRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var bedroomNum = new { Name = "Number of Bedrooms", Id = Guid.NewGuid() };
            var bedroomNums = new[]
            {
                new { FeatureTypeId = bedroomNum.Id, Value = "0", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "1", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "2", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "3", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "4", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "5", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "6", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "7", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "8", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "9", Id = Guid.NewGuid() },
                new { FeatureTypeId = bedroomNum.Id, Value = "10+", Id = Guid.NewGuid() }
            };

            var bathroomNum = new { Name = "Number of Bathrooms", Id = Guid.NewGuid() };
            var bathroomNums = new[] {
                new { FeatureTypeId = bathroomNum.Id, Value = "0", Id = Guid.NewGuid() },
                new { FeatureTypeId = bathroomNum.Id, Value = "1", Id = Guid.NewGuid() },
                new { FeatureTypeId = bathroomNum.Id, Value = "2", Id = Guid.NewGuid() },
                new { FeatureTypeId = bathroomNum.Id, Value = "3", Id = Guid.NewGuid() },
                new { FeatureTypeId = bathroomNum.Id, Value = "4", Id = Guid.NewGuid() },
                new { FeatureTypeId = bathroomNum.Id, Value = "5+", Id = Guid.NewGuid() }
            };

            var kitchenSize = new { Name = "Kitchen size", Id = Guid.NewGuid() };
            var kitchenSizes = new[]
            {
                new { FeatureTypeId = kitchenSize.Id, Value = "Small", Id = Guid.NewGuid() },
                new { FeatureTypeId = kitchenSize.Id, Value = "Medium", Id = Guid.NewGuid() },
                new { FeatureTypeId = kitchenSize.Id, Value = "Large", Id = Guid.NewGuid() }
            };

            var garage = new { Name = "Garage", Id = Guid.NewGuid() };
            var garages = new[]
            {
                new { FeatureTypeId = garage.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = garage.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var autospaceNum = new { Name = "Number of Auto Spaces", Id = Guid.NewGuid() };
            var autospaceNums = new[] {
                new { FeatureTypeId = autospaceNum.Id, Value = "0", Id = Guid.NewGuid() },
                new { FeatureTypeId = autospaceNum.Id, Value = "1", Id = Guid.NewGuid() },
                new { FeatureTypeId = autospaceNum.Id, Value = "2", Id = Guid.NewGuid() },
                new { FeatureTypeId = autospaceNum.Id, Value = "3", Id = Guid.NewGuid() },
                new { FeatureTypeId = autospaceNum.Id, Value = "4", Id = Guid.NewGuid() },
                new { FeatureTypeId = autospaceNum.Id, Value = "5+", Id = Guid.NewGuid() }
            };

            var pets = new { Name = "Pets Allowed", Id = Guid.NewGuid() };
            var petses = new[]
            {
                new { FeatureTypeId = pets.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = pets.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var ac = new { Name = "Air Conditioning", Id = Guid.NewGuid() };
            var acs = new[]
            {
                new { FeatureTypeId = ac.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = ac.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var balconyType = new { Name = "Balcony Type", Id = Guid.NewGuid() };
            var balconyTypes = new[]
            {
                new { FeatureTypeId = balconyType.Id, Value = "Balcony", Id = Guid.NewGuid() },
                new { FeatureTypeId = balconyType.Id, Value = "Patio", Id = Guid.NewGuid() },
                new { FeatureTypeId = balconyType.Id, Value = "Deck", Id = Guid.NewGuid() }
            };

            var cable = new { Name = "Cable Ready", Id = Guid.NewGuid() };
            var cables = new[]
            {
                new { FeatureTypeId = cable.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = cable.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var dishwasher = new { Name = "Dishwasher", Id = Guid.NewGuid() };
            var dishwashers = new[]
            {
                new { FeatureTypeId = dishwasher.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = dishwasher.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var microwave = new { Name = "Microwave Included", Id = Guid.NewGuid() };
            var microwaves = new[]
            {
                new { FeatureTypeId = microwave.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = microwave.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var handicap = new { Name = "Handicap Accessible", Id = Guid.NewGuid() };
            var handicaps = new[]
            {
                new { FeatureTypeId = handicap.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = handicap.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var hardwood = new { Name = "Hardwood Floors", Id = Guid.NewGuid() };
            var hardwoods = new[]
            {
                new { FeatureTypeId = hardwood.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = hardwood.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var covered = new { Name = "Utilities Covered", Id = Guid.NewGuid() };
            var covereds = new[]
            {
                new { FeatureTypeId = covered.Id, Value = "Some", Id = Guid.NewGuid() },
                new { FeatureTypeId = covered.Id, Value = "All", Id = Guid.NewGuid() }
            };

            var walkin = new { Name = "Walk-In Closets", Id = Guid.NewGuid() };
            var walkins = new[]
            {
                new { FeatureTypeId = walkin.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = walkin.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var washerdryer = new { Name = "Washer/Dryer Included", Id = Guid.NewGuid() };
            var washerdryers = new[]
            {
                new { FeatureTypeId = washerdryer.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = washerdryer.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var security = new { Name = "Security System", Id = Guid.NewGuid() };
            var securities = new[]
            {
                new { FeatureTypeId = security.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = security.Id, Value = "No", Id = Guid.NewGuid() }
            };


            var access = new { Name = "Limited/Controlled Access", Id = Guid.NewGuid() };
            var accesses = new[]
            {
                new { FeatureTypeId = access.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = access.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var elevator = new { Name = "Elevator", Id = Guid.NewGuid() };
            var elevators = new[]
            {
                new { FeatureTypeId = elevator.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = elevator.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var storage = new { Name = "Extra Storage", Id = Guid.NewGuid() };
            var storages = new[]
            {
                new { FeatureTypeId = storage.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = storage.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var fitness = new { Name = "Fitness Center Nearby", Id = Guid.NewGuid() };
            var fitnesses = new[]
            {
                new { FeatureTypeId = fitness.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = fitness.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var business = new { Name = "Business Center Nearby", Id = Guid.NewGuid() };
            var businesses = new[]
            {
                new { FeatureTypeId = business.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = business.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var laundry = new { Name = "Laundry Facility Nearby", Id = Guid.NewGuid() };
            var laundries = new[]
            {
                new { FeatureTypeId = laundry.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = laundry.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var pool = new { Name = "Pool Nearby", Id = Guid.NewGuid() };
            var pools = new[]
            {
                new { FeatureTypeId = pool.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = pool.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var park = new { Name = "Park Nearby", Id = Guid.NewGuid() };
            var parks = new[]
            {
                new { FeatureTypeId = park.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = park.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var senior = new { Name = "Senior Living", Id = Guid.NewGuid() };
            var seniors = new[]
            {
                new { FeatureTypeId = senior.Id, Value = "Yes", Id = Guid.NewGuid() },
                new { FeatureTypeId = senior.Id, Value = "No", Id = Guid.NewGuid() }
            };

            var neighbourhoodType = new { Name = "Neighbourhood Type", Id = Guid.NewGuid() };
            var neighbourhoodTypes = new[]
            {
                new { FeatureTypeId = neighbourhoodType.Id, Value = "Downtown", Id = Guid.NewGuid() },
                new { FeatureTypeId = neighbourhoodType.Id, Value = "Uptown", Id = Guid.NewGuid() },
                new { FeatureTypeId = neighbourhoodType.Id, Value = "Rural", Id = Guid.NewGuid() },
                new { FeatureTypeId = neighbourhoodType.Id, Value = "Suburban", Id = Guid.NewGuid() }
            };

            builder.Entity<FeatureType>().HasData(bedroomNum);
            builder.Entity<FeatureType>().HasData(bathroomNum);
            builder.Entity<FeatureType>().HasData(kitchenSize);
            builder.Entity<FeatureType>().HasData(garage);
            builder.Entity<FeatureType>().HasData(autospaceNum);
            builder.Entity<FeatureType>().HasData(pets);
            builder.Entity<FeatureType>().HasData(ac);
            builder.Entity<FeatureType>().HasData(balconyType);
            builder.Entity<FeatureType>().HasData(cable);
            builder.Entity<FeatureType>().HasData(dishwasher);
            builder.Entity<FeatureType>().HasData(microwave);
            builder.Entity<FeatureType>().HasData(handicap);
            builder.Entity<FeatureType>().HasData(hardwood);
            builder.Entity<FeatureType>().HasData(covered);
            builder.Entity<FeatureType>().HasData(walkin);
            builder.Entity<FeatureType>().HasData(washerdryer);
            builder.Entity<FeatureType>().HasData(security);
            builder.Entity<FeatureType>().HasData(access);
            builder.Entity<FeatureType>().HasData(elevator);
            builder.Entity<FeatureType>().HasData(storage);
            builder.Entity<FeatureType>().HasData(fitness);
            builder.Entity<FeatureType>().HasData(business);
            builder.Entity<FeatureType>().HasData(laundry);
            builder.Entity<FeatureType>().HasData(pool);
            builder.Entity<FeatureType>().HasData(park);
            builder.Entity<FeatureType>().HasData(senior);
            builder.Entity<FeatureType>().HasData(neighbourhoodType);

            builder.Entity<FeatureAllowedValue>().HasData(bedroomNums);
            builder.Entity<FeatureAllowedValue>().HasData(bathroomNums);
            builder.Entity<FeatureAllowedValue>().HasData(kitchenSizes);
            builder.Entity<FeatureAllowedValue>().HasData(garages);
            builder.Entity<FeatureAllowedValue>().HasData(autospaceNums);
            builder.Entity<FeatureAllowedValue>().HasData(petses);
            builder.Entity<FeatureAllowedValue>().HasData(acs);
            builder.Entity<FeatureAllowedValue>().HasData(balconyTypes);
            builder.Entity<FeatureAllowedValue>().HasData(cables);
            builder.Entity<FeatureAllowedValue>().HasData(dishwashers);
            builder.Entity<FeatureAllowedValue>().HasData(microwaves);
            builder.Entity<FeatureAllowedValue>().HasData(handicaps);
            builder.Entity<FeatureAllowedValue>().HasData(hardwoods);
            builder.Entity<FeatureAllowedValue>().HasData(covereds);
            builder.Entity<FeatureAllowedValue>().HasData(walkins);
            builder.Entity<FeatureAllowedValue>().HasData(washerdryers);
            builder.Entity<FeatureAllowedValue>().HasData(securities);
            builder.Entity<FeatureAllowedValue>().HasData(accesses);
            builder.Entity<FeatureAllowedValue>().HasData(elevators);
            builder.Entity<FeatureAllowedValue>().HasData(storages);
            builder.Entity<FeatureAllowedValue>().HasData(fitnesses);
            builder.Entity<FeatureAllowedValue>().HasData(businesses);
            builder.Entity<FeatureAllowedValue>().HasData(laundries);
            builder.Entity<FeatureAllowedValue>().HasData(pools);
            builder.Entity<FeatureAllowedValue>().HasData(parks);
            builder.Entity<FeatureAllowedValue>().HasData(seniors);
            builder.Entity<FeatureAllowedValue>().HasData(neighbourhoodTypes);
        }
    }
}
