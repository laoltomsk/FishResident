using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FeatureTypes",
                columns: new[] { "Id", "AdditionalInfo", "Name" },
                values: new object[,]
                {
                    { new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), null, "Number of Bedrooms" },
                    { new Guid("2e249ddf-6480-48f0-a2af-d006b63c0820"), null, "Park Nearby" },
                    { new Guid("96523902-8bec-43e1-b06f-46928c1cb7c3"), null, "Pool Nearby" },
                    { new Guid("9d820672-fba8-48cd-8809-a6504208cd93"), null, "Laundry Facility Nearby" },
                    { new Guid("df66f8f8-fd1a-4ad9-988e-7b07f4d1b3fc"), null, "Business Center Nearby" },
                    { new Guid("860d740f-3601-4cf0-809e-aefc29590384"), null, "Fitness Center Nearby" },
                    { new Guid("161e328d-9113-4660-92dc-ec33d611fb5e"), null, "Extra Storage" },
                    { new Guid("b82be4d7-5c32-406f-a6d7-18fdcf9f8957"), null, "Elevator" },
                    { new Guid("019c22d7-245f-42e2-acdd-3e9c10b35f20"), null, "Limited/Controlled Access" },
                    { new Guid("6a07d58f-5923-444f-81d6-551aee735b95"), null, "Security System" },
                    { new Guid("8c4d9182-b6c3-477e-8d96-b72d2f1faa76"), null, "Washer/Dryer Included" },
                    { new Guid("1c31d417-8d3d-45b4-b873-ccfa68e01337"), null, "Walk-In Closets" },
                    { new Guid("2a862dab-b3f4-46aa-b530-523700b71dc8"), null, "Senior Living" },
                    { new Guid("12df7757-f094-4c62-8007-3fc5b9c0e708"), null, "Utilities Covered" },
                    { new Guid("fad30160-75db-4c16-8288-ea0b4cc67af8"), null, "Handicap Accessible" },
                    { new Guid("b3acfa2f-7481-4afd-b099-9f8f8cd6a1fb"), null, "Microwave Included" },
                    { new Guid("e8f29d92-d800-477a-913d-f39ae7f77735"), null, "Dishwasher" },
                    { new Guid("bf1a0fb1-f04a-4c87-ad5c-c0fa1e77c9a6"), null, "Cable Ready" },
                    { new Guid("9b689a2e-0e25-436b-bc12-517a2c6a05f7"), null, "Balcony Type" },
                    { new Guid("7831ede4-2635-4ab1-b796-6eb664a3bac4"), null, "Air Conditioning" },
                    { new Guid("18a584f2-21fd-44e8-a53c-de29ebf1ed09"), null, "Pets Allowed" },
                    { new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), null, "Number of Auto Spaces" },
                    { new Guid("8254aff4-912b-4fcc-8512-855fbd2449e9"), null, "Garage" },
                    { new Guid("efdab8f3-ff91-4fed-9115-69f04f699f02"), null, "Kitchen size" },
                    { new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), null, "Number of Bathrooms" },
                    { new Guid("04c7f6b8-4302-44e5-983b-badc105b89e9"), null, "Hardwood Floors" },
                    { new Guid("86803789-aea0-4891-9f4e-05e3d9d49c2f"), null, "Neighbourhood Type" }
                });

            migrationBuilder.InsertData(
                table: "FeatureAllowedValues",
                columns: new[] { "Id", "FeatureTypeId", "Value" },
                values: new object[,]
                {
                    { new Guid("14682791-6e10-4599-8774-d2e81529137b"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "0" },
                    { new Guid("dfa9f131-db2a-442e-a8de-4f81011a6aca"), new Guid("019c22d7-245f-42e2-acdd-3e9c10b35f20"), "Yes" },
                    { new Guid("4288f791-9d4c-4bf2-98e4-3d6413407426"), new Guid("6a07d58f-5923-444f-81d6-551aee735b95"), "No" },
                    { new Guid("4d3421a0-234d-4682-ae7e-7ebee824e494"), new Guid("6a07d58f-5923-444f-81d6-551aee735b95"), "Yes" },
                    { new Guid("b3e6d660-1bc6-4b6f-b887-443c94ab6ceb"), new Guid("8c4d9182-b6c3-477e-8d96-b72d2f1faa76"), "No" },
                    { new Guid("293e6c41-aa79-48c4-8425-3ca16dedf6f3"), new Guid("8c4d9182-b6c3-477e-8d96-b72d2f1faa76"), "Yes" },
                    { new Guid("8bbf7b52-a166-4c01-af61-83bdae61c234"), new Guid("1c31d417-8d3d-45b4-b873-ccfa68e01337"), "No" },
                    { new Guid("076c14ed-0f6c-4e0b-9061-883bc2bda1a7"), new Guid("1c31d417-8d3d-45b4-b873-ccfa68e01337"), "Yes" },
                    { new Guid("b9a7f8d2-a143-4e1b-b84e-cc4f86652e03"), new Guid("12df7757-f094-4c62-8007-3fc5b9c0e708"), "All" },
                    { new Guid("57b1be3e-747f-4256-88d5-8b251f6fa996"), new Guid("12df7757-f094-4c62-8007-3fc5b9c0e708"), "Some" },
                    { new Guid("dfa3548d-2150-4f72-8a4c-be426a7d4977"), new Guid("04c7f6b8-4302-44e5-983b-badc105b89e9"), "No" },
                    { new Guid("210c14ed-0fdf-44a3-adda-0e5d0bf00f98"), new Guid("04c7f6b8-4302-44e5-983b-badc105b89e9"), "Yes" },
                    { new Guid("5cca763e-7b7a-4120-8658-93f9b2594f5f"), new Guid("fad30160-75db-4c16-8288-ea0b4cc67af8"), "No" },
                    { new Guid("d49771b4-57fc-43cd-8e1b-5eb8c1e6b4a4"), new Guid("fad30160-75db-4c16-8288-ea0b4cc67af8"), "Yes" },
                    { new Guid("6eff0927-36db-422a-987e-6c6367e0f7f3"), new Guid("b3acfa2f-7481-4afd-b099-9f8f8cd6a1fb"), "No" },
                    { new Guid("12185a27-a3da-4474-99e3-ec37575dc1c5"), new Guid("b3acfa2f-7481-4afd-b099-9f8f8cd6a1fb"), "Yes" },
                    { new Guid("c7b40a26-625b-4077-9a24-45eba2effdb2"), new Guid("019c22d7-245f-42e2-acdd-3e9c10b35f20"), "No" },
                    { new Guid("f44fa2dc-f0e4-4b3e-83de-d8250ccfd786"), new Guid("e8f29d92-d800-477a-913d-f39ae7f77735"), "No" },
                    { new Guid("36e2cff5-2079-42e2-8d33-42b0a27c45f3"), new Guid("b82be4d7-5c32-406f-a6d7-18fdcf9f8957"), "Yes" },
                    { new Guid("f893303a-a3d7-45fd-b0ad-b0fdc220725a"), new Guid("161e328d-9113-4660-92dc-ec33d611fb5e"), "Yes" },
                    { new Guid("38915eb4-0812-46c9-a7bb-1df0760eac73"), new Guid("86803789-aea0-4891-9f4e-05e3d9d49c2f"), "Uptown" },
                    { new Guid("b0813ce8-bdce-4152-a7d2-bb34b75a5d1a"), new Guid("86803789-aea0-4891-9f4e-05e3d9d49c2f"), "Downtown" },
                    { new Guid("92c6ab7a-f451-4133-b145-74f4d7eede24"), new Guid("2a862dab-b3f4-46aa-b530-523700b71dc8"), "No" },
                    { new Guid("12d52f05-9f30-4cee-b3e6-1619cbdc0bda"), new Guid("2a862dab-b3f4-46aa-b530-523700b71dc8"), "Yes" },
                    { new Guid("b1b24e14-0c08-4606-91f2-45b3367f6484"), new Guid("2e249ddf-6480-48f0-a2af-d006b63c0820"), "No" },
                    { new Guid("aa3a9473-df57-4734-a84b-bcd2aafcc877"), new Guid("2e249ddf-6480-48f0-a2af-d006b63c0820"), "Yes" },
                    { new Guid("fa229a20-4ace-47c3-9b51-1eb4697df75b"), new Guid("96523902-8bec-43e1-b06f-46928c1cb7c3"), "No" },
                    { new Guid("1140e74f-fa7e-4fac-9ff4-dda2b3fe1606"), new Guid("96523902-8bec-43e1-b06f-46928c1cb7c3"), "Yes" },
                    { new Guid("b630cc57-575c-4408-938c-d48c1503eab8"), new Guid("9d820672-fba8-48cd-8809-a6504208cd93"), "No" },
                    { new Guid("a24b993a-7a98-420f-b43d-1cf567b6c4bf"), new Guid("9d820672-fba8-48cd-8809-a6504208cd93"), "Yes" },
                    { new Guid("8b1c00c6-cbaa-4e1f-8173-788bcd6375aa"), new Guid("df66f8f8-fd1a-4ad9-988e-7b07f4d1b3fc"), "No" },
                    { new Guid("d4ae204e-a8c1-4570-8e0f-8f1f9b42d53c"), new Guid("df66f8f8-fd1a-4ad9-988e-7b07f4d1b3fc"), "Yes" },
                    { new Guid("4a67e12d-71e2-48ea-b72d-ec56c4a4a435"), new Guid("860d740f-3601-4cf0-809e-aefc29590384"), "No" },
                    { new Guid("93b2be0c-9676-4cbe-83cf-8c448f1e918d"), new Guid("860d740f-3601-4cf0-809e-aefc29590384"), "Yes" },
                    { new Guid("e5b56077-5b78-42e9-9226-cf68a5c42390"), new Guid("161e328d-9113-4660-92dc-ec33d611fb5e"), "No" },
                    { new Guid("3c96fa3e-9394-471d-90a2-5ca8208aa5cc"), new Guid("b82be4d7-5c32-406f-a6d7-18fdcf9f8957"), "No" },
                    { new Guid("f039ea52-1529-4f71-bf66-70f65be77331"), new Guid("86803789-aea0-4891-9f4e-05e3d9d49c2f"), "Rural" },
                    { new Guid("136e7004-389f-43bd-9b7d-226a893516b2"), new Guid("e8f29d92-d800-477a-913d-f39ae7f77735"), "Yes" },
                    { new Guid("98462f7c-bc11-410d-b6ae-54aee7196ae9"), new Guid("bf1a0fb1-f04a-4c87-ad5c-c0fa1e77c9a6"), "Yes" },
                    { new Guid("3868e4c6-1020-4af4-9e5e-66cd71df1bf7"), new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), "4" },
                    { new Guid("ad9ae204-8f41-441b-942f-2b1e15dbf0ac"), new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), "3" },
                    { new Guid("deb88c6e-c749-4c15-a093-8bb4734dcc40"), new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), "2" },
                    { new Guid("fa4b98e1-ff02-42d3-9aa2-e9484c80c3c5"), new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), "1" },
                    { new Guid("30b077ef-bdc9-48f0-828d-b2b269c997a1"), new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), "0" },
                    { new Guid("8418e691-0b88-49ae-97b4-6664f03e779f"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "10+" },
                    { new Guid("b82bf523-b5c6-49b0-a8a7-d177817e1565"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "9" },
                    { new Guid("ee24c21b-2623-49cb-8677-0e28736faee9"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "8" },
                    { new Guid("42529dbe-3bd0-4445-b753-7e9cdd1d132f"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "7" },
                    { new Guid("354b4ea4-b2f1-4d36-915d-a0c305e494f8"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "6" },
                    { new Guid("d8c78e56-adcd-45ee-ad2d-02ab493286b6"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "5" },
                    { new Guid("0d848b79-0198-4270-b233-f3f825ecc3a6"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "4" },
                    { new Guid("6a6d268d-95a4-4c76-b1ab-fa22ec729eef"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "3" },
                    { new Guid("7657d9ad-e36b-4db5-8c69-1bd0a28de498"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "2" },
                    { new Guid("1af08858-b2fb-464a-aa8b-c4f9875d9d7d"), new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"), "1" },
                    { new Guid("1d043bf8-b50c-4559-9aa1-930c7d35d837"), new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"), "5+" },
                    { new Guid("c5b8c6fe-d076-46b2-bfa6-45687142b498"), new Guid("bf1a0fb1-f04a-4c87-ad5c-c0fa1e77c9a6"), "No" },
                    { new Guid("8f2c1445-8500-4727-95be-9b0835228a9a"), new Guid("efdab8f3-ff91-4fed-9115-69f04f699f02"), "Small" },
                    { new Guid("de892f39-b8fd-42bd-97dc-6f51392f94d3"), new Guid("efdab8f3-ff91-4fed-9115-69f04f699f02"), "Large" },
                    { new Guid("fa52f846-24e5-46b2-b4f3-2405c2d2a224"), new Guid("9b689a2e-0e25-436b-bc12-517a2c6a05f7"), "Deck" },
                    { new Guid("f3dfcfcb-ed0c-4918-a74a-ef2d6c28ebca"), new Guid("9b689a2e-0e25-436b-bc12-517a2c6a05f7"), "Patio" },
                    { new Guid("d9e22588-b640-4f49-aa03-4c648f02851b"), new Guid("9b689a2e-0e25-436b-bc12-517a2c6a05f7"), "Balcony" },
                    { new Guid("1516bc8d-b5de-41f6-9d23-6b48ce54526e"), new Guid("7831ede4-2635-4ab1-b796-6eb664a3bac4"), "No" },
                    { new Guid("d7d026dc-a338-4a5d-ad75-f7a57bbf3efa"), new Guid("7831ede4-2635-4ab1-b796-6eb664a3bac4"), "Yes" },
                    { new Guid("7602a41b-b811-4f81-9d3c-66a653955ba8"), new Guid("18a584f2-21fd-44e8-a53c-de29ebf1ed09"), "No" },
                    { new Guid("ecec7aea-bffa-4520-90a3-0cee822ee263"), new Guid("18a584f2-21fd-44e8-a53c-de29ebf1ed09"), "Yes" },
                    { new Guid("d21b366e-9001-4cf2-a9e8-c1d046be1182"), new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), "5+" },
                    { new Guid("c8a727c8-f847-43ab-b2cb-0b32c0d0a2be"), new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), "4" },
                    { new Guid("fb5e296f-6c35-45d7-8370-3b0beeabbc1a"), new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), "3" },
                    { new Guid("14b151c1-7441-41f2-9d8d-4660dcac0fd9"), new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), "2" },
                    { new Guid("1068ea7d-bc93-49c4-8481-37ea39b89bd8"), new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), "1" },
                    { new Guid("c352da93-fee0-4947-a6d4-1a9a66cf05ee"), new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"), "0" },
                    { new Guid("905a0f09-d0a3-46b2-8266-97b02aca6d73"), new Guid("8254aff4-912b-4fcc-8512-855fbd2449e9"), "No" },
                    { new Guid("052470a7-9a0c-4d2e-a019-dccd59bff04c"), new Guid("8254aff4-912b-4fcc-8512-855fbd2449e9"), "Yes" },
                    { new Guid("5de2e927-6030-4c01-9bff-dcea97bded22"), new Guid("efdab8f3-ff91-4fed-9115-69f04f699f02"), "Medium" },
                    { new Guid("4be6e53a-b0fb-4aa2-a39b-71464b50bc7e"), new Guid("86803789-aea0-4891-9f4e-05e3d9d49c2f"), "Suburban" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("052470a7-9a0c-4d2e-a019-dccd59bff04c"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("076c14ed-0f6c-4e0b-9061-883bc2bda1a7"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("0d848b79-0198-4270-b233-f3f825ecc3a6"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("1068ea7d-bc93-49c4-8481-37ea39b89bd8"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("1140e74f-fa7e-4fac-9ff4-dda2b3fe1606"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("12185a27-a3da-4474-99e3-ec37575dc1c5"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("12d52f05-9f30-4cee-b3e6-1619cbdc0bda"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("136e7004-389f-43bd-9b7d-226a893516b2"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("14682791-6e10-4599-8774-d2e81529137b"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("14b151c1-7441-41f2-9d8d-4660dcac0fd9"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("1516bc8d-b5de-41f6-9d23-6b48ce54526e"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("1af08858-b2fb-464a-aa8b-c4f9875d9d7d"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("1d043bf8-b50c-4559-9aa1-930c7d35d837"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("210c14ed-0fdf-44a3-adda-0e5d0bf00f98"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("293e6c41-aa79-48c4-8425-3ca16dedf6f3"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("30b077ef-bdc9-48f0-828d-b2b269c997a1"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("354b4ea4-b2f1-4d36-915d-a0c305e494f8"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("36e2cff5-2079-42e2-8d33-42b0a27c45f3"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("3868e4c6-1020-4af4-9e5e-66cd71df1bf7"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("38915eb4-0812-46c9-a7bb-1df0760eac73"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("3c96fa3e-9394-471d-90a2-5ca8208aa5cc"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("42529dbe-3bd0-4445-b753-7e9cdd1d132f"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("4288f791-9d4c-4bf2-98e4-3d6413407426"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("4a67e12d-71e2-48ea-b72d-ec56c4a4a435"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("4be6e53a-b0fb-4aa2-a39b-71464b50bc7e"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("4d3421a0-234d-4682-ae7e-7ebee824e494"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("57b1be3e-747f-4256-88d5-8b251f6fa996"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("5cca763e-7b7a-4120-8658-93f9b2594f5f"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("5de2e927-6030-4c01-9bff-dcea97bded22"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("6a6d268d-95a4-4c76-b1ab-fa22ec729eef"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("6eff0927-36db-422a-987e-6c6367e0f7f3"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("7602a41b-b811-4f81-9d3c-66a653955ba8"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("7657d9ad-e36b-4db5-8c69-1bd0a28de498"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("8418e691-0b88-49ae-97b4-6664f03e779f"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("8b1c00c6-cbaa-4e1f-8173-788bcd6375aa"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("8bbf7b52-a166-4c01-af61-83bdae61c234"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("8f2c1445-8500-4727-95be-9b0835228a9a"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("905a0f09-d0a3-46b2-8266-97b02aca6d73"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("92c6ab7a-f451-4133-b145-74f4d7eede24"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("93b2be0c-9676-4cbe-83cf-8c448f1e918d"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("98462f7c-bc11-410d-b6ae-54aee7196ae9"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("a24b993a-7a98-420f-b43d-1cf567b6c4bf"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("aa3a9473-df57-4734-a84b-bcd2aafcc877"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("ad9ae204-8f41-441b-942f-2b1e15dbf0ac"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("b0813ce8-bdce-4152-a7d2-bb34b75a5d1a"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("b1b24e14-0c08-4606-91f2-45b3367f6484"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("b3e6d660-1bc6-4b6f-b887-443c94ab6ceb"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("b630cc57-575c-4408-938c-d48c1503eab8"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("b82bf523-b5c6-49b0-a8a7-d177817e1565"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("b9a7f8d2-a143-4e1b-b84e-cc4f86652e03"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("c352da93-fee0-4947-a6d4-1a9a66cf05ee"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("c5b8c6fe-d076-46b2-bfa6-45687142b498"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("c7b40a26-625b-4077-9a24-45eba2effdb2"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("c8a727c8-f847-43ab-b2cb-0b32c0d0a2be"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("d21b366e-9001-4cf2-a9e8-c1d046be1182"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("d49771b4-57fc-43cd-8e1b-5eb8c1e6b4a4"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("d4ae204e-a8c1-4570-8e0f-8f1f9b42d53c"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("d7d026dc-a338-4a5d-ad75-f7a57bbf3efa"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("d8c78e56-adcd-45ee-ad2d-02ab493286b6"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("d9e22588-b640-4f49-aa03-4c648f02851b"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("de892f39-b8fd-42bd-97dc-6f51392f94d3"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("deb88c6e-c749-4c15-a093-8bb4734dcc40"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("dfa3548d-2150-4f72-8a4c-be426a7d4977"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("dfa9f131-db2a-442e-a8de-4f81011a6aca"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("e5b56077-5b78-42e9-9226-cf68a5c42390"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("ecec7aea-bffa-4520-90a3-0cee822ee263"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("ee24c21b-2623-49cb-8677-0e28736faee9"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("f039ea52-1529-4f71-bf66-70f65be77331"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("f3dfcfcb-ed0c-4918-a74a-ef2d6c28ebca"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("f44fa2dc-f0e4-4b3e-83de-d8250ccfd786"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("f893303a-a3d7-45fd-b0ad-b0fdc220725a"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("fa229a20-4ace-47c3-9b51-1eb4697df75b"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("fa4b98e1-ff02-42d3-9aa2-e9484c80c3c5"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("fa52f846-24e5-46b2-b4f3-2405c2d2a224"));

            migrationBuilder.DeleteData(
                table: "FeatureAllowedValues",
                keyColumn: "Id",
                keyValue: new Guid("fb5e296f-6c35-45d7-8370-3b0beeabbc1a"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("019c22d7-245f-42e2-acdd-3e9c10b35f20"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("04c7f6b8-4302-44e5-983b-badc105b89e9"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("12df7757-f094-4c62-8007-3fc5b9c0e708"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("161e328d-9113-4660-92dc-ec33d611fb5e"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("18a584f2-21fd-44e8-a53c-de29ebf1ed09"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("1c31d417-8d3d-45b4-b873-ccfa68e01337"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a862dab-b3f4-46aa-b530-523700b71dc8"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("2e249ddf-6480-48f0-a2af-d006b63c0820"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("6a07d58f-5923-444f-81d6-551aee735b95"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("7831ede4-2635-4ab1-b796-6eb664a3bac4"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("8254aff4-912b-4fcc-8512-855fbd2449e9"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("860d740f-3601-4cf0-809e-aefc29590384"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("86803789-aea0-4891-9f4e-05e3d9d49c2f"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("8c4d9182-b6c3-477e-8d96-b72d2f1faa76"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("96523902-8bec-43e1-b06f-46928c1cb7c3"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("9b689a2e-0e25-436b-bc12-517a2c6a05f7"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("9d820672-fba8-48cd-8809-a6504208cd93"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("b3acfa2f-7481-4afd-b099-9f8f8cd6a1fb"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("b4e5eecc-dd95-4bf1-a672-35013cce2cd9"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("b82be4d7-5c32-406f-a6d7-18fdcf9f8957"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("be07edf3-18a7-4ffa-98af-43cedc5f11bf"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("bf1a0fb1-f04a-4c87-ad5c-c0fa1e77c9a6"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("cd1d2594-bdbb-40db-a1b6-2f0ece6c1ed6"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("df66f8f8-fd1a-4ad9-988e-7b07f4d1b3fc"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8f29d92-d800-477a-913d-f39ae7f77735"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("efdab8f3-ff91-4fed-9115-69f04f699f02"));

            migrationBuilder.DeleteData(
                table: "FeatureTypes",
                keyColumn: "Id",
                keyValue: new Guid("fad30160-75db-4c16-8288-ea0b4cc67af8"));
        }
    }
}
