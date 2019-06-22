﻿// <auto-generated />
using System;
using FishResident.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FishResident.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190606035143_AddResidencePhotosFix")]
    partial class AddResidencePhotosFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        new { Id = new Guid("9cb171bb-2f52-4846-bec4-8677c347784b"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "0" },
                        new { Id = new Guid("d07b175d-ad86-4c99-8ad6-d438261e2023"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "1" },
                        new { Id = new Guid("a22cd01f-bd8d-4bcf-b626-ea06a8d3b69b"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "2" },
                        new { Id = new Guid("70d2d50d-5edb-401a-9ad3-6bd6a0128493"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "3" },
                        new { Id = new Guid("0e45d46c-ea97-44d4-a5ff-3b162d981c80"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "4" },
                        new { Id = new Guid("c45c06cd-30e1-4d8c-9d13-cb7707e5a15b"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "5" },
                        new { Id = new Guid("af42eac9-e5e0-41fa-a71c-eae101aec652"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "6" },
                        new { Id = new Guid("39f7ab6d-652a-4009-b344-ee161dddb8c2"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "7" },
                        new { Id = new Guid("2d34b85d-f97e-4f82-afcc-25790cd7d267"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "8" },
                        new { Id = new Guid("d4d033d3-f1c0-42cf-b057-6446c0c009ba"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "9" },
                        new { Id = new Guid("69dc863a-8fa0-4cee-9e93-f31093f507d0"), FeatureTypeId = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Value = "10+" },
                        new { Id = new Guid("f4ebf20a-5ccb-4798-ac42-3d142fa70969"), FeatureTypeId = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Value = "0" },
                        new { Id = new Guid("64550146-64f0-4c63-89ca-b26807e64992"), FeatureTypeId = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Value = "1" },
                        new { Id = new Guid("aafcf534-d1c8-4606-b122-259ab2b421fa"), FeatureTypeId = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Value = "2" },
                        new { Id = new Guid("acae2537-9873-44b6-b212-f065a19b4c33"), FeatureTypeId = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Value = "3" },
                        new { Id = new Guid("f725d739-162f-4ff1-b019-673c03bca181"), FeatureTypeId = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Value = "4" },
                        new { Id = new Guid("ab6c67d2-29ef-4a61-801d-d40e5f32d836"), FeatureTypeId = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Value = "5+" },
                        new { Id = new Guid("a6db4a0d-c8e1-41fa-9fab-dbe0931e9a7a"), FeatureTypeId = new Guid("8f40fcf1-8e18-4e1d-bdd1-86b1ff8e89f3"), Value = "Small" },
                        new { Id = new Guid("ae76d3a0-a0ed-474b-9f19-46858e4729ac"), FeatureTypeId = new Guid("8f40fcf1-8e18-4e1d-bdd1-86b1ff8e89f3"), Value = "Medium" },
                        new { Id = new Guid("13c3083d-5b09-4b57-a9f5-8c7e899df921"), FeatureTypeId = new Guid("8f40fcf1-8e18-4e1d-bdd1-86b1ff8e89f3"), Value = "Large" },
                        new { Id = new Guid("c088b85e-6034-4da1-bf8f-e107e0b1a62c"), FeatureTypeId = new Guid("c76cd729-9ecd-43aa-9681-eb78e1d4ab50"), Value = "Yes" },
                        new { Id = new Guid("b57359ef-d82d-4ec3-bbd5-f0d0fea8d3e8"), FeatureTypeId = new Guid("c76cd729-9ecd-43aa-9681-eb78e1d4ab50"), Value = "No" },
                        new { Id = new Guid("a40057ee-04cd-4b98-be40-3510a0392693"), FeatureTypeId = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Value = "0" },
                        new { Id = new Guid("cf47a200-569f-4a79-bade-9c942285abe7"), FeatureTypeId = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Value = "1" },
                        new { Id = new Guid("caab76b4-7051-4674-aa87-8fbec7bb5df5"), FeatureTypeId = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Value = "2" },
                        new { Id = new Guid("cb3f112a-3e8c-40d5-bb36-bc68d2928b77"), FeatureTypeId = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Value = "3" },
                        new { Id = new Guid("56240649-f271-4924-ac1a-1d2d2ebb61a2"), FeatureTypeId = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Value = "4" },
                        new { Id = new Guid("4d46b36e-ee4f-4eb5-87d9-2dc0b33fe5b7"), FeatureTypeId = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Value = "5+" },
                        new { Id = new Guid("bdc7f3c8-b45b-4697-99f4-f2e4760def4a"), FeatureTypeId = new Guid("fcd07a98-fc76-453b-982a-90786713f55c"), Value = "Yes" },
                        new { Id = new Guid("be021d96-22e1-49b5-9c3a-0d5f028fb812"), FeatureTypeId = new Guid("fcd07a98-fc76-453b-982a-90786713f55c"), Value = "No" },
                        new { Id = new Guid("2cd39c0f-e35b-4c93-8ad7-d2e4710e3d42"), FeatureTypeId = new Guid("93b80edc-cab3-48c4-ac3a-11bf14f36f63"), Value = "Yes" },
                        new { Id = new Guid("142deb00-14c0-451a-85f8-f087f4e87ba0"), FeatureTypeId = new Guid("93b80edc-cab3-48c4-ac3a-11bf14f36f63"), Value = "No" },
                        new { Id = new Guid("98b38db6-9959-45ad-95a3-267fa8794071"), FeatureTypeId = new Guid("3e5ba382-12af-4533-b258-1dbf88f58f8c"), Value = "Balcony" },
                        new { Id = new Guid("04975ef9-d46c-44cc-976c-1d6858df481e"), FeatureTypeId = new Guid("3e5ba382-12af-4533-b258-1dbf88f58f8c"), Value = "Patio" },
                        new { Id = new Guid("272b138a-3dc8-447a-9ae3-151e5dcc266f"), FeatureTypeId = new Guid("3e5ba382-12af-4533-b258-1dbf88f58f8c"), Value = "Deck" },
                        new { Id = new Guid("3958af90-2a80-453f-adf1-c2731ffcbd1f"), FeatureTypeId = new Guid("3f6dd0df-c543-475f-89db-f043d097b1ac"), Value = "Yes" },
                        new { Id = new Guid("1994a65d-e8b8-45b2-9197-8c29880c1978"), FeatureTypeId = new Guid("3f6dd0df-c543-475f-89db-f043d097b1ac"), Value = "No" },
                        new { Id = new Guid("645efc4c-63ae-46fb-8023-008828530fc7"), FeatureTypeId = new Guid("2a1ccfad-044e-47d2-acc2-b27ec3302f60"), Value = "Yes" },
                        new { Id = new Guid("0f0aba50-f5bd-488b-a3be-3a64109f7eae"), FeatureTypeId = new Guid("2a1ccfad-044e-47d2-acc2-b27ec3302f60"), Value = "No" },
                        new { Id = new Guid("71e67543-4a0b-44a1-b2dc-b6274d324edf"), FeatureTypeId = new Guid("fc406b78-2c89-47c0-a19d-32c373366347"), Value = "Yes" },
                        new { Id = new Guid("75476038-642d-4569-a181-3b15f1dede86"), FeatureTypeId = new Guid("fc406b78-2c89-47c0-a19d-32c373366347"), Value = "No" },
                        new { Id = new Guid("4ef2fe26-8668-4b00-96d5-b57315f03a0b"), FeatureTypeId = new Guid("7e1f76ff-85d9-44d2-848c-ab1a19fa0ce3"), Value = "Yes" },
                        new { Id = new Guid("b9d22623-cafe-4e75-ac63-0a7ac1177479"), FeatureTypeId = new Guid("7e1f76ff-85d9-44d2-848c-ab1a19fa0ce3"), Value = "No" },
                        new { Id = new Guid("53397429-be40-4048-84b3-593363f52781"), FeatureTypeId = new Guid("b758dae7-75e5-421e-ae47-8a5e7044f335"), Value = "Yes" },
                        new { Id = new Guid("697143f2-01c1-4b08-bd53-b3f8d8abfec7"), FeatureTypeId = new Guid("b758dae7-75e5-421e-ae47-8a5e7044f335"), Value = "No" },
                        new { Id = new Guid("ddc81b92-865b-4941-8a67-a65ec8b73ba8"), FeatureTypeId = new Guid("37496acf-712c-4345-8bdc-138e1f0c0a12"), Value = "Some" },
                        new { Id = new Guid("fd15e2f4-5e00-4901-8c17-dfe37dd2a47b"), FeatureTypeId = new Guid("37496acf-712c-4345-8bdc-138e1f0c0a12"), Value = "All" },
                        new { Id = new Guid("d7bb0e4c-db38-4084-b4ea-c33d9c380228"), FeatureTypeId = new Guid("6883960f-6f66-4cc6-ac2d-ab98aca5e002"), Value = "Yes" },
                        new { Id = new Guid("4484ffb7-fb64-4810-ae0f-988b2f8221f6"), FeatureTypeId = new Guid("6883960f-6f66-4cc6-ac2d-ab98aca5e002"), Value = "No" },
                        new { Id = new Guid("c8395b78-bdae-4f78-82ae-e27d9c6e09e8"), FeatureTypeId = new Guid("6f8cdd7f-f2c6-4c0c-8cbc-9e721921d434"), Value = "Yes" },
                        new { Id = new Guid("2b5ac6d2-385a-4e11-bb10-1ebf94572f40"), FeatureTypeId = new Guid("6f8cdd7f-f2c6-4c0c-8cbc-9e721921d434"), Value = "No" },
                        new { Id = new Guid("ac8a7155-7ebb-4503-9a47-199be451e168"), FeatureTypeId = new Guid("6b57c264-c406-4cf9-8ddb-dfa62cc6a3b1"), Value = "Yes" },
                        new { Id = new Guid("04b8a68f-f443-47b0-9364-9efa98b6863c"), FeatureTypeId = new Guid("6b57c264-c406-4cf9-8ddb-dfa62cc6a3b1"), Value = "No" },
                        new { Id = new Guid("4e068b94-02ff-483c-9859-b858149c3a3f"), FeatureTypeId = new Guid("5e6668e2-18ed-424e-89af-e8920c46cba0"), Value = "Yes" },
                        new { Id = new Guid("53a77905-6396-4002-952d-d835660a253a"), FeatureTypeId = new Guid("5e6668e2-18ed-424e-89af-e8920c46cba0"), Value = "No" },
                        new { Id = new Guid("d0df6e24-8256-466e-921a-a74f09da17a6"), FeatureTypeId = new Guid("ececf17f-0412-4a0a-9d25-ef3d9b7bfcd4"), Value = "Yes" },
                        new { Id = new Guid("df47b2de-8c1e-426d-9385-e2e08327f1da"), FeatureTypeId = new Guid("ececf17f-0412-4a0a-9d25-ef3d9b7bfcd4"), Value = "No" },
                        new { Id = new Guid("406f0a76-7f95-4588-958a-0457922df56e"), FeatureTypeId = new Guid("4ca34ab2-af07-4679-8dfe-fa9f5873ec00"), Value = "Yes" },
                        new { Id = new Guid("5ad87c30-743d-4f54-ba51-2f4853e32067"), FeatureTypeId = new Guid("4ca34ab2-af07-4679-8dfe-fa9f5873ec00"), Value = "No" },
                        new { Id = new Guid("ba2fb4c6-48a6-40a5-bf69-0d4cd65ce454"), FeatureTypeId = new Guid("857b0953-390d-4b69-a641-8be759553201"), Value = "Yes" },
                        new { Id = new Guid("7e7779e2-4cdc-46b9-947d-729e1d78baf4"), FeatureTypeId = new Guid("857b0953-390d-4b69-a641-8be759553201"), Value = "No" },
                        new { Id = new Guid("a459a9cb-5297-437a-9a98-a1010e6887aa"), FeatureTypeId = new Guid("9dd78077-b5d7-4202-8658-a7e3fc8613a2"), Value = "Yes" },
                        new { Id = new Guid("905f7b51-2617-4427-9705-b74486a0dec8"), FeatureTypeId = new Guid("9dd78077-b5d7-4202-8658-a7e3fc8613a2"), Value = "No" },
                        new { Id = new Guid("1aa132db-d113-44e1-b835-404740eb5c43"), FeatureTypeId = new Guid("9d676d36-1d06-459d-9ec2-d2ef6f4ee307"), Value = "Yes" },
                        new { Id = new Guid("fb0a3142-0b6c-4e63-92ef-1767ada9e5b6"), FeatureTypeId = new Guid("9d676d36-1d06-459d-9ec2-d2ef6f4ee307"), Value = "No" },
                        new { Id = new Guid("ed46a557-2c28-4309-949f-fb3a22fcd21c"), FeatureTypeId = new Guid("339b5787-8f92-4c4e-a674-f6f111724324"), Value = "Yes" },
                        new { Id = new Guid("02aa8acd-ef13-42ad-a386-ad23cc729ca9"), FeatureTypeId = new Guid("339b5787-8f92-4c4e-a674-f6f111724324"), Value = "No" },
                        new { Id = new Guid("9d668ccc-c0ed-4152-a7f5-69583424036f"), FeatureTypeId = new Guid("816febba-1b9e-401e-8220-396d0081925a"), Value = "Yes" },
                        new { Id = new Guid("3ad9c95f-762d-494f-9c44-e2cd7c2351d5"), FeatureTypeId = new Guid("816febba-1b9e-401e-8220-396d0081925a"), Value = "No" },
                        new { Id = new Guid("ad526eff-bfe4-4d9c-a6f3-9051f95ea73c"), FeatureTypeId = new Guid("6d66b46d-437d-4a41-97d9-545162bda71e"), Value = "Yes" },
                        new { Id = new Guid("de8c35e9-e062-4bd7-9dba-b19042073992"), FeatureTypeId = new Guid("6d66b46d-437d-4a41-97d9-545162bda71e"), Value = "No" },
                        new { Id = new Guid("ca770859-3e2a-47d7-bb2e-3f11e40b04f1"), FeatureTypeId = new Guid("953852e1-df45-4887-8c82-58f3b205f37f"), Value = "Downtown" },
                        new { Id = new Guid("5858cd48-f098-4e0c-95ed-f55d13876c8f"), FeatureTypeId = new Guid("953852e1-df45-4887-8c82-58f3b205f37f"), Value = "Uptown" },
                        new { Id = new Guid("418565a1-98f3-4d34-a3b9-8781dac12f82"), FeatureTypeId = new Guid("953852e1-df45-4887-8c82-58f3b205f37f"), Value = "Rural" },
                        new { Id = new Guid("610cd483-c9c8-4a3d-9da7-e7e4d20471a2"), FeatureTypeId = new Guid("953852e1-df45-4887-8c82-58f3b205f37f"), Value = "Suburban" }
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
                        new { Id = new Guid("de458d65-95b5-40ed-a4ef-6846e916dd41"), Name = "Number of Bedrooms" },
                        new { Id = new Guid("c6075814-2ba3-4267-aff8-667958196509"), Name = "Number of Bathrooms" },
                        new { Id = new Guid("8f40fcf1-8e18-4e1d-bdd1-86b1ff8e89f3"), Name = "Kitchen size" },
                        new { Id = new Guid("c76cd729-9ecd-43aa-9681-eb78e1d4ab50"), Name = "Garage" },
                        new { Id = new Guid("4c8ce4b0-924c-41ba-b983-370d517ed5b8"), Name = "Number of Auto Spaces" },
                        new { Id = new Guid("fcd07a98-fc76-453b-982a-90786713f55c"), Name = "Pets Allowed" },
                        new { Id = new Guid("93b80edc-cab3-48c4-ac3a-11bf14f36f63"), Name = "Air Conditioning" },
                        new { Id = new Guid("3e5ba382-12af-4533-b258-1dbf88f58f8c"), Name = "Balcony Type" },
                        new { Id = new Guid("3f6dd0df-c543-475f-89db-f043d097b1ac"), Name = "Cable Ready" },
                        new { Id = new Guid("2a1ccfad-044e-47d2-acc2-b27ec3302f60"), Name = "Dishwasher" },
                        new { Id = new Guid("fc406b78-2c89-47c0-a19d-32c373366347"), Name = "Microwave Included" },
                        new { Id = new Guid("7e1f76ff-85d9-44d2-848c-ab1a19fa0ce3"), Name = "Handicap Accessible" },
                        new { Id = new Guid("b758dae7-75e5-421e-ae47-8a5e7044f335"), Name = "Hardwood Floors" },
                        new { Id = new Guid("37496acf-712c-4345-8bdc-138e1f0c0a12"), Name = "Utilities Covered" },
                        new { Id = new Guid("6883960f-6f66-4cc6-ac2d-ab98aca5e002"), Name = "Walk-In Closets" },
                        new { Id = new Guid("6f8cdd7f-f2c6-4c0c-8cbc-9e721921d434"), Name = "Washer/Dryer Included" },
                        new { Id = new Guid("6b57c264-c406-4cf9-8ddb-dfa62cc6a3b1"), Name = "Security System" },
                        new { Id = new Guid("5e6668e2-18ed-424e-89af-e8920c46cba0"), Name = "Limited/Controlled Access" },
                        new { Id = new Guid("ececf17f-0412-4a0a-9d25-ef3d9b7bfcd4"), Name = "Elevator" },
                        new { Id = new Guid("4ca34ab2-af07-4679-8dfe-fa9f5873ec00"), Name = "Extra Storage" },
                        new { Id = new Guid("857b0953-390d-4b69-a641-8be759553201"), Name = "Fitness Center Nearby" },
                        new { Id = new Guid("9dd78077-b5d7-4202-8658-a7e3fc8613a2"), Name = "Business Center Nearby" },
                        new { Id = new Guid("9d676d36-1d06-459d-9ec2-d2ef6f4ee307"), Name = "Laundry Facility Nearby" },
                        new { Id = new Guid("339b5787-8f92-4c4e-a674-f6f111724324"), Name = "Pool Nearby" },
                        new { Id = new Guid("816febba-1b9e-401e-8220-396d0081925a"), Name = "Park Nearby" },
                        new { Id = new Guid("6d66b46d-437d-4a41-97d9-545162bda71e"), Name = "Senior Living" },
                        new { Id = new Guid("953852e1-df45-4887-8c82-58f3b205f37f"), Name = "Neighbourhood Type" }
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