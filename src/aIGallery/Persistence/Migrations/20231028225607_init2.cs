using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("308a5dec-7e1f-48b7-a692-a630a5da1c1f"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("31aab8dc-7d85-40fb-87c7-7fc43d163f06"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("a73e3f56-8441-4c5e-af1b-f658977d4e91"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("ab83c9ca-3f97-43a4-bf6d-9b893a8cdab2"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("b0dbba83-d92e-4ebd-b8d6-d4783ff51a12"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("b4f931ce-6cb4-4905-a509-cb48ff3975a5"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("c1503267-8ad4-439f-a164-af1788430f4f"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("e628f536-b82e-4c25-aa8e-4acfb398ca54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02b8791d-60a8-4390-88a8-a625b84e8165"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c4ebc82-445f-41c3-b9a9-553789ba646f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4db28f8c-7184-4e53-a19d-f8ddfc8ae9dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60e8f38c-c6d8-442c-8305-d2d3bf52b68b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65d8a782-0fa9-45e5-ba39-d8871a4e338b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c41200f7-670b-4aa8-b115-9e37243893b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc07bceb-d2fa-417e-a3ae-7f4a597ff2a2"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("016b9251-591a-433b-8e0a-e66b4fe46fe1"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("04924b4f-1362-4ede-b9db-9335573a10bc"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("0fc3e297-a026-478a-8d8c-24d0b19715a1"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("1b068522-e895-428c-9def-5a1bd15cdfb7"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("2c51fe7a-09ed-44f6-a36e-439b044f5b5a"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("39be740b-9bb5-4154-981b-fc9fdee2b62a"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("3ab10224-91d6-4bc4-b7db-efa7b45b3544"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("3bf5b096-38c5-4feb-8e91-666ea457f3dd"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("3d09367d-2678-4dcc-97a1-63ffbc8cd1c8"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("48897e69-7ffd-43f7-820f-03c5039374e3"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("4a7b4c4c-ea83-4912-8193-8e22f323f66d"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("5fd62773-8ca6-4e37-862b-1e9a934b5271"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6d673815-631d-49ad-9cfd-b48b0541a6a7"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6e9e5a86-bd70-4c6a-aa7e-01e40c8fcb81"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("80577fbe-bb6b-4572-b5bb-8b85ffb0ac61"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8c53d848-ee72-4043-8d55-95f357c554a4"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a5a24afc-7693-4ab0-9454-dbab3d532b46"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("b8e449ae-d4a8-4aac-b0dd-e0139d67bb4d"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c68edc6a-e2b9-4f81-8abc-c35d67f6404c"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("e9b32cab-4b79-4cb2-ae64-82291f5f104b"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f5f04550-9130-45ba-b13f-4cc4ef973fdd"));

            migrationBuilder.InsertData(
                table: "ArtStyles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Prompt", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0e37c000-101e-4b40-893f-e08abefe8df9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("10fe7f1e-20a5-4ee7-acd0-630f8e37861a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null },
                    { new Guid("2b73bec4-4fc4-4da2-913e-501bd958e2df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null },
                    { new Guid("34eb32cd-c0f1-4631-a702-6fe29d080167"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null },
                    { new Guid("5a209d98-8f89-4856-add1-edc3d934a2b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null },
                    { new Guid("c4f12a64-28da-4f2e-9970-660558fbc423"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("d57cc25b-97c3-492c-b01d-fe9a9e9c6576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("fd8dade5-070d-43d6-bc65-92e517609c8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2cb11fa3-f189-4ba7-827d-a36835923bc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null },
                    { new Guid("48b41f32-af8e-42ac-a7dc-6ecfdebb19ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null },
                    { new Guid("580a6c62-73cd-4a23-9071-86ad32d5c3dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null },
                    { new Guid("88fba718-38f2-420c-98ce-a936bb552e97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("8ab3c6cc-3c15-42df-a213-b7d498687d0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null },
                    { new Guid("dd9219db-2b73-4813-8537-02f2c6e36682"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("e3e9e3d4-5d74-4fbb-b88e-110a8d6b3dbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0d670d94-ab71-474e-8e13-1667a697598e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("37880db7-b1ca-4a3c-bf28-ebd058a0aecf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("5081d4ba-357e-4103-8835-4418febee80e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("51d3c41b-b96e-4adc-a435-eb623b17518e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("52840341-0515-4b42-a86c-98e4bd5ac143"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null },
                    { new Guid("60b6e90e-7e47-4150-b472-7e581ecc5169"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("62ae89ba-07d0-45e8-a2f7-05467afe4401"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("68bfeaa0-d8a0-4afa-8c8c-6d1802c556b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("6af43241-b5b8-4206-95d5-533926b6b868"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null },
                    { new Guid("6fde01e9-0db3-491e-9014-b241062eea6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("75b6971a-9455-4d68-9e69-f18849f772a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("7a8a8567-4db5-4dac-b79a-01367b5de1bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("87834169-b116-4165-9a37-52a544592ac9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null },
                    { new Guid("897c416a-da0b-4dd1-99aa-ca01fc90cced"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null },
                    { new Guid("8be0cb76-1ce3-46dd-912d-7d79b51938a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null },
                    { new Guid("8c470d2f-28f1-44f5-b8af-ead9cfa9e7fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("9d1f7126-3a11-4299-bc3d-5eac7eb28b1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("ba72afe2-a2ef-4af3-938a-c11dedcd6fa9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("d79d663e-3a03-4910-a6b5-268d3ee6ffed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("eebf6673-7746-4add-bcd2-0000e1fea895"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("f0c754b7-dafb-4230-8bb7-309048777e9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 116, 22, 172, 28, 76, 84, 69, 103, 202, 80, 149, 34, 146, 169, 73, 185, 194, 127, 124, 10, 210, 44, 80, 130, 208, 129, 83, 177, 2, 119, 140, 248, 253, 124, 105, 248, 239, 133, 182, 251, 114, 47, 117, 207, 58, 239, 244, 241, 153, 98, 99, 83, 7, 251, 154, 120, 231, 162, 210, 80, 19, 250, 116, 131 }, new byte[] { 38, 170, 45, 17, 79, 140, 141, 220, 125, 195, 169, 247, 65, 2, 63, 186, 19, 77, 71, 124, 39, 175, 76, 101, 147, 15, 71, 46, 46, 110, 64, 20, 111, 141, 236, 149, 186, 0, 207, 197, 65, 6, 220, 95, 211, 98, 48, 16, 254, 211, 68, 69, 204, 217, 90, 4, 216, 72, 172, 132, 102, 44, 245, 237, 201, 210, 113, 179, 177, 82, 0, 190, 255, 214, 103, 197, 102, 43, 137, 50, 182, 7, 146, 137, 122, 39, 91, 97, 8, 215, 185, 25, 52, 178, 223, 112, 176, 159, 183, 254, 63, 11, 0, 17, 100, 71, 97, 203, 48, 67, 192, 65, 186, 175, 151, 36, 166, 86, 59, 61, 74, 82, 84, 248, 171, 228, 51, 158 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("0e37c000-101e-4b40-893f-e08abefe8df9"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("10fe7f1e-20a5-4ee7-acd0-630f8e37861a"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("2b73bec4-4fc4-4da2-913e-501bd958e2df"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("34eb32cd-c0f1-4631-a702-6fe29d080167"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("5a209d98-8f89-4856-add1-edc3d934a2b1"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("c4f12a64-28da-4f2e-9970-660558fbc423"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("d57cc25b-97c3-492c-b01d-fe9a9e9c6576"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("fd8dade5-070d-43d6-bc65-92e517609c8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2cb11fa3-f189-4ba7-827d-a36835923bc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48b41f32-af8e-42ac-a7dc-6ecfdebb19ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("580a6c62-73cd-4a23-9071-86ad32d5c3dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88fba718-38f2-420c-98ce-a936bb552e97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ab3c6cc-3c15-42df-a213-b7d498687d0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd9219db-2b73-4813-8537-02f2c6e36682"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3e9e3d4-5d74-4fbb-b88e-110a8d6b3dbc"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("0d670d94-ab71-474e-8e13-1667a697598e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("37880db7-b1ca-4a3c-bf28-ebd058a0aecf"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("5081d4ba-357e-4103-8835-4418febee80e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("51d3c41b-b96e-4adc-a435-eb623b17518e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("52840341-0515-4b42-a86c-98e4bd5ac143"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("60b6e90e-7e47-4150-b472-7e581ecc5169"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("62ae89ba-07d0-45e8-a2f7-05467afe4401"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("68bfeaa0-d8a0-4afa-8c8c-6d1802c556b1"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6af43241-b5b8-4206-95d5-533926b6b868"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6fde01e9-0db3-491e-9014-b241062eea6e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("75b6971a-9455-4d68-9e69-f18849f772a7"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("7a8a8567-4db5-4dac-b79a-01367b5de1bf"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("87834169-b116-4165-9a37-52a544592ac9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("897c416a-da0b-4dd1-99aa-ca01fc90cced"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8be0cb76-1ce3-46dd-912d-7d79b51938a4"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8c470d2f-28f1-44f5-b8af-ead9cfa9e7fa"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("9d1f7126-3a11-4299-bc3d-5eac7eb28b1c"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("ba72afe2-a2ef-4af3-938a-c11dedcd6fa9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("d79d663e-3a03-4910-a6b5-268d3ee6ffed"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("eebf6673-7746-4add-bcd2-0000e1fea895"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f0c754b7-dafb-4230-8bb7-309048777e9a"));

            migrationBuilder.InsertData(
                table: "ArtStyles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Prompt", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("308a5dec-7e1f-48b7-a692-a630a5da1c1f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null },
                    { new Guid("31aab8dc-7d85-40fb-87c7-7fc43d163f06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("a73e3f56-8441-4c5e-af1b-f658977d4e91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null },
                    { new Guid("ab83c9ca-3f97-43a4-bf6d-9b893a8cdab2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null },
                    { new Guid("b0dbba83-d92e-4ebd-b8d6-d4783ff51a12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null },
                    { new Guid("b4f931ce-6cb4-4905-a509-cb48ff3975a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("c1503267-8ad4-439f-a164-af1788430f4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("e628f536-b82e-4c25-aa8e-4acfb398ca54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("02b8791d-60a8-4390-88a8-a625b84e8165"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null },
                    { new Guid("1c4ebc82-445f-41c3-b9a9-553789ba646f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null },
                    { new Guid("4db28f8c-7184-4e53-a19d-f8ddfc8ae9dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("60e8f38c-c6d8-442c-8305-d2d3bf52b68b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null },
                    { new Guid("65d8a782-0fa9-45e5-ba39-d8871a4e338b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("c41200f7-670b-4aa8-b115-9e37243893b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null },
                    { new Guid("fc07bceb-d2fa-417e-a3ae-7f4a597ff2a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("016b9251-591a-433b-8e0a-e66b4fe46fe1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("04924b4f-1362-4ede-b9db-9335573a10bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("0fc3e297-a026-478a-8d8c-24d0b19715a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null },
                    { new Guid("1b068522-e895-428c-9def-5a1bd15cdfb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("2c51fe7a-09ed-44f6-a36e-439b044f5b5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("39be740b-9bb5-4154-981b-fc9fdee2b62a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null },
                    { new Guid("3ab10224-91d6-4bc4-b7db-efa7b45b3544"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("3bf5b096-38c5-4feb-8e91-666ea457f3dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("3d09367d-2678-4dcc-97a1-63ffbc8cd1c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("48897e69-7ffd-43f7-820f-03c5039374e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("4a7b4c4c-ea83-4912-8193-8e22f323f66d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null },
                    { new Guid("5fd62773-8ca6-4e37-862b-1e9a934b5271"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("6d673815-631d-49ad-9cfd-b48b0541a6a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("6e9e5a86-bd70-4c6a-aa7e-01e40c8fcb81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("80577fbe-bb6b-4572-b5bb-8b85ffb0ac61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("8c53d848-ee72-4043-8d55-95f357c554a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null },
                    { new Guid("a5a24afc-7693-4ab0-9454-dbab3d532b46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("b8e449ae-d4a8-4aac-b0dd-e0139d67bb4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("c68edc6a-e2b9-4f81-8abc-c35d67f6404c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("e9b32cab-4b79-4cb2-ae64-82291f5f104b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null },
                    { new Guid("f5f04550-9130-45ba-b13f-4cc4ef973fdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 255, 76, 77, 170, 133, 55, 59, 185, 237, 93, 191, 169, 130, 102, 188, 57, 185, 51, 54, 221, 170, 166, 110, 158, 255, 125, 93, 95, 91, 12, 10, 254, 120, 207, 121, 25, 253, 224, 66, 90, 144, 2, 196, 31, 233, 227, 1, 88, 226, 126, 15, 39, 194, 245, 119, 28, 1, 116, 157, 35, 56, 84, 10 }, new byte[] { 217, 185, 65, 50, 148, 249, 4, 230, 83, 61, 123, 80, 190, 194, 51, 194, 146, 107, 206, 150, 61, 241, 67, 181, 225, 250, 19, 232, 65, 81, 134, 221, 140, 13, 234, 182, 189, 70, 58, 109, 147, 222, 52, 135, 234, 26, 187, 185, 151, 80, 219, 14, 119, 162, 107, 89, 190, 210, 232, 97, 220, 255, 128, 238, 66, 102, 77, 180, 188, 56, 126, 139, 83, 80, 200, 17, 29, 180, 35, 77, 41, 161, 10, 201, 60, 69, 61, 109, 125, 85, 179, 234, 9, 163, 130, 30, 205, 116, 241, 141, 242, 150, 171, 69, 139, 58, 129, 21, 84, 52, 199, 77, 13, 187, 60, 193, 15, 176, 50, 58, 74, 90, 206, 85, 2, 96, 32, 220 } });
        }
    }
}
