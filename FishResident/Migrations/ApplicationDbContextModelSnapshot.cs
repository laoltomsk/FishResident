﻿// <auto-generated />
using System;
using FishResident.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FishResident.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FishResident.Models.Agreement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("OwnerId")
                        .IsRequired();

                    b.Property<Guid>("ResidenceId");

                    b.Property<string>("ResidentId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ResidenceId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("FishResident.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("CellPhone");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Contacts");

                    b.Property<string>("DirectOfficePhone");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("GeneralOfficePhone");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OfficePhoneExtension");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecondaryEmail");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FishResident.Models.Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FeatureTypeId");

                    b.Property<Guid?>("LinkedFeatureId");

                    b.HasKey("Id");

                    b.HasIndex("FeatureTypeId");

                    b.HasIndex("LinkedFeatureId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("FishResident.Models.FeatureAllowedValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FeatureTypeId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureTypeId");

                    b.ToTable("FeatureAllowedValues");

                    b.HasData(
                        new { Id = new Guid("fa918432-7b7a-4b91-8e0a-83a49a5e392e"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "0" },
                        new { Id = new Guid("525f635d-fe25-435b-9cae-0a95137d14e8"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "1" },
                        new { Id = new Guid("d6fdce53-7f6c-404b-9b67-aaea504f18dc"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "2" },
                        new { Id = new Guid("50f6907e-da5a-49fc-be3d-8a9d8367b58f"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "3" },
                        new { Id = new Guid("f77802c4-1f7b-4f5a-8096-1b198c57ed60"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "4" },
                        new { Id = new Guid("9e6c0907-5e0b-4e38-89b7-14976ad278f7"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "5" },
                        new { Id = new Guid("5c5c68b2-013b-42d5-9391-cf39401248ba"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "6" },
                        new { Id = new Guid("ecff293a-455d-48e8-bb46-10d722adcd93"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "7" },
                        new { Id = new Guid("29846360-521a-468a-acb1-aae65dd62f05"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "8" },
                        new { Id = new Guid("f70c4be9-c6df-4d17-bf99-8bf3ced23879"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "9" },
                        new { Id = new Guid("113ab5fc-9c5b-40b0-b74c-32ff4ff39fdf"), FeatureTypeId = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Value = "10+" },
                        new { Id = new Guid("6de57549-7475-4717-83f3-793f74eaf474"), FeatureTypeId = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Value = "0" },
                        new { Id = new Guid("a1ef92ce-2d6f-419b-9bf3-ab78cf6213e0"), FeatureTypeId = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Value = "1" },
                        new { Id = new Guid("d32e3fc9-414c-4da7-84a4-3b269e2937f5"), FeatureTypeId = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Value = "2" },
                        new { Id = new Guid("d3ea09e3-a4a7-4746-845b-7e0a3122848f"), FeatureTypeId = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Value = "3" },
                        new { Id = new Guid("c25245c5-6daa-483e-aff9-e38f05af4d16"), FeatureTypeId = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Value = "4" },
                        new { Id = new Guid("c01be410-8411-4917-b287-49ccd8185ec9"), FeatureTypeId = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Value = "5+" },
                        new { Id = new Guid("b4348094-9466-458c-8580-065814878ab5"), FeatureTypeId = new Guid("f2ab316e-1f3c-426e-8f69-63dc239b8d70"), Value = "Small" },
                        new { Id = new Guid("05329cd2-6d83-42d0-b4c0-f7c6b6dc4fe7"), FeatureTypeId = new Guid("f2ab316e-1f3c-426e-8f69-63dc239b8d70"), Value = "Medium" },
                        new { Id = new Guid("c80488a3-7fbd-4e03-a35e-ff4dbbc7f7a4"), FeatureTypeId = new Guid("f2ab316e-1f3c-426e-8f69-63dc239b8d70"), Value = "Large" },
                        new { Id = new Guid("95368d1e-2bec-46cb-a635-bb222d596a94"), FeatureTypeId = new Guid("950834ce-03cc-4e2a-b9a2-5cd5d0caf383"), Value = "Yes" },
                        new { Id = new Guid("3b04b036-04db-4ebc-b626-6a57b18a9c28"), FeatureTypeId = new Guid("950834ce-03cc-4e2a-b9a2-5cd5d0caf383"), Value = "No" },
                        new { Id = new Guid("a3d55b07-2555-4c78-80af-db786e19c45d"), FeatureTypeId = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Value = "0" },
                        new { Id = new Guid("ca540083-8668-4965-916c-e19128da2d4c"), FeatureTypeId = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Value = "1" },
                        new { Id = new Guid("c675f363-f161-4822-a019-b22eb563fed8"), FeatureTypeId = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Value = "2" },
                        new { Id = new Guid("88ff9ae1-5389-4d0c-89be-23dd7b561cbb"), FeatureTypeId = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Value = "3" },
                        new { Id = new Guid("b7f7345a-fd57-4e5f-a623-0ff7fd9777c5"), FeatureTypeId = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Value = "4" },
                        new { Id = new Guid("41d37540-fd65-45ef-b282-d7b9c2b1e615"), FeatureTypeId = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Value = "5+" },
                        new { Id = new Guid("a1aafee9-e37a-4143-a6ab-2d9b471c950f"), FeatureTypeId = new Guid("cd0f43b7-25d1-4f2f-92f7-05da68943237"), Value = "Yes" },
                        new { Id = new Guid("791e22b1-6fbe-41f0-a7ff-dbd2046a84c2"), FeatureTypeId = new Guid("cd0f43b7-25d1-4f2f-92f7-05da68943237"), Value = "No" },
                        new { Id = new Guid("367d9a9d-2f4d-45f5-a0df-b21ab1a6db22"), FeatureTypeId = new Guid("5a2f92fc-a4c2-4367-a901-7cd29b0cecdf"), Value = "Yes" },
                        new { Id = new Guid("6ec7341f-f339-43e6-9302-65f74ff889e6"), FeatureTypeId = new Guid("5a2f92fc-a4c2-4367-a901-7cd29b0cecdf"), Value = "No" },
                        new { Id = new Guid("c1878928-7e82-4b88-84b1-514dcd6af2c8"), FeatureTypeId = new Guid("dda9588f-f99c-4da2-b4a2-52ee80ce073a"), Value = "Balcony" },
                        new { Id = new Guid("f15927ae-2536-4685-bb4f-f261a686cf78"), FeatureTypeId = new Guid("dda9588f-f99c-4da2-b4a2-52ee80ce073a"), Value = "Patio" },
                        new { Id = new Guid("c47ab510-4711-482c-8367-e39e4fb6b219"), FeatureTypeId = new Guid("dda9588f-f99c-4da2-b4a2-52ee80ce073a"), Value = "Deck" },
                        new { Id = new Guid("647b7f14-f192-42a9-9420-fd5928f45226"), FeatureTypeId = new Guid("eb77719f-3e58-4ab6-9a6a-bb717c9787a4"), Value = "Yes" },
                        new { Id = new Guid("e5242e0c-9855-4811-a6bc-3615886cc5d8"), FeatureTypeId = new Guid("eb77719f-3e58-4ab6-9a6a-bb717c9787a4"), Value = "No" },
                        new { Id = new Guid("709cbf27-c7c8-462e-b4b9-33aeacfdfafa"), FeatureTypeId = new Guid("bac291d2-1c68-4996-ab66-69a08e9d5aba"), Value = "Yes" },
                        new { Id = new Guid("6d44678c-aad5-493d-a061-ebbd4e7245c2"), FeatureTypeId = new Guid("bac291d2-1c68-4996-ab66-69a08e9d5aba"), Value = "No" },
                        new { Id = new Guid("78b6f277-a467-4bd3-848f-9d857064d36b"), FeatureTypeId = new Guid("d306af3e-7431-4533-85a4-e80db6e0f360"), Value = "Yes" },
                        new { Id = new Guid("65de1574-8f11-44b5-a16e-8171a3adf271"), FeatureTypeId = new Guid("d306af3e-7431-4533-85a4-e80db6e0f360"), Value = "No" },
                        new { Id = new Guid("be8d2d67-10c2-4fc7-a0ff-95c054e591f1"), FeatureTypeId = new Guid("101a9b11-82b1-4547-b736-b199ffccbe81"), Value = "Yes" },
                        new { Id = new Guid("89ebf030-f549-4581-89ba-51f51ee8ae0c"), FeatureTypeId = new Guid("101a9b11-82b1-4547-b736-b199ffccbe81"), Value = "No" },
                        new { Id = new Guid("ba101647-3286-4e51-b0f7-efd10c154947"), FeatureTypeId = new Guid("a3ae9e4b-56d3-4025-8a3a-7c7e611ee002"), Value = "Yes" },
                        new { Id = new Guid("9711feb6-ca10-4746-98a4-96b9af820bb3"), FeatureTypeId = new Guid("a3ae9e4b-56d3-4025-8a3a-7c7e611ee002"), Value = "No" },
                        new { Id = new Guid("856b5be3-59ad-46e1-8fa7-e5184388f4ea"), FeatureTypeId = new Guid("01d40334-e989-4b4d-b23a-dbf6c9b111bf"), Value = "Some" },
                        new { Id = new Guid("093cbbfa-0bcd-4246-9c57-f74dc23b21d7"), FeatureTypeId = new Guid("01d40334-e989-4b4d-b23a-dbf6c9b111bf"), Value = "All" },
                        new { Id = new Guid("12d02048-8bca-4dfb-b62b-72ad84e6a332"), FeatureTypeId = new Guid("5134c538-8609-47f9-8777-3b3fe5b6f6ca"), Value = "Yes" },
                        new { Id = new Guid("ada7f18b-4e4f-4dcd-949c-f69fa67a3121"), FeatureTypeId = new Guid("5134c538-8609-47f9-8777-3b3fe5b6f6ca"), Value = "No" },
                        new { Id = new Guid("bd7e0089-5055-4c1a-85a7-78936dc890c9"), FeatureTypeId = new Guid("8416f139-ae22-4e8a-aa00-cd23626e9c0d"), Value = "Yes" },
                        new { Id = new Guid("02f2802b-6342-44cb-802b-64ceeba7a3e8"), FeatureTypeId = new Guid("8416f139-ae22-4e8a-aa00-cd23626e9c0d"), Value = "No" },
                        new { Id = new Guid("4db6d55e-87f3-420a-92c0-064cc49eb3d7"), FeatureTypeId = new Guid("ab858d2f-899d-44a7-a8b8-315bfbf8a791"), Value = "Yes" },
                        new { Id = new Guid("de1f9ef7-cecf-41f2-b74c-30385db69fc7"), FeatureTypeId = new Guid("ab858d2f-899d-44a7-a8b8-315bfbf8a791"), Value = "No" },
                        new { Id = new Guid("17215760-24ae-4d48-90aa-097616a47e4e"), FeatureTypeId = new Guid("ccafb073-a511-40ce-9827-527c18b9cba1"), Value = "Yes" },
                        new { Id = new Guid("291ce16e-dfa3-4e53-844e-f0fa583c42e9"), FeatureTypeId = new Guid("ccafb073-a511-40ce-9827-527c18b9cba1"), Value = "No" },
                        new { Id = new Guid("541e365f-8cf7-4a3b-8cee-b10a13902ad8"), FeatureTypeId = new Guid("3a8f6c2b-0ac8-4e43-a69e-a44851f0271e"), Value = "Yes" },
                        new { Id = new Guid("f513b01c-8968-431b-9ba2-dfea1ca7fec4"), FeatureTypeId = new Guid("3a8f6c2b-0ac8-4e43-a69e-a44851f0271e"), Value = "No" },
                        new { Id = new Guid("0678cc51-0878-44d5-9085-61440156d409"), FeatureTypeId = new Guid("a101e9a9-363c-43d0-b996-b6fb06c96ea4"), Value = "Yes" },
                        new { Id = new Guid("3119e429-73f9-4bc4-9374-0433106a45d9"), FeatureTypeId = new Guid("a101e9a9-363c-43d0-b996-b6fb06c96ea4"), Value = "No" },
                        new { Id = new Guid("9d63591f-bda8-4331-b984-1bc393802cdc"), FeatureTypeId = new Guid("aad80023-43c1-404f-8011-3c41745298f2"), Value = "Yes" },
                        new { Id = new Guid("f9629f09-50c8-4379-950e-4b5efb417c37"), FeatureTypeId = new Guid("aad80023-43c1-404f-8011-3c41745298f2"), Value = "No" },
                        new { Id = new Guid("8764f0e2-7b8e-48f6-b772-11e7f147af16"), FeatureTypeId = new Guid("a77e36a4-e2d3-4ee7-87fa-32a6c50c3f8f"), Value = "Yes" },
                        new { Id = new Guid("e419c4b5-d8f4-43fe-b62b-16365b5712a8"), FeatureTypeId = new Guid("a77e36a4-e2d3-4ee7-87fa-32a6c50c3f8f"), Value = "No" },
                        new { Id = new Guid("fc3dcc04-1dee-498f-a53a-60498729611f"), FeatureTypeId = new Guid("979b2a54-2d29-4bc9-98b1-8864814bf743"), Value = "Yes" },
                        new { Id = new Guid("02a72a76-7c91-4a99-95cd-4844461b3877"), FeatureTypeId = new Guid("979b2a54-2d29-4bc9-98b1-8864814bf743"), Value = "No" },
                        new { Id = new Guid("e4d20f46-2c73-49ff-9ecf-f4567dacc37e"), FeatureTypeId = new Guid("9ce38c9c-3283-47af-b310-bfeefa33cc23"), Value = "Yes" },
                        new { Id = new Guid("49f74b74-bf12-45f6-af7e-ef16e9f78ab5"), FeatureTypeId = new Guid("9ce38c9c-3283-47af-b310-bfeefa33cc23"), Value = "No" },
                        new { Id = new Guid("75f6f3c7-239f-403f-a130-6fa4ec9da7a3"), FeatureTypeId = new Guid("7dbbf631-d1f5-449f-8a9c-800a72e85dde"), Value = "Yes" },
                        new { Id = new Guid("4baa8e28-497b-4f73-85fc-79a562fcc57d"), FeatureTypeId = new Guid("7dbbf631-d1f5-449f-8a9c-800a72e85dde"), Value = "No" },
                        new { Id = new Guid("c09edbdd-c5c9-481b-8b39-1c9fb77a8473"), FeatureTypeId = new Guid("561b5c9d-dc8f-415d-8342-deef92f7ddd5"), Value = "Yes" },
                        new { Id = new Guid("94491034-ed29-4ed4-9ee4-8da375de278a"), FeatureTypeId = new Guid("561b5c9d-dc8f-415d-8342-deef92f7ddd5"), Value = "No" },
                        new { Id = new Guid("8e44f961-4385-4dc9-aa92-bec5054956bf"), FeatureTypeId = new Guid("225d086d-b22c-4d59-91db-58adfff1619a"), Value = "Downtown" },
                        new { Id = new Guid("312914bd-ab49-41be-b826-3f99b2a32016"), FeatureTypeId = new Guid("225d086d-b22c-4d59-91db-58adfff1619a"), Value = "Uptown" },
                        new { Id = new Guid("5d532283-d9ea-4f64-8f4b-39b925de647c"), FeatureTypeId = new Guid("225d086d-b22c-4d59-91db-58adfff1619a"), Value = "Rural" },
                        new { Id = new Guid("2e12e44f-0510-4045-96ff-fbfa64d91781"), FeatureTypeId = new Guid("225d086d-b22c-4d59-91db-58adfff1619a"), Value = "Suburban" }
                    );
                });

            modelBuilder.Entity("FishResident.Models.FeatureRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FeatureId");

                    b.Property<Guid>("SearchRequestId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("SearchRequestId");

                    b.ToTable("FeatureRequests");
                });

            modelBuilder.Entity("FishResident.Models.FeatureType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FeatureTypes");

                    b.HasData(
                        new { Id = new Guid("11f49f74-1c5f-49f3-916e-573554d7ca74"), Name = "Number of Bedrooms" },
                        new { Id = new Guid("69fae321-faab-4ee7-826a-05e9941ace80"), Name = "Number of Bathrooms" },
                        new { Id = new Guid("f2ab316e-1f3c-426e-8f69-63dc239b8d70"), Name = "Kitchen size" },
                        new { Id = new Guid("950834ce-03cc-4e2a-b9a2-5cd5d0caf383"), Name = "Garage" },
                        new { Id = new Guid("5ce96e6c-85ff-4c49-97b5-a68bb95a9229"), Name = "Number of Auto Spaces" },
                        new { Id = new Guid("cd0f43b7-25d1-4f2f-92f7-05da68943237"), Name = "Pets Allowed" },
                        new { Id = new Guid("5a2f92fc-a4c2-4367-a901-7cd29b0cecdf"), Name = "Air Conditioning" },
                        new { Id = new Guid("dda9588f-f99c-4da2-b4a2-52ee80ce073a"), Name = "Balcony Type" },
                        new { Id = new Guid("eb77719f-3e58-4ab6-9a6a-bb717c9787a4"), Name = "Cable Ready" },
                        new { Id = new Guid("bac291d2-1c68-4996-ab66-69a08e9d5aba"), Name = "Dishwasher" },
                        new { Id = new Guid("d306af3e-7431-4533-85a4-e80db6e0f360"), Name = "Microwave Included" },
                        new { Id = new Guid("101a9b11-82b1-4547-b736-b199ffccbe81"), Name = "Handicap Accessible" },
                        new { Id = new Guid("a3ae9e4b-56d3-4025-8a3a-7c7e611ee002"), Name = "Hardwood Floors" },
                        new { Id = new Guid("01d40334-e989-4b4d-b23a-dbf6c9b111bf"), Name = "Utilities Covered" },
                        new { Id = new Guid("5134c538-8609-47f9-8777-3b3fe5b6f6ca"), Name = "Walk-In Closets" },
                        new { Id = new Guid("8416f139-ae22-4e8a-aa00-cd23626e9c0d"), Name = "Washer/Dryer Included" },
                        new { Id = new Guid("ab858d2f-899d-44a7-a8b8-315bfbf8a791"), Name = "Security System" },
                        new { Id = new Guid("ccafb073-a511-40ce-9827-527c18b9cba1"), Name = "Limited/Controlled Access" },
                        new { Id = new Guid("3a8f6c2b-0ac8-4e43-a69e-a44851f0271e"), Name = "Elevator" },
                        new { Id = new Guid("a101e9a9-363c-43d0-b996-b6fb06c96ea4"), Name = "Extra Storage" },
                        new { Id = new Guid("aad80023-43c1-404f-8011-3c41745298f2"), Name = "Fitness Center Nearby" },
                        new { Id = new Guid("a77e36a4-e2d3-4ee7-87fa-32a6c50c3f8f"), Name = "Business Center Nearby" },
                        new { Id = new Guid("979b2a54-2d29-4bc9-98b1-8864814bf743"), Name = "Laundry Facility Nearby" },
                        new { Id = new Guid("9ce38c9c-3283-47af-b310-bfeefa33cc23"), Name = "Pool Nearby" },
                        new { Id = new Guid("7dbbf631-d1f5-449f-8a9c-800a72e85dde"), Name = "Park Nearby" },
                        new { Id = new Guid("561b5c9d-dc8f-415d-8342-deef92f7ddd5"), Name = "Senior Living" },
                        new { Id = new Guid("225d086d-b22c-4d59-91db-58adfff1619a"), Name = "Neighbourhood Type" }
                    );
                });

            modelBuilder.Entity("FishResident.Models.FeatureValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FeatureId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.ToTable("FeatureValues");
                });

            modelBuilder.Entity("FishResident.Models.Residence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<double>("Area");

                    b.Property<double>("Cost");

                    b.Property<string>("OwnerId")
                        .IsRequired();

                    b.Property<Guid?>("SearchRequestId");

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SearchRequestId");

                    b.HasIndex("TypeId");

                    b.ToTable("Residences");
                });

            modelBuilder.Entity("FishResident.Models.ResidencePhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<Guid>("ResidenceId");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceId");

                    b.ToTable("ResidencePhotos");
                });

            modelBuilder.Entity("FishResident.Models.ResidenceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ResidenceTypes");
                });

            modelBuilder.Entity("FishResident.Models.SearchRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SearchRequests");
                });

            modelBuilder.Entity("FishResident.Models.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("PaymentAmount");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<string>("SubscriberId")
                        .IsRequired();

                    b.Property<string>("TimePeriod");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SubscriberId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FishResident.Models.Agreement", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Owner")
                        .WithMany("AgreementsOwner")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.Residence", "Residence")
                        .WithMany("Agreements")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.ApplicationUser", "Resident")
                        .WithMany("AgreementsResident")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Feature", b =>
                {
                    b.HasOne("FishResident.Models.FeatureType", "FeatureType")
                        .WithMany()
                        .HasForeignKey("FeatureTypeId");

                    b.HasOne("FishResident.Models.Feature", "LinkedFeature")
                        .WithMany()
                        .HasForeignKey("LinkedFeatureId");
                });

            modelBuilder.Entity("FishResident.Models.FeatureAllowedValue", b =>
                {
                    b.HasOne("FishResident.Models.FeatureType", "FeatureType")
                        .WithMany("AllowedValues")
                        .HasForeignKey("FeatureTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.FeatureRequest", b =>
                {
                    b.HasOne("FishResident.Models.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.SearchRequest", "SearchRequest")
                        .WithMany("FeatureRequests")
                        .HasForeignKey("SearchRequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.FeatureValue", b =>
                {
                    b.HasOne("FishResident.Models.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Residence", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Owner")
                        .WithMany("Residences")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.SearchRequest")
                        .WithMany("Results")
                        .HasForeignKey("SearchRequestId");

                    b.HasOne("FishResident.Models.ResidenceType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.ResidencePhoto", b =>
                {
                    b.HasOne("FishResident.Models.Residence", "Residence")
                        .WithMany("ResidencePhotos")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.SearchRequest", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "User")
                        .WithMany("SearchRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Subscription", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Subscriber")
                        .WithMany("Subscriptions")
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
