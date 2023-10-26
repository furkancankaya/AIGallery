using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("06e72cac-5aa1-4815-8646-40c311fbed8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null },
                    { new Guid("123aa5ee-3735-4619-875a-67276e76d963"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("2597fc6c-8828-4d73-9f83-5f6f3645b2bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("2e458998-7248-4c3b-819d-570028917961"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("31d53fea-d7e3-4283-9a69-15849c3bfa44"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null },
                    { new Guid("51693359-4c34-4ef9-a051-53b67ab01387"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null },
                    { new Guid("9c49ed3e-8484-4599-be4e-df2edcb59d35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null },
                    { new Guid("e5fdc7dc-1368-4452-b310-36dc357b0957"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1645c01e-49b0-4862-a27a-6f4d15066517"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null },
                    { new Guid("1795d3c7-3873-4331-bc9c-4d18c203883d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("5ac0298e-bde6-4338-a4df-0d257916a4e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null },
                    { new Guid("a7c76024-3392-4c46-9aa7-e3f7f9326964"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null },
                    { new Guid("ab0fc7b5-5b40-4f94-ad34-169ca7528114"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("afd7bd94-7666-44ae-9d15-3891b455dbdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null },
                    { new Guid("f7e9230d-4c19-4631-85fc-e36418b711bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("130a5419-29c3-49ae-a8c3-81a7386c79aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null },
                    { new Guid("24cf97d1-bef8-418c-8665-810caf5bfc48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("373dbc89-16c0-49eb-867b-339c1e98953e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null },
                    { new Guid("68e7720d-626b-42a8-9497-cee58788ef1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("6ca7803a-87a9-4677-9ffe-1c985500f122"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("7bb0a40b-db95-407c-a741-d7840941e3cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("8c5bf0b7-2c38-4181-8667-4b6e65fe3e1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("8dcd766c-28ce-4e95-b2d8-f5430522a436"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("959dd38f-63c9-4394-8338-5366d952d1b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null },
                    { new Guid("999cf2b2-d48f-43f1-961c-be31e82d4007"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("a8498966-e33a-4e6f-97a3-cbf2e4056b03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("af875441-796b-49c5-96ce-0ecc24728e8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null },
                    { new Guid("b2baa70e-8855-465d-94f1-b7748bfcfbf7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("dc2dad6e-e8af-4895-bba5-7d2e4af00c89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("e592803f-8f72-4ae4-9ca0-bfefaf2842f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("e9e233f5-9983-4a3e-991d-c2bb006d2fc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("f2557051-0a31-46c9-9990-928f0303d526"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("f6f9586f-cae9-48f0-a155-7b55a49d1051"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("f927bcd3-ecb7-4c34-a95a-def8d7cd9d1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("fa1f3b21-5371-4147-97b5-641f681cc91e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null },
                    { new Guid("fd6bbc2a-f09e-4353-8e95-e67a784e491a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 98, 133, 205, 206, 244, 58, 9, 199, 71, 19, 232, 244, 233, 209, 155, 164, 161, 146, 199, 200, 134, 220, 33, 225, 250, 188, 202, 34, 101, 175, 82, 180, 170, 189, 206, 138, 187, 1, 142, 112, 130, 68, 103, 42, 113, 54, 212, 193, 48, 252, 136, 91, 48, 54, 89, 146, 176, 108, 172, 238, 93, 42, 25 }, new byte[] { 37, 223, 91, 59, 47, 114, 106, 65, 16, 44, 207, 78, 135, 182, 50, 151, 28, 170, 183, 73, 204, 97, 229, 133, 92, 211, 106, 172, 56, 70, 72, 14, 254, 180, 141, 244, 249, 168, 146, 204, 249, 122, 73, 241, 8, 95, 107, 34, 221, 72, 227, 113, 254, 241, 56, 141, 207, 48, 169, 40, 28, 126, 219, 42, 204, 101, 39, 52, 171, 0, 118, 119, 91, 52, 45, 102, 198, 193, 108, 89, 143, 73, 60, 62, 162, 112, 49, 157, 172, 173, 218, 156, 170, 84, 14, 245, 17, 132, 215, 168, 205, 223, 53, 133, 177, 90, 224, 73, 179, 40, 143, 126, 214, 178, 221, 11, 24, 217, 98, 216, 30, 118, 65, 140, 2, 177, 141, 131 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("06e72cac-5aa1-4815-8646-40c311fbed8c"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("123aa5ee-3735-4619-875a-67276e76d963"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("2597fc6c-8828-4d73-9f83-5f6f3645b2bb"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("2e458998-7248-4c3b-819d-570028917961"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("31d53fea-d7e3-4283-9a69-15849c3bfa44"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("51693359-4c34-4ef9-a051-53b67ab01387"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("9c49ed3e-8484-4599-be4e-df2edcb59d35"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("e5fdc7dc-1368-4452-b310-36dc357b0957"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1645c01e-49b0-4862-a27a-6f4d15066517"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1795d3c7-3873-4331-bc9c-4d18c203883d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ac0298e-bde6-4338-a4df-0d257916a4e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7c76024-3392-4c46-9aa7-e3f7f9326964"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab0fc7b5-5b40-4f94-ad34-169ca7528114"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afd7bd94-7666-44ae-9d15-3891b455dbdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7e9230d-4c19-4631-85fc-e36418b711bb"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("130a5419-29c3-49ae-a8c3-81a7386c79aa"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("24cf97d1-bef8-418c-8665-810caf5bfc48"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("373dbc89-16c0-49eb-867b-339c1e98953e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("68e7720d-626b-42a8-9497-cee58788ef1d"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("6ca7803a-87a9-4677-9ffe-1c985500f122"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("7bb0a40b-db95-407c-a741-d7840941e3cd"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8c5bf0b7-2c38-4181-8667-4b6e65fe3e1e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("8dcd766c-28ce-4e95-b2d8-f5430522a436"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("959dd38f-63c9-4394-8338-5366d952d1b4"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("999cf2b2-d48f-43f1-961c-be31e82d4007"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a8498966-e33a-4e6f-97a3-cbf2e4056b03"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("af875441-796b-49c5-96ce-0ecc24728e8e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("b2baa70e-8855-465d-94f1-b7748bfcfbf7"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("dc2dad6e-e8af-4895-bba5-7d2e4af00c89"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("e592803f-8f72-4ae4-9ca0-bfefaf2842f0"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("e9e233f5-9983-4a3e-991d-c2bb006d2fc8"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f2557051-0a31-46c9-9990-928f0303d526"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f6f9586f-cae9-48f0-a155-7b55a49d1051"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f927bcd3-ecb7-4c34-a95a-def8d7cd9d1e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("fa1f3b21-5371-4147-97b5-641f681cc91e"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("fd6bbc2a-f09e-4353-8e95-e67a784e491a"));

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
        }
    }
}
