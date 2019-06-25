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
    [Migration("20190623061954_AddRequestResults")]
    partial class AddRequestResults
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
                        new { Id = new Guid("69027762-15a0-4224-978c-bd9b4e5f16f7"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "0" },
                        new { Id = new Guid("cd9ee2a7-1c0b-4a37-a63f-011e343a3c2c"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "1" },
                        new { Id = new Guid("ac73475e-d275-463d-a6bb-864add9af822"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "2" },
                        new { Id = new Guid("a455297d-4719-46ef-b684-184afbc90d9c"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "3" },
                        new { Id = new Guid("8cea7d25-1003-4dc0-a289-2dd218008310"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "4" },
                        new { Id = new Guid("2c80b923-5931-4b8c-a078-8ea6304f069a"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "5" },
                        new { Id = new Guid("e12b9f80-b966-4a08-9982-3c9b167de534"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "6" },
                        new { Id = new Guid("dbaa8446-632a-497c-9d61-be6c1eaca8fe"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "7" },
                        new { Id = new Guid("818ad5ca-fbbd-454b-a1b1-919ca8a679fe"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "8" },
                        new { Id = new Guid("1310616d-e905-4f76-839e-9321ec434cf4"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "9" },
                        new { Id = new Guid("32bffa5d-cb29-4638-a754-666242cbdd46"), FeatureTypeId = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Value = "10+" },
                        new { Id = new Guid("06b83a7d-33ab-4a1f-9655-16caf612ce85"), FeatureTypeId = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Value = "0" },
                        new { Id = new Guid("ded04967-70d9-40c8-b782-8ff0655f2ced"), FeatureTypeId = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Value = "1" },
                        new { Id = new Guid("f318d83c-59dc-4eb7-8795-7de7221b86b3"), FeatureTypeId = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Value = "2" },
                        new { Id = new Guid("16af991d-201b-46be-a258-0f2e3b749c53"), FeatureTypeId = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Value = "3" },
                        new { Id = new Guid("e02cb97c-8097-487c-b3a2-426d1ef8646d"), FeatureTypeId = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Value = "4" },
                        new { Id = new Guid("e19b9e47-bd8b-43bc-b3f5-823e032ab1d1"), FeatureTypeId = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Value = "5+" },
                        new { Id = new Guid("3d509cb4-1dfc-407f-9165-d8af3b15282d"), FeatureTypeId = new Guid("eff84e30-fc8b-4881-a9ec-e42504c744a7"), Value = "Small" },
                        new { Id = new Guid("e3c692db-f1c1-4aa1-8468-8bf51650fdb9"), FeatureTypeId = new Guid("eff84e30-fc8b-4881-a9ec-e42504c744a7"), Value = "Medium" },
                        new { Id = new Guid("449f2177-7cad-4c8d-a43f-df2cb1bfbead"), FeatureTypeId = new Guid("eff84e30-fc8b-4881-a9ec-e42504c744a7"), Value = "Large" },
                        new { Id = new Guid("8b0d04df-54ef-4936-ab8b-e63069b1d31a"), FeatureTypeId = new Guid("1a0677e7-312f-4686-acd2-e6fd17a1871c"), Value = "Yes" },
                        new { Id = new Guid("9c628953-843d-481c-a123-166f991549c4"), FeatureTypeId = new Guid("1a0677e7-312f-4686-acd2-e6fd17a1871c"), Value = "No" },
                        new { Id = new Guid("dc99ebe2-c7a7-448e-9850-68821c1728b6"), FeatureTypeId = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Value = "0" },
                        new { Id = new Guid("cc9558a0-c14d-4eb6-8aef-07d0234911fd"), FeatureTypeId = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Value = "1" },
                        new { Id = new Guid("4798193a-a401-4c49-8c0b-ae0c2fa67717"), FeatureTypeId = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Value = "2" },
                        new { Id = new Guid("c43dd7d4-0fc6-4bab-81dd-99d5b914faa8"), FeatureTypeId = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Value = "3" },
                        new { Id = new Guid("42f6bef9-b340-4f14-9edb-69dcfd22dec7"), FeatureTypeId = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Value = "4" },
                        new { Id = new Guid("22bca6eb-c969-40d6-b513-461fe63ab2de"), FeatureTypeId = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Value = "5+" },
                        new { Id = new Guid("8b0ade0e-6a89-4265-b90f-ac6a6c250b70"), FeatureTypeId = new Guid("d687e00d-d3e4-4de5-afb8-93a80acd1b39"), Value = "Yes" },
                        new { Id = new Guid("ef052e7d-649d-4fa1-9204-b30e8bfb2719"), FeatureTypeId = new Guid("d687e00d-d3e4-4de5-afb8-93a80acd1b39"), Value = "No" },
                        new { Id = new Guid("ba50a9d9-833a-4fb6-ae07-d33834cc8444"), FeatureTypeId = new Guid("4b5feecc-82d6-4e29-9402-cdbca627f41c"), Value = "Yes" },
                        new { Id = new Guid("c139b5e8-1ab4-4a8e-9563-d2bc0395be78"), FeatureTypeId = new Guid("4b5feecc-82d6-4e29-9402-cdbca627f41c"), Value = "No" },
                        new { Id = new Guid("00f19fe8-ccf7-40d5-aa16-ebe5e9e77ee5"), FeatureTypeId = new Guid("0b25b1c7-b2e7-4606-ae00-5c11f131ecac"), Value = "Balcony" },
                        new { Id = new Guid("de666692-88e5-49c3-b576-0e24b8b6d975"), FeatureTypeId = new Guid("0b25b1c7-b2e7-4606-ae00-5c11f131ecac"), Value = "Patio" },
                        new { Id = new Guid("87d1f8c8-8a59-4dbc-9558-782e05e5d287"), FeatureTypeId = new Guid("0b25b1c7-b2e7-4606-ae00-5c11f131ecac"), Value = "Deck" },
                        new { Id = new Guid("c39b59d4-928c-46b3-9347-bd6edaac4aef"), FeatureTypeId = new Guid("909a286b-5874-466e-b8db-ffbdf09dd32a"), Value = "Yes" },
                        new { Id = new Guid("cca27141-cddb-47f2-970d-a49914bb9558"), FeatureTypeId = new Guid("909a286b-5874-466e-b8db-ffbdf09dd32a"), Value = "No" },
                        new { Id = new Guid("d42ee863-5a88-4fec-93ad-5bcf000a0cc4"), FeatureTypeId = new Guid("6185250c-eb85-44cf-8ccb-4058c4c30113"), Value = "Yes" },
                        new { Id = new Guid("cb23aedf-f13d-4a4e-9d17-0971d2204d94"), FeatureTypeId = new Guid("6185250c-eb85-44cf-8ccb-4058c4c30113"), Value = "No" },
                        new { Id = new Guid("6e7b0d7b-7b17-442f-923b-5b061fdf9fbc"), FeatureTypeId = new Guid("3b0861f5-bda6-4ce2-9845-b1bd4da3aeda"), Value = "Yes" },
                        new { Id = new Guid("270d6342-d2e2-4944-8156-6cb9f6c83faf"), FeatureTypeId = new Guid("3b0861f5-bda6-4ce2-9845-b1bd4da3aeda"), Value = "No" },
                        new { Id = new Guid("5e83b877-8ca2-4c46-9b2b-8e4f8672b06e"), FeatureTypeId = new Guid("35acfdbe-dbaf-4850-a892-713ec0f2242b"), Value = "Yes" },
                        new { Id = new Guid("5c4f72ec-ca67-42cc-b6fa-b0a8fa2e41ba"), FeatureTypeId = new Guid("35acfdbe-dbaf-4850-a892-713ec0f2242b"), Value = "No" },
                        new { Id = new Guid("07f8afc7-b1f4-4c38-9331-1954c694a94b"), FeatureTypeId = new Guid("be407264-af46-493e-9c40-97f8ad537a65"), Value = "Yes" },
                        new { Id = new Guid("7d15a39c-b415-46fa-86d0-17de4cf0a020"), FeatureTypeId = new Guid("be407264-af46-493e-9c40-97f8ad537a65"), Value = "No" },
                        new { Id = new Guid("260f7162-0514-49f7-8aa9-59d870210276"), FeatureTypeId = new Guid("7332803b-85f9-40c1-8910-c5895fb0e0ea"), Value = "Some" },
                        new { Id = new Guid("4f7ef567-3e3b-49dd-8cde-16b8ac27cffd"), FeatureTypeId = new Guid("7332803b-85f9-40c1-8910-c5895fb0e0ea"), Value = "All" },
                        new { Id = new Guid("c9e3a395-aa25-4569-8f51-ae2fd4e3de5d"), FeatureTypeId = new Guid("db877e09-03cd-4587-8350-19e766ee2118"), Value = "Yes" },
                        new { Id = new Guid("5baf0a22-23c9-437c-bb29-8ec7717246c3"), FeatureTypeId = new Guid("db877e09-03cd-4587-8350-19e766ee2118"), Value = "No" },
                        new { Id = new Guid("92be21eb-a04f-4156-8e80-8175510ac299"), FeatureTypeId = new Guid("1f1d95d3-18eb-492a-8343-912d17da8b20"), Value = "Yes" },
                        new { Id = new Guid("0995e79c-6423-42c7-8717-78295b534ccd"), FeatureTypeId = new Guid("1f1d95d3-18eb-492a-8343-912d17da8b20"), Value = "No" },
                        new { Id = new Guid("90c919f9-6031-4f26-b701-cb34a2113886"), FeatureTypeId = new Guid("5c1ea1cb-eccb-409a-8999-6d3726653e0a"), Value = "Yes" },
                        new { Id = new Guid("8b7375d0-dd4f-4a70-88dc-bdc60517a329"), FeatureTypeId = new Guid("5c1ea1cb-eccb-409a-8999-6d3726653e0a"), Value = "No" },
                        new { Id = new Guid("a7cf7a84-ea2a-409f-a9b3-18538ab9a637"), FeatureTypeId = new Guid("51e102f5-7d0e-44cb-aad4-1b72c39b08d5"), Value = "Yes" },
                        new { Id = new Guid("dec89ebe-3a8d-4c99-b227-e625bd53fa9d"), FeatureTypeId = new Guid("51e102f5-7d0e-44cb-aad4-1b72c39b08d5"), Value = "No" },
                        new { Id = new Guid("ee6bd817-ee74-46c4-88de-e4c7fbf942a7"), FeatureTypeId = new Guid("dca236b2-4864-43a1-a611-250b6a6e7023"), Value = "Yes" },
                        new { Id = new Guid("3dae9876-ec49-4a1f-8c99-32c1621971b8"), FeatureTypeId = new Guid("dca236b2-4864-43a1-a611-250b6a6e7023"), Value = "No" },
                        new { Id = new Guid("202fd06e-146c-45ad-9e84-1a188e56d460"), FeatureTypeId = new Guid("59b4e1e3-2d4c-4038-81b3-0242c657ce1d"), Value = "Yes" },
                        new { Id = new Guid("a9a0109a-a105-4672-bbba-5abf88fd7ddc"), FeatureTypeId = new Guid("59b4e1e3-2d4c-4038-81b3-0242c657ce1d"), Value = "No" },
                        new { Id = new Guid("c0b715ec-d3a3-45b7-bd58-f4908848d2b7"), FeatureTypeId = new Guid("c1e85410-80cf-4d5d-b3c6-e121f0478801"), Value = "Yes" },
                        new { Id = new Guid("62468eae-7e69-48c7-91e7-721e079fbbd9"), FeatureTypeId = new Guid("c1e85410-80cf-4d5d-b3c6-e121f0478801"), Value = "No" },
                        new { Id = new Guid("eb1e8e7b-6b0a-4016-9170-f050a394d5f4"), FeatureTypeId = new Guid("edd71df4-1466-4b1d-8680-29be551d03ce"), Value = "Yes" },
                        new { Id = new Guid("9a536ffc-598e-469b-9bfe-d87c54b417c9"), FeatureTypeId = new Guid("edd71df4-1466-4b1d-8680-29be551d03ce"), Value = "No" },
                        new { Id = new Guid("e0a7f4ca-180b-451f-ae0c-ad113c04bed2"), FeatureTypeId = new Guid("c2bfacdd-e7f1-4a75-ac5d-de0561f20ad4"), Value = "Yes" },
                        new { Id = new Guid("1ce019f9-95bd-41ba-a2be-e269b6ba8db6"), FeatureTypeId = new Guid("c2bfacdd-e7f1-4a75-ac5d-de0561f20ad4"), Value = "No" },
                        new { Id = new Guid("6611cc9f-3450-4226-8fc8-a9cb62459118"), FeatureTypeId = new Guid("6c9de6ee-434f-4765-9d7c-d2f07b850022"), Value = "Yes" },
                        new { Id = new Guid("8ca1a88e-b8d8-4705-8477-ce09a55dc9d9"), FeatureTypeId = new Guid("6c9de6ee-434f-4765-9d7c-d2f07b850022"), Value = "No" },
                        new { Id = new Guid("ac8d16d9-9553-41a2-ac5c-414a706b82cd"), FeatureTypeId = new Guid("28e1e1bc-144e-49b4-a8b1-ccd1881584e4"), Value = "Yes" },
                        new { Id = new Guid("3de3822d-b99a-4959-a76e-0104711a9f1e"), FeatureTypeId = new Guid("28e1e1bc-144e-49b4-a8b1-ccd1881584e4"), Value = "No" },
                        new { Id = new Guid("26a95a0f-40a7-4fcd-b4c6-40bd8ba5a8a6"), FeatureTypeId = new Guid("8303575b-4716-49fd-9ca0-9da2917a94b4"), Value = "Yes" },
                        new { Id = new Guid("e57ce6b1-8c6a-4457-99d9-ca74f6b65f04"), FeatureTypeId = new Guid("8303575b-4716-49fd-9ca0-9da2917a94b4"), Value = "No" },
                        new { Id = new Guid("53b8a124-861b-43d7-8ba1-a98dce77b701"), FeatureTypeId = new Guid("68bc38ea-feb4-43a9-af5f-70a91984b97d"), Value = "Downtown" },
                        new { Id = new Guid("bdf88395-d8d8-4377-852d-fa055e9f6e5d"), FeatureTypeId = new Guid("68bc38ea-feb4-43a9-af5f-70a91984b97d"), Value = "Uptown" },
                        new { Id = new Guid("c7b49a79-ddc9-45ff-96c2-3db73beef504"), FeatureTypeId = new Guid("68bc38ea-feb4-43a9-af5f-70a91984b97d"), Value = "Rural" },
                        new { Id = new Guid("15823c31-2ae8-4265-bfd1-14cf1a50e8a2"), FeatureTypeId = new Guid("68bc38ea-feb4-43a9-af5f-70a91984b97d"), Value = "Suburban" }
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
                        new { Id = new Guid("bc901ae1-0541-48a3-853a-bd6b10b6023d"), Name = "Number of Bedrooms" },
                        new { Id = new Guid("0d422745-b047-4900-b1ba-2f889c71a2ae"), Name = "Number of Bathrooms" },
                        new { Id = new Guid("eff84e30-fc8b-4881-a9ec-e42504c744a7"), Name = "Kitchen size" },
                        new { Id = new Guid("1a0677e7-312f-4686-acd2-e6fd17a1871c"), Name = "Garage" },
                        new { Id = new Guid("e217df24-696a-41fb-a7c5-29db2c46916d"), Name = "Number of Auto Spaces" },
                        new { Id = new Guid("d687e00d-d3e4-4de5-afb8-93a80acd1b39"), Name = "Pets Allowed" },
                        new { Id = new Guid("4b5feecc-82d6-4e29-9402-cdbca627f41c"), Name = "Air Conditioning" },
                        new { Id = new Guid("0b25b1c7-b2e7-4606-ae00-5c11f131ecac"), Name = "Balcony Type" },
                        new { Id = new Guid("909a286b-5874-466e-b8db-ffbdf09dd32a"), Name = "Cable Ready" },
                        new { Id = new Guid("6185250c-eb85-44cf-8ccb-4058c4c30113"), Name = "Dishwasher" },
                        new { Id = new Guid("3b0861f5-bda6-4ce2-9845-b1bd4da3aeda"), Name = "Microwave Included" },
                        new { Id = new Guid("35acfdbe-dbaf-4850-a892-713ec0f2242b"), Name = "Handicap Accessible" },
                        new { Id = new Guid("be407264-af46-493e-9c40-97f8ad537a65"), Name = "Hardwood Floors" },
                        new { Id = new Guid("7332803b-85f9-40c1-8910-c5895fb0e0ea"), Name = "Utilities Covered" },
                        new { Id = new Guid("db877e09-03cd-4587-8350-19e766ee2118"), Name = "Walk-In Closets" },
                        new { Id = new Guid("1f1d95d3-18eb-492a-8343-912d17da8b20"), Name = "Washer/Dryer Included" },
                        new { Id = new Guid("5c1ea1cb-eccb-409a-8999-6d3726653e0a"), Name = "Security System" },
                        new { Id = new Guid("51e102f5-7d0e-44cb-aad4-1b72c39b08d5"), Name = "Limited/Controlled Access" },
                        new { Id = new Guid("dca236b2-4864-43a1-a611-250b6a6e7023"), Name = "Elevator" },
                        new { Id = new Guid("59b4e1e3-2d4c-4038-81b3-0242c657ce1d"), Name = "Extra Storage" },
                        new { Id = new Guid("c1e85410-80cf-4d5d-b3c6-e121f0478801"), Name = "Fitness Center Nearby" },
                        new { Id = new Guid("edd71df4-1466-4b1d-8680-29be551d03ce"), Name = "Business Center Nearby" },
                        new { Id = new Guid("c2bfacdd-e7f1-4a75-ac5d-de0561f20ad4"), Name = "Laundry Facility Nearby" },
                        new { Id = new Guid("6c9de6ee-434f-4765-9d7c-d2f07b850022"), Name = "Pool Nearby" },
                        new { Id = new Guid("28e1e1bc-144e-49b4-a8b1-ccd1881584e4"), Name = "Park Nearby" },
                        new { Id = new Guid("8303575b-4716-49fd-9ca0-9da2917a94b4"), Name = "Senior Living" },
                        new { Id = new Guid("68bc38ea-feb4-43a9-af5f-70a91984b97d"), Name = "Neighbourhood Type" }
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
