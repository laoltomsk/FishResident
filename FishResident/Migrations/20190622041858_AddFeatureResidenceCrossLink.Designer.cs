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
    [Migration("20190622041858_AddFeatureResidenceCrossLink")]
    partial class AddFeatureResidenceCrossLink
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
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

                    b.Property<Guid?>("ResidenceId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureTypeId");

                    b.HasIndex("LinkedFeatureId");

                    b.HasIndex("ResidenceId");

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
                        new { Id = new Guid("72a0a7e7-1aa7-4beb-a26b-e3f3c2ff709a"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "0" },
                        new { Id = new Guid("7979c7a8-9507-4a53-874f-5b0b7eea9e41"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "1" },
                        new { Id = new Guid("3d652af7-a024-473d-b3f8-70745c162a80"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "2" },
                        new { Id = new Guid("3cedd797-1b92-48fd-ab5d-9574a21acd49"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "3" },
                        new { Id = new Guid("aae69cdd-57f6-413a-a065-4c5ccd63a102"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "4" },
                        new { Id = new Guid("c6dba12c-6d41-40e5-bdd9-59fb16907ccc"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "5" },
                        new { Id = new Guid("aa2b5fa9-5a3f-4930-b110-46f3a22686f4"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "6" },
                        new { Id = new Guid("f3ccde84-315d-4d5a-b7d4-8d62a8d42815"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "7" },
                        new { Id = new Guid("9538c1c0-4e4c-453c-97ae-d6072bbb5f93"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "8" },
                        new { Id = new Guid("36993148-8e66-4101-8cb9-b146f6cc6b84"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "9" },
                        new { Id = new Guid("4c1694e9-ce32-43c5-aca0-ad359dca4316"), FeatureTypeId = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Value = "10+" },
                        new { Id = new Guid("2ad5d191-4641-46ff-bb95-0f0b8fce05bf"), FeatureTypeId = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Value = "0" },
                        new { Id = new Guid("0b943590-47a8-4e85-83f7-ffb21a82fcd1"), FeatureTypeId = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Value = "1" },
                        new { Id = new Guid("29575c8d-1c42-4ed5-b346-39c107005f19"), FeatureTypeId = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Value = "2" },
                        new { Id = new Guid("cdcc2d12-f88b-449f-9a2d-b1ada25231a4"), FeatureTypeId = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Value = "3" },
                        new { Id = new Guid("be6f725a-108d-4539-a5fa-4e09c5b60258"), FeatureTypeId = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Value = "4" },
                        new { Id = new Guid("0f425c1b-2fb3-4560-be12-6ac74effe085"), FeatureTypeId = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Value = "5+" },
                        new { Id = new Guid("f2ddb95c-a092-4763-ad37-e3cbd629dc99"), FeatureTypeId = new Guid("32d46f35-264c-4f1d-9755-58fe47f996ce"), Value = "Small" },
                        new { Id = new Guid("f59a6531-9614-4099-8f95-26deb4005df8"), FeatureTypeId = new Guid("32d46f35-264c-4f1d-9755-58fe47f996ce"), Value = "Medium" },
                        new { Id = new Guid("ff7b0d03-068f-454e-b2ed-121f073b40ff"), FeatureTypeId = new Guid("32d46f35-264c-4f1d-9755-58fe47f996ce"), Value = "Large" },
                        new { Id = new Guid("9c5d3ecf-9972-4fdb-a409-96a0ee056053"), FeatureTypeId = new Guid("1f0f7f57-9ca7-46db-9f96-9803a67bddf9"), Value = "Yes" },
                        new { Id = new Guid("d54bab22-d4b6-4354-958f-3c932ebe7ae7"), FeatureTypeId = new Guid("1f0f7f57-9ca7-46db-9f96-9803a67bddf9"), Value = "No" },
                        new { Id = new Guid("81f92f2e-75d3-485f-900a-c745f60c8dab"), FeatureTypeId = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Value = "0" },
                        new { Id = new Guid("44cf4611-4927-4f7d-821e-cc4ced783f25"), FeatureTypeId = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Value = "1" },
                        new { Id = new Guid("38f64d90-3dc1-4e3d-8337-5b408959523a"), FeatureTypeId = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Value = "2" },
                        new { Id = new Guid("226c7895-0b0a-4c3a-9018-6b1147e592d6"), FeatureTypeId = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Value = "3" },
                        new { Id = new Guid("39b73610-f765-466d-9d4a-5bb09117ef19"), FeatureTypeId = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Value = "4" },
                        new { Id = new Guid("633d9d32-8b08-48fe-8e86-ebfc7bbe2043"), FeatureTypeId = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Value = "5+" },
                        new { Id = new Guid("17c087ba-fda6-4864-8e75-2aa76822ad19"), FeatureTypeId = new Guid("32c68e50-b7c4-480b-b99d-5a1029013008"), Value = "Yes" },
                        new { Id = new Guid("bc89da33-c742-488d-96f5-55fdcecdcde0"), FeatureTypeId = new Guid("32c68e50-b7c4-480b-b99d-5a1029013008"), Value = "No" },
                        new { Id = new Guid("389ba9b3-b250-4328-a893-94fbe2641617"), FeatureTypeId = new Guid("241b1aea-a621-4b7f-97dc-4a919e766cc1"), Value = "Yes" },
                        new { Id = new Guid("4eec8bff-c956-4751-938c-3536baac34c0"), FeatureTypeId = new Guid("241b1aea-a621-4b7f-97dc-4a919e766cc1"), Value = "No" },
                        new { Id = new Guid("ebf81f63-eb17-4054-91d2-46c41f63ef97"), FeatureTypeId = new Guid("e673c6ef-205d-4a64-bbfa-2cfb031a058b"), Value = "Balcony" },
                        new { Id = new Guid("d6618a99-88ff-49a7-b0c1-5dca60b5c431"), FeatureTypeId = new Guid("e673c6ef-205d-4a64-bbfa-2cfb031a058b"), Value = "Patio" },
                        new { Id = new Guid("76dae61f-f407-4b0c-8c9f-98b4c06f17e2"), FeatureTypeId = new Guid("e673c6ef-205d-4a64-bbfa-2cfb031a058b"), Value = "Deck" },
                        new { Id = new Guid("9a9da049-e0ff-4fb2-8893-4e0d727b7579"), FeatureTypeId = new Guid("42c557ff-6e22-4642-a304-d86730c0e11d"), Value = "Yes" },
                        new { Id = new Guid("4c02cc1d-2f86-44e1-a487-9dea5201771e"), FeatureTypeId = new Guid("42c557ff-6e22-4642-a304-d86730c0e11d"), Value = "No" },
                        new { Id = new Guid("af2fee2f-b6a2-4c97-acad-12280e53ec36"), FeatureTypeId = new Guid("0542d629-c468-4004-b9a0-745230d56cc2"), Value = "Yes" },
                        new { Id = new Guid("ea8e84cd-8e0e-4d20-aa24-817496738ae2"), FeatureTypeId = new Guid("0542d629-c468-4004-b9a0-745230d56cc2"), Value = "No" },
                        new { Id = new Guid("e9671702-f554-4b22-af0c-b4e1885055c1"), FeatureTypeId = new Guid("8980b976-30b2-4a69-a617-25715eb4e1e3"), Value = "Yes" },
                        new { Id = new Guid("3ce87301-b852-4276-b26f-5fcde279c5e5"), FeatureTypeId = new Guid("8980b976-30b2-4a69-a617-25715eb4e1e3"), Value = "No" },
                        new { Id = new Guid("68a3d7e4-1591-45f7-bde6-b457d7ba53fd"), FeatureTypeId = new Guid("d760b0b6-0c87-45f9-b18d-6814da8ab9c7"), Value = "Yes" },
                        new { Id = new Guid("65f6930b-c2f3-4ef9-bba6-2c638ad2b85a"), FeatureTypeId = new Guid("d760b0b6-0c87-45f9-b18d-6814da8ab9c7"), Value = "No" },
                        new { Id = new Guid("8caa2dd0-67ca-44a0-93a0-66d15cde01de"), FeatureTypeId = new Guid("6d727930-7c19-4f50-9a05-d05262520702"), Value = "Yes" },
                        new { Id = new Guid("61c00035-bd9d-4345-84a5-07fa7ff5a446"), FeatureTypeId = new Guid("6d727930-7c19-4f50-9a05-d05262520702"), Value = "No" },
                        new { Id = new Guid("039a58a8-fd7e-4fb0-a97a-acef06d56265"), FeatureTypeId = new Guid("78fb7d33-70ea-41bb-80ee-c0255a775b5d"), Value = "Some" },
                        new { Id = new Guid("25959c31-c5b0-4747-85aa-b201fb3f7232"), FeatureTypeId = new Guid("78fb7d33-70ea-41bb-80ee-c0255a775b5d"), Value = "All" },
                        new { Id = new Guid("d4470725-845d-4ef8-843e-c42735792a22"), FeatureTypeId = new Guid("8c9c7054-dcce-48eb-bc7a-059ae22745c4"), Value = "Yes" },
                        new { Id = new Guid("b6979220-ee3a-4993-9f08-27a03d8ed394"), FeatureTypeId = new Guid("8c9c7054-dcce-48eb-bc7a-059ae22745c4"), Value = "No" },
                        new { Id = new Guid("62aa4ab2-1bbf-4c09-8853-4693389106fd"), FeatureTypeId = new Guid("9fa46264-7fae-4744-8ea7-ad04669394d5"), Value = "Yes" },
                        new { Id = new Guid("7b6cac69-de30-472c-adbb-4befa7415293"), FeatureTypeId = new Guid("9fa46264-7fae-4744-8ea7-ad04669394d5"), Value = "No" },
                        new { Id = new Guid("e868a9d1-8f90-49db-bb96-21da1f26dd98"), FeatureTypeId = new Guid("70b5ecfd-12f6-4e60-9886-1b49b1778c81"), Value = "Yes" },
                        new { Id = new Guid("41b01eea-b746-42f0-9e49-e82de4765627"), FeatureTypeId = new Guid("70b5ecfd-12f6-4e60-9886-1b49b1778c81"), Value = "No" },
                        new { Id = new Guid("f484637b-cf63-4d82-9fb0-c42ac81ee4de"), FeatureTypeId = new Guid("bafb0cf0-4ebf-4010-8ef9-2ec02c2521f9"), Value = "Yes" },
                        new { Id = new Guid("3ac34789-808a-4d8b-b32a-3695c2ae22c3"), FeatureTypeId = new Guid("bafb0cf0-4ebf-4010-8ef9-2ec02c2521f9"), Value = "No" },
                        new { Id = new Guid("41320d03-b71f-41be-9cbf-8c4ac2151236"), FeatureTypeId = new Guid("f6a60487-f6ab-4b34-a404-8f7bf125e706"), Value = "Yes" },
                        new { Id = new Guid("5c975808-4d0c-40aa-9260-cd9852c13b24"), FeatureTypeId = new Guid("f6a60487-f6ab-4b34-a404-8f7bf125e706"), Value = "No" },
                        new { Id = new Guid("efc9ecd9-a5ea-4cb3-ac3a-9f432313676b"), FeatureTypeId = new Guid("bee7dd8f-b983-452f-ac5f-f689ee05bc30"), Value = "Yes" },
                        new { Id = new Guid("72ac467e-e597-47d0-abdd-0d62060ddb8d"), FeatureTypeId = new Guid("bee7dd8f-b983-452f-ac5f-f689ee05bc30"), Value = "No" },
                        new { Id = new Guid("a64b03c6-ac3d-41b4-a516-5a75024f7cfb"), FeatureTypeId = new Guid("77747d88-c262-45b3-8bc4-d90b386b3d1f"), Value = "Yes" },
                        new { Id = new Guid("206bc52f-55cd-4fb5-9a3d-cdb3d0f0dd7e"), FeatureTypeId = new Guid("77747d88-c262-45b3-8bc4-d90b386b3d1f"), Value = "No" },
                        new { Id = new Guid("00c4b370-cda4-4198-80e3-91e01c57c9e2"), FeatureTypeId = new Guid("a22b07df-9f9c-49a3-8613-e1de40a3c373"), Value = "Yes" },
                        new { Id = new Guid("3bfcd22f-537c-47ff-a451-bd5e8fb3f334"), FeatureTypeId = new Guid("a22b07df-9f9c-49a3-8613-e1de40a3c373"), Value = "No" },
                        new { Id = new Guid("2b5d3806-cbc6-4c17-8127-579cfcc631e0"), FeatureTypeId = new Guid("014e228d-9dfc-4b4a-87d4-5eb17633619c"), Value = "Yes" },
                        new { Id = new Guid("dd315fc6-a3a6-4db1-af6f-8f18cd9e3cac"), FeatureTypeId = new Guid("014e228d-9dfc-4b4a-87d4-5eb17633619c"), Value = "No" },
                        new { Id = new Guid("da2cab05-869b-417c-87bf-a1dd18a02e8c"), FeatureTypeId = new Guid("73b25aaf-245c-4218-9b78-1a4ae880e1c1"), Value = "Yes" },
                        new { Id = new Guid("4d71be58-1c8c-43cf-b33b-72dbe24abbc3"), FeatureTypeId = new Guid("73b25aaf-245c-4218-9b78-1a4ae880e1c1"), Value = "No" },
                        new { Id = new Guid("1d5db23d-f986-4f4e-a67c-8d38fd68768b"), FeatureTypeId = new Guid("32d90637-6e5e-40ce-8645-349446416dc4"), Value = "Yes" },
                        new { Id = new Guid("e29e30d7-c3b1-4af0-b020-441f39496f36"), FeatureTypeId = new Guid("32d90637-6e5e-40ce-8645-349446416dc4"), Value = "No" },
                        new { Id = new Guid("60d137fb-d794-441f-9b3d-09dfd181bc49"), FeatureTypeId = new Guid("ba23f734-ace2-4afc-8acb-d13302e9f977"), Value = "Yes" },
                        new { Id = new Guid("c919cd6c-8b0f-422e-be9f-2be3514e6bb7"), FeatureTypeId = new Guid("ba23f734-ace2-4afc-8acb-d13302e9f977"), Value = "No" },
                        new { Id = new Guid("3d929364-bd7c-47c9-a44e-c6d49e5e6efd"), FeatureTypeId = new Guid("a19f89ff-e115-432b-8f8e-86992b278bf1"), Value = "Downtown" },
                        new { Id = new Guid("570b1c12-c5ae-41ba-926d-afd1045a59e0"), FeatureTypeId = new Guid("a19f89ff-e115-432b-8f8e-86992b278bf1"), Value = "Uptown" },
                        new { Id = new Guid("6533fe30-16d1-47ae-af48-46c52db21cd6"), FeatureTypeId = new Guid("a19f89ff-e115-432b-8f8e-86992b278bf1"), Value = "Rural" },
                        new { Id = new Guid("ecb6906e-a6d5-492e-b4c6-af930bcaa371"), FeatureTypeId = new Guid("a19f89ff-e115-432b-8f8e-86992b278bf1"), Value = "Suburban" }
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
                        new { Id = new Guid("57da0413-a037-44e9-8272-4224f051a5c5"), Name = "Number of Bedrooms" },
                        new { Id = new Guid("41efd607-b905-4e75-a96c-c5a0721e9f64"), Name = "Number of Bathrooms" },
                        new { Id = new Guid("32d46f35-264c-4f1d-9755-58fe47f996ce"), Name = "Kitchen size" },
                        new { Id = new Guid("1f0f7f57-9ca7-46db-9f96-9803a67bddf9"), Name = "Garage" },
                        new { Id = new Guid("33316ebf-7b34-49d8-91db-0a37948123cc"), Name = "Number of Auto Spaces" },
                        new { Id = new Guid("32c68e50-b7c4-480b-b99d-5a1029013008"), Name = "Pets Allowed" },
                        new { Id = new Guid("241b1aea-a621-4b7f-97dc-4a919e766cc1"), Name = "Air Conditioning" },
                        new { Id = new Guid("e673c6ef-205d-4a64-bbfa-2cfb031a058b"), Name = "Balcony Type" },
                        new { Id = new Guid("42c557ff-6e22-4642-a304-d86730c0e11d"), Name = "Cable Ready" },
                        new { Id = new Guid("0542d629-c468-4004-b9a0-745230d56cc2"), Name = "Dishwasher" },
                        new { Id = new Guid("8980b976-30b2-4a69-a617-25715eb4e1e3"), Name = "Microwave Included" },
                        new { Id = new Guid("d760b0b6-0c87-45f9-b18d-6814da8ab9c7"), Name = "Handicap Accessible" },
                        new { Id = new Guid("6d727930-7c19-4f50-9a05-d05262520702"), Name = "Hardwood Floors" },
                        new { Id = new Guid("78fb7d33-70ea-41bb-80ee-c0255a775b5d"), Name = "Utilities Covered" },
                        new { Id = new Guid("8c9c7054-dcce-48eb-bc7a-059ae22745c4"), Name = "Walk-In Closets" },
                        new { Id = new Guid("9fa46264-7fae-4744-8ea7-ad04669394d5"), Name = "Washer/Dryer Included" },
                        new { Id = new Guid("70b5ecfd-12f6-4e60-9886-1b49b1778c81"), Name = "Security System" },
                        new { Id = new Guid("bafb0cf0-4ebf-4010-8ef9-2ec02c2521f9"), Name = "Limited/Controlled Access" },
                        new { Id = new Guid("f6a60487-f6ab-4b34-a404-8f7bf125e706"), Name = "Elevator" },
                        new { Id = new Guid("bee7dd8f-b983-452f-ac5f-f689ee05bc30"), Name = "Extra Storage" },
                        new { Id = new Guid("77747d88-c262-45b3-8bc4-d90b386b3d1f"), Name = "Fitness Center Nearby" },
                        new { Id = new Guid("a22b07df-9f9c-49a3-8613-e1de40a3c373"), Name = "Business Center Nearby" },
                        new { Id = new Guid("014e228d-9dfc-4b4a-87d4-5eb17633619c"), Name = "Laundry Facility Nearby" },
                        new { Id = new Guid("73b25aaf-245c-4218-9b78-1a4ae880e1c1"), Name = "Pool Nearby" },
                        new { Id = new Guid("32d90637-6e5e-40ce-8645-349446416dc4"), Name = "Park Nearby" },
                        new { Id = new Guid("ba23f734-ace2-4afc-8acb-d13302e9f977"), Name = "Senior Living" },
                        new { Id = new Guid("a19f89ff-e115-432b-8f8e-86992b278bf1"), Name = "Neighbourhood Type" }
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

                    b.HasOne("FishResident.Models.Residence", "Residence")
                        .WithMany("Features")
                        .HasForeignKey("ResidenceId");
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
