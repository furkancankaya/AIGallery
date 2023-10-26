using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Images_ImageId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_ImageId",
                table: "Likes");

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("03f0f648-7957-4253-b046-0e6e7b8fc676"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("0fd6f908-4d81-4152-802d-3fa5cd34a91c"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("3df05a34-ef39-4bf3-9aba-32dff7940a94"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("4d5a7e89-8938-48d7-b7c5-c2ec6deb3d08"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("ae18c3b8-3dbc-44e5-a4ce-62a1f9e6f05b"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("df688bc9-6afb-4240-9728-143d937257d0"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("e1e5fe70-b05c-4b14-a7aa-4a3cfc5aead5"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("e9699a96-11e6-48ff-80c3-78bdcdff8f83"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36701018-ba79-486a-90de-baffff756798"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e75d12a-4228-4298-ba5f-3eb23e23e4bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65a6062d-43c6-4e54-8ce3-528f67c2a0c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3dbcefd-0e08-463a-a005-24b5b2b31b26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d188e571-db2c-4e81-9043-9d8fdc8a7363"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebfea034-6090-4297-98d8-7816b9a2b657"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1dfbfa1-b74f-48ef-9979-81d52bbf6ede"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("0159e038-15e2-4955-bf24-721af55c645e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("085f1b93-671f-4050-aa53-a40ba5d264d0"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("0f5018e7-93d4-4f69-91f2-317b8cd9fe0d"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("1efce480-5c2f-44f1-80ad-6176278af203"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("29311f1e-9e3c-489b-a5cd-044bb20717d4"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("2e2d9394-b04e-48d8-ac5a-b84b783c55ae"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("2fe5d3d7-67de-4ec4-8d1b-97ba412ee3f3"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("377f914c-b979-4d90-8085-97d4da0799ef"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("4022369a-0809-4bdf-9d9b-6dec4e265107"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("44fab0c8-f4c3-4938-ae61-571a78daebf9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("53d838ed-c75f-47c2-8493-e018055198fd"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("779927d5-63a6-4f91-be83-1503471b3eca"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("817c629e-2fea-4121-9d79-7bfa8cf3d5e5"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("857bd5d0-19f9-471d-9850-753794029d69"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8fcf4e8c-8753-4139-bb5b-485fd5c77dae"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a11dc26c-60c5-414a-a468-ea4bc20ccbd1"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("dd34c29c-e2d3-4a1e-866a-68842d1f6878"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("e221b065-1b16-4a3b-81db-e5946651ead9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("eba1612a-4afc-46d7-b423-2137d32b5adf"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f6078b8f-7512-44d4-952f-6841296285a7"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("ff7d481b-bfe8-41f3-bdef-221a3cef3d8c"));

            migrationBuilder.CreateTable(
                name: "ImageLike",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LikeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLike", x => new { x.ImageId, x.LikeId });
                    table.ForeignKey(
                        name: "FK_ImageLike_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageLike_Likes_LikeId",
                        column: x => x.LikeId,
                        principalTable: "Likes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArtStyles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Prompt", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0634dc38-42da-41d7-a4fb-4e472afecc4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("2477e786-7b39-46f6-a596-42f18a50e256"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("2e276226-2a3b-4e4c-a5e9-0ad627ec62b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("3e1762df-ad45-43e0-9dc4-16a05ac3b321"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null },
                    { new Guid("4189ff58-2917-4dcf-8b34-f98e3aa5cdf0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null },
                    { new Guid("6a212d61-79d9-4988-954f-b95ea765eed8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null },
                    { new Guid("9c360ca3-02b1-4870-a40e-e87cd95391c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null },
                    { new Guid("e822a86f-f2c4-4562-912a-b5d41d07df93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("09bd8497-ce12-4ad2-94d0-f2692937abaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null },
                    { new Guid("455c74a4-63e9-48c3-b52c-a7b81733168d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null },
                    { new Guid("7311b2bf-cfff-4f12-9f01-b314570c7874"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null },
                    { new Guid("8eb3df47-3ba6-478a-8dad-fdeae4d889f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null },
                    { new Guid("c172d687-17e1-426a-8e74-df191494a072"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("c296f8ae-a5a5-417c-9793-d6b8d233dcfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("f692c90d-0e7a-4142-a022-5f742b9d95ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("282d4565-27db-455e-8a64-e6a14283cd91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null },
                    { new Guid("2ae558d4-d2d5-4e5f-8fe5-0ad51bbcc90f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("2dccce32-4e0b-45ce-adf7-4d58520825a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null },
                    { new Guid("6920214a-b31f-47f4-b634-f98e2b4ffa54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null },
                    { new Guid("6fd15dec-df45-4fa5-a4a3-e7246e155db9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("78278637-4de0-4274-9491-4eeea5d567a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("86f6fd98-694a-44f6-95b4-2e9adc640d97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("8c14b97b-d5ed-4bc6-800b-d14273c15c80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("8d1bdcdd-bda4-4b40-b748-19de3f069c91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("a7ec947f-f29b-40d0-8dba-a32bf1d42bf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("af640753-3656-4d58-a4f8-6fac01ac0020"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("b7d3eba5-ad26-42d6-8a97-a73c688fd316"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null },
                    { new Guid("b8c1cd54-f849-41ce-83da-95b4eea64487"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("c1366707-686d-4d91-8f98-6c4d478edceb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("c5025be7-a1c9-4160-bbac-077a11f4ee2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("c8b90ca6-a567-4726-9ce5-3f3660d82af5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("de4fe841-b68d-4b0c-9903-74823db6279a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null },
                    { new Guid("e10ed0eb-bbf1-4bbf-99c4-c45b5ea8d25f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("e9aad59e-35de-4d64-93e5-5be2752ab4e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("ec8f3377-ae1d-404e-9ea5-84f773937ef5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("f026d37b-d488-4ff4-af8c-5ee5d74e2317"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 183, 198, 91, 215, 34, 231, 96, 122, 188, 234, 138, 203, 161, 40, 134, 7, 206, 87, 230, 31, 255, 97, 104, 187, 129, 184, 26, 96, 210, 59, 79, 188, 87, 92, 29, 39, 190, 24, 113, 106, 117, 4, 72, 177, 205, 91, 109, 58, 40, 111, 161, 201, 154, 51, 169, 139, 169, 141, 205, 44, 106, 126, 251 }, new byte[] { 53, 225, 193, 55, 60, 45, 194, 82, 132, 246, 181, 174, 210, 156, 115, 76, 155, 60, 186, 0, 50, 208, 202, 125, 56, 135, 108, 167, 135, 205, 240, 210, 96, 218, 171, 153, 170, 154, 251, 4, 21, 91, 113, 72, 62, 147, 153, 255, 40, 18, 242, 58, 57, 205, 9, 108, 120, 66, 249, 27, 171, 130, 220, 117, 190, 81, 86, 107, 49, 71, 39, 164, 140, 38, 27, 96, 27, 196, 207, 144, 79, 207, 19, 11, 161, 207, 192, 83, 31, 199, 231, 122, 68, 229, 18, 207, 220, 27, 88, 201, 103, 162, 191, 212, 63, 95, 214, 126, 54, 96, 44, 183, 239, 3, 211, 80, 28, 115, 51, 23, 55, 101, 157, 141, 161, 32, 113, 104 } });

            migrationBuilder.CreateIndex(
                name: "IX_ImageLike_LikeId",
                table: "ImageLike",
                column: "LikeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageLike");

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("0634dc38-42da-41d7-a4fb-4e472afecc4f"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("2477e786-7b39-46f6-a596-42f18a50e256"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("2e276226-2a3b-4e4c-a5e9-0ad627ec62b8"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("3e1762df-ad45-43e0-9dc4-16a05ac3b321"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("4189ff58-2917-4dcf-8b34-f98e3aa5cdf0"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("6a212d61-79d9-4988-954f-b95ea765eed8"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("9c360ca3-02b1-4870-a40e-e87cd95391c2"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("e822a86f-f2c4-4562-912a-b5d41d07df93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09bd8497-ce12-4ad2-94d0-f2692937abaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("455c74a4-63e9-48c3-b52c-a7b81733168d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7311b2bf-cfff-4f12-9f01-b314570c7874"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eb3df47-3ba6-478a-8dad-fdeae4d889f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c172d687-17e1-426a-8e74-df191494a072"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c296f8ae-a5a5-417c-9793-d6b8d233dcfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f692c90d-0e7a-4142-a022-5f742b9d95ff"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("282d4565-27db-455e-8a64-e6a14283cd91"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("2ae558d4-d2d5-4e5f-8fe5-0ad51bbcc90f"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("2dccce32-4e0b-45ce-adf7-4d58520825a5"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6920214a-b31f-47f4-b634-f98e2b4ffa54"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6fd15dec-df45-4fa5-a4a3-e7246e155db9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("78278637-4de0-4274-9491-4eeea5d567a3"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("86f6fd98-694a-44f6-95b4-2e9adc640d97"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8c14b97b-d5ed-4bc6-800b-d14273c15c80"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8d1bdcdd-bda4-4b40-b748-19de3f069c91"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a7ec947f-f29b-40d0-8dba-a32bf1d42bf1"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("af640753-3656-4d58-a4f8-6fac01ac0020"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("b7d3eba5-ad26-42d6-8a97-a73c688fd316"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("b8c1cd54-f849-41ce-83da-95b4eea64487"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c1366707-686d-4d91-8f98-6c4d478edceb"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c5025be7-a1c9-4160-bbac-077a11f4ee2a"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c8b90ca6-a567-4726-9ce5-3f3660d82af5"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("de4fe841-b68d-4b0c-9903-74823db6279a"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("e10ed0eb-bbf1-4bbf-99c4-c45b5ea8d25f"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("e9aad59e-35de-4d64-93e5-5be2752ab4e9"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("ec8f3377-ae1d-404e-9ea5-84f773937ef5"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f026d37b-d488-4ff4-af8c-5ee5d74e2317"));

            migrationBuilder.InsertData(
                table: "ArtStyles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Prompt", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("03f0f648-7957-4253-b046-0e6e7b8fc676"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null },
                    { new Guid("0fd6f908-4d81-4152-802d-3fa5cd34a91c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null },
                    { new Guid("3df05a34-ef39-4bf3-9aba-32dff7940a94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("4d5a7e89-8938-48d7-b7c5-c2ec6deb3d08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("ae18c3b8-3dbc-44e5-a4ce-62a1f9e6f05b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null },
                    { new Guid("df688bc9-6afb-4240-9728-143d937257d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("e1e5fe70-b05c-4b14-a7aa-4a3cfc5aead5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null },
                    { new Guid("e9699a96-11e6-48ff-80c3-78bdcdff8f83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("36701018-ba79-486a-90de-baffff756798"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null },
                    { new Guid("3e75d12a-4228-4298-ba5f-3eb23e23e4bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null },
                    { new Guid("65a6062d-43c6-4e54-8ce3-528f67c2a0c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("a3dbcefd-0e08-463a-a005-24b5b2b31b26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null },
                    { new Guid("d188e571-db2c-4e81-9043-9d8fdc8a7363"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null },
                    { new Guid("ebfea034-6090-4297-98d8-7816b9a2b657"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("f1dfbfa1-b74f-48ef-9979-81d52bbf6ede"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0159e038-15e2-4955-bf24-721af55c645e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("085f1b93-671f-4050-aa53-a40ba5d264d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null },
                    { new Guid("0f5018e7-93d4-4f69-91f2-317b8cd9fe0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null },
                    { new Guid("1efce480-5c2f-44f1-80ad-6176278af203"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("29311f1e-9e3c-489b-a5cd-044bb20717d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null },
                    { new Guid("2e2d9394-b04e-48d8-ac5a-b84b783c55ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("2fe5d3d7-67de-4ec4-8d1b-97ba412ee3f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("377f914c-b979-4d90-8085-97d4da0799ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("4022369a-0809-4bdf-9d9b-6dec4e265107"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null },
                    { new Guid("44fab0c8-f4c3-4938-ae61-571a78daebf9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("53d838ed-c75f-47c2-8493-e018055198fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("779927d5-63a6-4f91-be83-1503471b3eca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("817c629e-2fea-4121-9d79-7bfa8cf3d5e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("857bd5d0-19f9-471d-9850-753794029d69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("8fcf4e8c-8753-4139-bb5b-485fd5c77dae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null },
                    { new Guid("a11dc26c-60c5-414a-a468-ea4bc20ccbd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("dd34c29c-e2d3-4a1e-866a-68842d1f6878"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("e221b065-1b16-4a3b-81db-e5946651ead9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("eba1612a-4afc-46d7-b423-2137d32b5adf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("f6078b8f-7512-44d4-952f-6841296285a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("ff7d481b-bfe8-41f3-bdef-221a3cef3d8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 132, 231, 100, 31, 73, 243, 224, 206, 73, 26, 113, 138, 12, 135, 170, 65, 55, 146, 225, 57, 219, 46, 2, 6, 235, 126, 29, 77, 137, 17, 85, 248, 153, 125, 10, 98, 82, 137, 190, 48, 220, 121, 195, 222, 113, 41, 79, 181, 102, 98, 51, 172, 31, 22, 33, 61, 131, 140, 69, 54, 205, 137, 200 }, new byte[] { 234, 133, 1, 211, 53, 37, 190, 18, 32, 209, 6, 122, 141, 243, 193, 14, 89, 207, 176, 170, 243, 162, 134, 223, 182, 233, 244, 158, 215, 77, 212, 145, 208, 8, 155, 207, 6, 232, 184, 231, 185, 57, 38, 51, 97, 175, 242, 174, 48, 78, 118, 185, 15, 11, 132, 96, 15, 55, 212, 225, 131, 206, 120, 35, 105, 231, 226, 210, 33, 206, 209, 21, 187, 61, 174, 185, 173, 113, 189, 7, 87, 203, 170, 111, 82, 105, 79, 188, 100, 103, 143, 46, 77, 128, 238, 243, 49, 117, 126, 70, 86, 149, 164, 232, 191, 207, 175, 89, 91, 221, 179, 64, 150, 171, 7, 82, 210, 69, 171, 77, 28, 153, 74, 193, 156, 51, 51, 207 } });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ImageId",
                table: "Likes",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Images_ImageId",
                table: "Likes",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
