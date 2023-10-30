using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ArtStyles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Prompt", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0daa5079-01c6-45e8-a2a7-49aaf264d4b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("10a73ad1-b892-4c19-8c3c-adb03dfcefa2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null },
                    { new Guid("143ccb17-fc50-472f-bf21-aefe85185214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null },
                    { new Guid("2afc2105-6eb1-447b-b037-408aeb5eef03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null },
                    { new Guid("655b6af8-c906-4c9d-a63a-5c2fb02d9dfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("85c1e881-2c3b-455c-9262-178ed4525d10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("9fc691ea-2367-4a33-a28d-db2b76afca04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null },
                    { new Guid("f47298b6-bc13-4b58-814e-56eda0ddab56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("08b4e3cf-84c5-4f48-8b5d-c99181d6f2e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null },
                    { new Guid("156c95f7-5340-4f6d-b9bc-507e172a802c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null },
                    { new Guid("2b2b39f6-35d1-41b9-9346-d0e5caebd57d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null },
                    { new Guid("4aa792cd-772a-4640-8cca-07cb9d6e5a31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null },
                    { new Guid("5570cdfd-23d5-45a8-bb35-5fe78b547afc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("698af294-3be7-47a6-9b9b-c6d5701a7a94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("72c9925d-f0eb-4694-8ed3-502d81f398a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("059c0f2d-c2a2-44bc-a9e2-0a08895cd3f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("1b0c75bb-e67e-463d-b88e-9531989fe3ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("20ca67b6-e14d-4c60-9c41-d093f8cdd07e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("21946739-b06e-4a19-9075-8a291af365d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("31f45cf1-9723-432f-a35f-8749722956d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("38185e6d-2cb9-46f4-92ba-3eb043c19abe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("4bbfb8e6-34f2-4468-bdb4-af9155e128aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("584b726e-b0f6-43cc-b796-2cc24cac7957"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("58e48f22-3262-47b2-96a0-c91c211bba6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null },
                    { new Guid("6a1106dc-a758-4c6b-9ba5-f9146f7561d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("7837b55f-731e-4625-8ee4-41e3e1532eec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("94a561b3-c408-415f-a0fa-b968e9a944f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("a084c795-f70d-42aa-a945-36b90284603f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null },
                    { new Guid("a1716fd6-a0c8-43f5-ae43-f0223d029625"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null },
                    { new Guid("a2b25a5d-9a1f-4269-a346-0cecee9fc6e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("a2f169f9-0ed3-45f1-b25e-20617ec1c65f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null },
                    { new Guid("acb703b3-99b5-4ca2-88dc-2868f6c9df9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("ccd2aa3d-f55d-4e98-8ba1-726340c58fe8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null },
                    { new Guid("ec0de4a7-646e-4b54-a4c2-f2a7e87e5920"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("f50525c6-6aa2-425e-99b1-15fe5b1078be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("fd5b6486-eb3b-467b-93d1-9677b36cfaa9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Photo" },
                values: new object[] { new byte[] { 107, 17, 172, 211, 9, 72, 89, 171, 29, 50, 171, 112, 116, 195, 235, 144, 11, 179, 15, 217, 54, 219, 162, 187, 78, 243, 185, 136, 125, 60, 237, 12, 148, 179, 165, 128, 58, 236, 8, 94, 13, 120, 125, 229, 175, 114, 97, 80, 218, 206, 60, 113, 68, 11, 44, 87, 145, 77, 108, 206, 144, 50, 246, 43 }, new byte[] { 119, 103, 75, 24, 198, 85, 6, 238, 21, 178, 60, 86, 163, 12, 88, 234, 18, 30, 172, 5, 108, 160, 92, 215, 228, 163, 68, 84, 106, 46, 196, 197, 206, 24, 32, 42, 25, 66, 25, 53, 115, 135, 12, 242, 59, 237, 2, 214, 6, 186, 22, 37, 211, 14, 61, 191, 13, 1, 79, 80, 255, 232, 214, 208, 26, 230, 50, 118, 60, 203, 13, 102, 74, 243, 170, 66, 251, 11, 130, 197, 134, 206, 216, 12, 115, 137, 124, 202, 182, 193, 231, 152, 196, 203, 132, 16, 115, 59, 242, 238, 168, 124, 90, 41, 194, 63, 168, 24, 69, 186, 104, 67, 82, 21, 244, 11, 30, 51, 126, 168, 88, 169, 38, 16, 10, 99, 50, 147 }, "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("0daa5079-01c6-45e8-a2a7-49aaf264d4b5"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("10a73ad1-b892-4c19-8c3c-adb03dfcefa2"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("143ccb17-fc50-472f-bf21-aefe85185214"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("2afc2105-6eb1-447b-b037-408aeb5eef03"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("655b6af8-c906-4c9d-a63a-5c2fb02d9dfe"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("85c1e881-2c3b-455c-9262-178ed4525d10"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("9fc691ea-2367-4a33-a28d-db2b76afca04"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("f47298b6-bc13-4b58-814e-56eda0ddab56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08b4e3cf-84c5-4f48-8b5d-c99181d6f2e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("156c95f7-5340-4f6d-b9bc-507e172a802c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b2b39f6-35d1-41b9-9346-d0e5caebd57d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4aa792cd-772a-4640-8cca-07cb9d6e5a31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5570cdfd-23d5-45a8-bb35-5fe78b547afc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("698af294-3be7-47a6-9b9b-c6d5701a7a94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72c9925d-f0eb-4694-8ed3-502d81f398a8"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("059c0f2d-c2a2-44bc-a9e2-0a08895cd3f2"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("1b0c75bb-e67e-463d-b88e-9531989fe3ac"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("20ca67b6-e14d-4c60-9c41-d093f8cdd07e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("21946739-b06e-4a19-9075-8a291af365d9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("31f45cf1-9723-432f-a35f-8749722956d7"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("38185e6d-2cb9-46f4-92ba-3eb043c19abe"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("4bbfb8e6-34f2-4468-bdb4-af9155e128aa"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("584b726e-b0f6-43cc-b796-2cc24cac7957"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("58e48f22-3262-47b2-96a0-c91c211bba6b"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6a1106dc-a758-4c6b-9ba5-f9146f7561d5"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("7837b55f-731e-4625-8ee4-41e3e1532eec"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("94a561b3-c408-415f-a0fa-b968e9a944f8"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a084c795-f70d-42aa-a945-36b90284603f"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a1716fd6-a0c8-43f5-ae43-f0223d029625"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a2b25a5d-9a1f-4269-a346-0cecee9fc6e6"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a2f169f9-0ed3-45f1-b25e-20617ec1c65f"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("acb703b3-99b5-4ca2-88dc-2868f6c9df9d"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("ccd2aa3d-f55d-4e98-8ba1-726340c58fe8"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("ec0de4a7-646e-4b54-a4c2-f2a7e87e5920"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f50525c6-6aa2-425e-99b1-15fe5b1078be"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("fd5b6486-eb3b-467b-93d1-9677b36cfaa9"));

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Users");

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
    }
}
