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
    [Migration("20190625054628_AddFlagToAgreements")]
    partial class AddFlagToAgreements
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

                    b.Property<bool>("isDone");

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
                        new { Id = new Guid("8f4745b3-6cb0-4f9b-8d2b-2818478ffc9c"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "0" },
                        new { Id = new Guid("d8ffa767-785e-43d2-9489-4b7704f80618"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "1" },
                        new { Id = new Guid("2f0f5070-3fa7-43a5-a125-4de83b38ffdd"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "2" },
                        new { Id = new Guid("6c4a7f6c-1e8b-4efd-b475-a1b73cd5cf06"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "3" },
                        new { Id = new Guid("a7662408-ef1d-4f71-8109-24286762da03"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "4" },
                        new { Id = new Guid("65a615c1-686e-47d0-b442-1805f0adb9ed"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "5" },
                        new { Id = new Guid("51fb4842-58c1-45cb-ac64-a6876c8ac234"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "6" },
                        new { Id = new Guid("c9679ac9-d6c9-4899-ab36-81c90b687120"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "7" },
                        new { Id = new Guid("59bfe485-bf7d-4534-b399-2a12d35ad586"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "8" },
                        new { Id = new Guid("9f077a6b-eb53-4c04-96e6-491be4c5485a"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "9" },
                        new { Id = new Guid("6f79b940-dfdf-46d4-99fc-335e277e03b9"), FeatureTypeId = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Value = "10+" },
                        new { Id = new Guid("449856e3-494a-4c23-a9f5-5b8aa2e06a28"), FeatureTypeId = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Value = "0" },
                        new { Id = new Guid("0fcbdd76-04b2-44c8-a7bb-f538a6fe4906"), FeatureTypeId = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Value = "1" },
                        new { Id = new Guid("893165bf-9dd6-4491-b7ed-4be2e50752e6"), FeatureTypeId = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Value = "2" },
                        new { Id = new Guid("592a05b6-00a5-4108-9133-3bd90baad76b"), FeatureTypeId = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Value = "3" },
                        new { Id = new Guid("7c9941ab-56bf-4b60-bd32-6b49f517b3cb"), FeatureTypeId = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Value = "4" },
                        new { Id = new Guid("639fafcf-1425-43b6-825e-ca5296239cb4"), FeatureTypeId = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Value = "5+" },
                        new { Id = new Guid("90f2cf3d-06f8-4801-8bda-c44fa45eeda7"), FeatureTypeId = new Guid("f639dfb7-e50d-4af4-9499-fa903ce30c6f"), Value = "Small" },
                        new { Id = new Guid("2eedece1-a43b-4f73-9e1c-d15cb2864b6d"), FeatureTypeId = new Guid("f639dfb7-e50d-4af4-9499-fa903ce30c6f"), Value = "Medium" },
                        new { Id = new Guid("f1faec84-0560-49c1-8f6b-2f7207fd8e19"), FeatureTypeId = new Guid("f639dfb7-e50d-4af4-9499-fa903ce30c6f"), Value = "Large" },
                        new { Id = new Guid("300ffeb6-307d-4cfd-b2f6-c7395cc38648"), FeatureTypeId = new Guid("88b2e6b2-e630-499b-889d-8a6dbea9ce9e"), Value = "Yes" },
                        new { Id = new Guid("287c2d5b-7f0e-43f8-8046-4b290c219108"), FeatureTypeId = new Guid("88b2e6b2-e630-499b-889d-8a6dbea9ce9e"), Value = "No" },
                        new { Id = new Guid("ced4ec22-5944-4540-8508-0b2bb1ebe039"), FeatureTypeId = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Value = "0" },
                        new { Id = new Guid("83838c57-d8ad-431f-bb53-934c1e7fcc60"), FeatureTypeId = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Value = "1" },
                        new { Id = new Guid("ed9fdaf5-26bb-4f51-b097-9f4e791df706"), FeatureTypeId = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Value = "2" },
                        new { Id = new Guid("621cc62c-63d9-4fbc-b5b7-8f7203f25096"), FeatureTypeId = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Value = "3" },
                        new { Id = new Guid("379e3f38-250d-4f5b-a775-509e4901ece8"), FeatureTypeId = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Value = "4" },
                        new { Id = new Guid("10c5d085-bac2-43f4-8884-d1e6f8316c5e"), FeatureTypeId = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Value = "5+" },
                        new { Id = new Guid("6738dff7-9043-46eb-97b1-f77cb43234b3"), FeatureTypeId = new Guid("630f80fa-f9e9-4f00-b4d1-6e6fc8172e1d"), Value = "Yes" },
                        new { Id = new Guid("bd8b85ba-e685-46fc-8301-5adaa9b2c9ba"), FeatureTypeId = new Guid("630f80fa-f9e9-4f00-b4d1-6e6fc8172e1d"), Value = "No" },
                        new { Id = new Guid("82af8a21-3008-4424-96df-8d261eeb09ba"), FeatureTypeId = new Guid("640f4c2e-23bd-4ff4-acb8-9f764818b184"), Value = "Yes" },
                        new { Id = new Guid("3da94e7d-cb67-4cc9-ac09-398db3de727b"), FeatureTypeId = new Guid("640f4c2e-23bd-4ff4-acb8-9f764818b184"), Value = "No" },
                        new { Id = new Guid("31990f27-ea2c-4347-9e72-c60d1dd086ea"), FeatureTypeId = new Guid("04392a08-0ca9-45a8-a20e-aed635a3abdc"), Value = "Balcony" },
                        new { Id = new Guid("122944ca-411c-4253-860d-964d2a5934c3"), FeatureTypeId = new Guid("04392a08-0ca9-45a8-a20e-aed635a3abdc"), Value = "Patio" },
                        new { Id = new Guid("0c386e29-0b85-4049-8f68-24c67af73bb3"), FeatureTypeId = new Guid("04392a08-0ca9-45a8-a20e-aed635a3abdc"), Value = "Deck" },
                        new { Id = new Guid("116cd0c4-6bb3-4ad0-a798-1f3a32eb116e"), FeatureTypeId = new Guid("3f7e5b02-3a46-4a85-b157-d83c1a50831c"), Value = "Yes" },
                        new { Id = new Guid("9b4a5cde-dba8-47b2-b798-146b94dd923d"), FeatureTypeId = new Guid("3f7e5b02-3a46-4a85-b157-d83c1a50831c"), Value = "No" },
                        new { Id = new Guid("0233e7bf-0eb8-4f51-87d4-1627c67a8313"), FeatureTypeId = new Guid("cff8b637-d3e3-4b37-9303-760dd969d9d7"), Value = "Yes" },
                        new { Id = new Guid("54c93155-55f9-4e59-8d17-3db3965d1616"), FeatureTypeId = new Guid("cff8b637-d3e3-4b37-9303-760dd969d9d7"), Value = "No" },
                        new { Id = new Guid("fba72ba2-e845-40e6-aeff-a33fc0998ab4"), FeatureTypeId = new Guid("65586337-db7b-4f93-be3c-97d38314010a"), Value = "Yes" },
                        new { Id = new Guid("773b8121-e05a-411a-bb8e-4289893e53f7"), FeatureTypeId = new Guid("65586337-db7b-4f93-be3c-97d38314010a"), Value = "No" },
                        new { Id = new Guid("7769bfb2-9631-433d-a8c0-9d9b6765eb16"), FeatureTypeId = new Guid("02363677-7cf8-4e82-aec7-3ca2ae4e1a5b"), Value = "Yes" },
                        new { Id = new Guid("f79ab630-ca25-4b22-94e8-dc1715ffedb6"), FeatureTypeId = new Guid("02363677-7cf8-4e82-aec7-3ca2ae4e1a5b"), Value = "No" },
                        new { Id = new Guid("7fade266-c54e-4d1d-9d52-9a8b4443a784"), FeatureTypeId = new Guid("4b7ee930-4afc-43bf-9690-95e937f0bab2"), Value = "Yes" },
                        new { Id = new Guid("d11b6089-3880-4881-be3b-2ffcf0ccc243"), FeatureTypeId = new Guid("4b7ee930-4afc-43bf-9690-95e937f0bab2"), Value = "No" },
                        new { Id = new Guid("6f4d16cd-652c-44fc-9f69-1c3e2299aa52"), FeatureTypeId = new Guid("76c75787-42a3-4d86-8456-edf4348cae64"), Value = "Some" },
                        new { Id = new Guid("221b65c6-b84b-4e6e-8c1b-020f9501915f"), FeatureTypeId = new Guid("76c75787-42a3-4d86-8456-edf4348cae64"), Value = "All" },
                        new { Id = new Guid("95592d3f-34ae-431c-9afd-059bf1af28c1"), FeatureTypeId = new Guid("2f06559a-3b9d-4572-8f4c-3d6ac31f71dd"), Value = "Yes" },
                        new { Id = new Guid("9b5fafb4-80dc-470d-a748-92806869c8f0"), FeatureTypeId = new Guid("2f06559a-3b9d-4572-8f4c-3d6ac31f71dd"), Value = "No" },
                        new { Id = new Guid("e69fecef-3b3b-4c83-9ae9-d3aa6a8804ef"), FeatureTypeId = new Guid("41330d57-aca6-467a-b503-fc8c0b55d863"), Value = "Yes" },
                        new { Id = new Guid("f97c3b14-a6a7-4add-ad94-c8b1bdcc24b2"), FeatureTypeId = new Guid("41330d57-aca6-467a-b503-fc8c0b55d863"), Value = "No" },
                        new { Id = new Guid("8804e41a-5124-414c-8660-d90df33b4472"), FeatureTypeId = new Guid("e742c907-f658-4e91-955a-e82e7bc2c35a"), Value = "Yes" },
                        new { Id = new Guid("c093dc44-0731-4df7-9d3f-4ddb5b12e343"), FeatureTypeId = new Guid("e742c907-f658-4e91-955a-e82e7bc2c35a"), Value = "No" },
                        new { Id = new Guid("77812074-617d-4373-b0a1-e9ba2dcd98f2"), FeatureTypeId = new Guid("7f7101c0-9576-4c6e-bc5a-4eab5dbc2f34"), Value = "Yes" },
                        new { Id = new Guid("c1850af2-5e97-4788-a9b6-04024f232b66"), FeatureTypeId = new Guid("7f7101c0-9576-4c6e-bc5a-4eab5dbc2f34"), Value = "No" },
                        new { Id = new Guid("688ddf9d-071c-4846-a767-c0f35684066f"), FeatureTypeId = new Guid("93c49e7f-bc41-46bb-b1e1-c5f13d7d03b8"), Value = "Yes" },
                        new { Id = new Guid("06561e8a-1555-444b-8eae-67cf117ba16e"), FeatureTypeId = new Guid("93c49e7f-bc41-46bb-b1e1-c5f13d7d03b8"), Value = "No" },
                        new { Id = new Guid("65c28307-d8e8-4e13-b670-269dd562cbc9"), FeatureTypeId = new Guid("8650173e-46d5-4cf3-8832-893e0027c817"), Value = "Yes" },
                        new { Id = new Guid("1d800574-11d3-47be-8ab0-d706c462c87f"), FeatureTypeId = new Guid("8650173e-46d5-4cf3-8832-893e0027c817"), Value = "No" },
                        new { Id = new Guid("c3dde767-39f0-4877-9b18-28db8b11309a"), FeatureTypeId = new Guid("f734313d-1ac5-46d9-82b6-88f1abdfb1f0"), Value = "Yes" },
                        new { Id = new Guid("0c30c29b-5813-4bac-a097-dc1fd48e5056"), FeatureTypeId = new Guid("f734313d-1ac5-46d9-82b6-88f1abdfb1f0"), Value = "No" },
                        new { Id = new Guid("15f0a9af-d803-4727-972e-68138c51561d"), FeatureTypeId = new Guid("af53da90-1d43-4b96-95da-d44b6192b394"), Value = "Yes" },
                        new { Id = new Guid("9191e828-0a74-4b51-a9f7-85817f916792"), FeatureTypeId = new Guid("af53da90-1d43-4b96-95da-d44b6192b394"), Value = "No" },
                        new { Id = new Guid("8b45ec26-26b9-4648-87b0-3326a59d5453"), FeatureTypeId = new Guid("6c8e4843-6584-4aa9-b947-81df93a9c704"), Value = "Yes" },
                        new { Id = new Guid("121a3502-6a5f-4b6d-b584-fd1006158a4b"), FeatureTypeId = new Guid("6c8e4843-6584-4aa9-b947-81df93a9c704"), Value = "No" },
                        new { Id = new Guid("3107e7d1-bc70-44c3-88da-2d4880a98c4a"), FeatureTypeId = new Guid("e0d4cc55-9a24-4e37-8739-eb248ebd6b0c"), Value = "Yes" },
                        new { Id = new Guid("1fe0e12a-c722-4d8c-929e-72f6be0fb607"), FeatureTypeId = new Guid("e0d4cc55-9a24-4e37-8739-eb248ebd6b0c"), Value = "No" },
                        new { Id = new Guid("e47fd481-f561-481f-a425-4f300ecc6529"), FeatureTypeId = new Guid("6a2ffde1-c396-461a-b706-302765e03b38"), Value = "Yes" },
                        new { Id = new Guid("adf304de-68da-416b-adcf-fd4c46df2479"), FeatureTypeId = new Guid("6a2ffde1-c396-461a-b706-302765e03b38"), Value = "No" },
                        new { Id = new Guid("cb3c8766-8f01-4f58-9375-4849d6de79b3"), FeatureTypeId = new Guid("12c811c4-81a4-4c5c-9475-3bfce6cefcf2"), Value = "Yes" },
                        new { Id = new Guid("8a807266-678e-4837-909b-add9f9ee6fc5"), FeatureTypeId = new Guid("12c811c4-81a4-4c5c-9475-3bfce6cefcf2"), Value = "No" },
                        new { Id = new Guid("8e7345a1-7359-41f1-8025-714bbd11c92f"), FeatureTypeId = new Guid("cfb3055a-2c82-4142-b0dc-4102921f9af2"), Value = "Downtown" },
                        new { Id = new Guid("d3ef768f-4b80-4478-9015-7474a4ceb535"), FeatureTypeId = new Guid("cfb3055a-2c82-4142-b0dc-4102921f9af2"), Value = "Uptown" },
                        new { Id = new Guid("0817c400-0870-4615-925c-b87aa0da944e"), FeatureTypeId = new Guid("cfb3055a-2c82-4142-b0dc-4102921f9af2"), Value = "Rural" },
                        new { Id = new Guid("470a5c73-8982-4c2f-929c-138876ccad09"), FeatureTypeId = new Guid("cfb3055a-2c82-4142-b0dc-4102921f9af2"), Value = "Suburban" }
                    );
                });

            modelBuilder.Entity("FishResident.Models.FeatureRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FeatureTypeId");

                    b.Property<Guid>("SearchRequestId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureTypeId");

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
                        new { Id = new Guid("31a14926-0c48-40a1-bba3-e598662e6478"), Name = "Number of Bedrooms" },
                        new { Id = new Guid("e857dd0a-974e-451c-9381-b1fce41f737b"), Name = "Number of Bathrooms" },
                        new { Id = new Guid("f639dfb7-e50d-4af4-9499-fa903ce30c6f"), Name = "Kitchen size" },
                        new { Id = new Guid("88b2e6b2-e630-499b-889d-8a6dbea9ce9e"), Name = "Garage" },
                        new { Id = new Guid("7c3a1376-f14f-4f99-9791-f5e7f8f6ab22"), Name = "Number of Auto Spaces" },
                        new { Id = new Guid("630f80fa-f9e9-4f00-b4d1-6e6fc8172e1d"), Name = "Pets Allowed" },
                        new { Id = new Guid("640f4c2e-23bd-4ff4-acb8-9f764818b184"), Name = "Air Conditioning" },
                        new { Id = new Guid("04392a08-0ca9-45a8-a20e-aed635a3abdc"), Name = "Balcony Type" },
                        new { Id = new Guid("3f7e5b02-3a46-4a85-b157-d83c1a50831c"), Name = "Cable Ready" },
                        new { Id = new Guid("cff8b637-d3e3-4b37-9303-760dd969d9d7"), Name = "Dishwasher" },
                        new { Id = new Guid("65586337-db7b-4f93-be3c-97d38314010a"), Name = "Microwave Included" },
                        new { Id = new Guid("02363677-7cf8-4e82-aec7-3ca2ae4e1a5b"), Name = "Handicap Accessible" },
                        new { Id = new Guid("4b7ee930-4afc-43bf-9690-95e937f0bab2"), Name = "Hardwood Floors" },
                        new { Id = new Guid("76c75787-42a3-4d86-8456-edf4348cae64"), Name = "Utilities Covered" },
                        new { Id = new Guid("2f06559a-3b9d-4572-8f4c-3d6ac31f71dd"), Name = "Walk-In Closets" },
                        new { Id = new Guid("41330d57-aca6-467a-b503-fc8c0b55d863"), Name = "Washer/Dryer Included" },
                        new { Id = new Guid("e742c907-f658-4e91-955a-e82e7bc2c35a"), Name = "Security System" },
                        new { Id = new Guid("7f7101c0-9576-4c6e-bc5a-4eab5dbc2f34"), Name = "Limited/Controlled Access" },
                        new { Id = new Guid("93c49e7f-bc41-46bb-b1e1-c5f13d7d03b8"), Name = "Elevator" },
                        new { Id = new Guid("8650173e-46d5-4cf3-8832-893e0027c817"), Name = "Extra Storage" },
                        new { Id = new Guid("f734313d-1ac5-46d9-82b6-88f1abdfb1f0"), Name = "Fitness Center Nearby" },
                        new { Id = new Guid("af53da90-1d43-4b96-95da-d44b6192b394"), Name = "Business Center Nearby" },
                        new { Id = new Guid("6c8e4843-6584-4aa9-b947-81df93a9c704"), Name = "Laundry Facility Nearby" },
                        new { Id = new Guid("e0d4cc55-9a24-4e37-8739-eb248ebd6b0c"), Name = "Pool Nearby" },
                        new { Id = new Guid("6a2ffde1-c396-461a-b706-302765e03b38"), Name = "Park Nearby" },
                        new { Id = new Guid("12c811c4-81a4-4c5c-9475-3bfce6cefcf2"), Name = "Senior Living" },
                        new { Id = new Guid("cfb3055a-2c82-4142-b0dc-4102921f9af2"), Name = "Neighbourhood Type" }
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

            modelBuilder.Entity("FishResident.Models.RequestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Relevance");

                    b.Property<Guid>("ResidenceId");

                    b.Property<Guid>("SearchRequestId");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceId");

                    b.HasIndex("SearchRequestId");

                    b.ToTable("RequestResults");
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

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

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

                    b.Property<double>("Area");

                    b.Property<double>("Cost");

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
                    b.HasOne("FishResident.Models.FeatureType", "FeatureType")
                        .WithMany()
                        .HasForeignKey("FeatureTypeId")
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

            modelBuilder.Entity("FishResident.Models.RequestResult", b =>
                {
                    b.HasOne("FishResident.Models.Residence", "Residence")
                        .WithMany("Requests")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.SearchRequest", "SearchRequest")
                        .WithMany("Results")
                        .HasForeignKey("SearchRequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Residence", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Owner")
                        .WithMany("Residences")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

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
