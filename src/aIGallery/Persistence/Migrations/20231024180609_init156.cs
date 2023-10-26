using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init156 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageLike");

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
                    { new Guid("41a9647f-4c6b-4eb6-b51a-23286cbeaedf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (4).png", "Beauty", "Beauty", 0, null },
                    { new Guid("43ba0ab7-cb94-4baf-994d-63fd2e140ba7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (8).png", "Magical", "Magical", 0, null },
                    { new Guid("4c41dc63-3af9-4338-a878-80b6ea77da99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (2).png", "Anime", "Anime", 0, null },
                    { new Guid("806d209a-f694-45a4-9dee-b4ee8a176a45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (5).png", "Pencil Art", "Pencil Art", 0, null },
                    { new Guid("96e1afab-3f79-4947-bc21-04ca28593120"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (7).png", "Characters", "Characters", 0, null },
                    { new Guid("ab8cf470-1b6f-499b-a1e0-b7247b735ee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (6).png", "Neon", "Neon", 0, null },
                    { new Guid("d9f3b980-e45f-4911-9559-77b9265d2d78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (1).png", "Realistic", "Realistic", 0, null },
                    { new Guid("e42cb429-f02f-4a05-8736-62c3e656002f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storagez.aiart.limited/app/realai/generated/fab123 (3).png", "Digital Art", "Digital Art", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Logo", "Name", "Sort", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1817a1a1-d1ee-4dea-82ee-46cc759f4b23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/5pA66bWhH.png", "Music", 0, null },
                    { new Guid("3286434b-85f4-4115-83f2-940578d2f808"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/i2LlVn3AC.png", "Space", 0, null },
                    { new Guid("7adc89be-1318-439e-9768-b08f8b86d955"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/MO32CXfmz.png", "Logos", 0, null },
                    { new Guid("936752dd-d745-493a-a98a-54f8df67305b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/zqBEZVjuO.png", "Animals", 0, null },
                    { new Guid("b72f69b6-15b9-4041-aa90-f299001935bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/h9xJfxLyJ.png", "Funny", 0, null },
                    { new Guid("cc12df89-1d47-4344-80f7-dfbb135cada4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/yTddOHaqG.png", "Games", 0, null },
                    { new Guid("fe52206b-46e3-4ad5-a686-99dd13ad1cf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://storages.aiart.limited/app/realai/generated/vcP7Viv7R.png", "Anime", 0, null }
                });

            migrationBuilder.InsertData(
                table: "PreparedPrompts",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Gender", "Logo", "Name", "Prompt", "Sort", "TextToImage", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17cbbe36-75e7-48a4-b560-198eece45cbd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/0 (4).jpg", "Neat Curly Quiff", "Neat Curly Quiff", 0, false, null },
                    { new Guid("24f7a4f7-5141-4b30-a55f-41201317face"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, " in space", "Male astronaut", "Male astronaut", 0, true, null },
                    { new Guid("329c6e55-7fa2-4ff8-a58c-3ba670d4da80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/harly.jpg", "Harley Quinn", "Harley Quinn", 0, false, null },
                    { new Guid("3496fa36-699d-427e-a6a4-ba8ff4455d22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3.jpg", "ironman 4k musculer", "ironman 4k musculer", 0, true, null },
                    { new Guid("3ce85dbb-5457-48bc-a3b7-8338e6e48e95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/cris (2).jpg", "Chris Evans", "Chris Evans", 0, false, null },
                    { new Guid("41966764-2182-4981-9b5b-bce9a6610360"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/tanga.jpg", "Daenerys Targaryen", "Daenerys Targaryen", 0, false, null },
                    { new Guid("4862ea92-ad81-4d2e-83db-89859d367570"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/14.jpg", "A cairn terrier dog as the doomslayer", "A cairn terrier dog as the doomslayer", 0, true, null },
                    { new Guid("53e4b80d-a8b9-4ce5-b38d-b4821c8bcda4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/angelina.jpg", "Angelina Jolie", "Angelina Jolie", 0, false, null },
                    { new Guid("577ee5cc-f4d6-443e-ba33-27b57f7fb534"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/0amber.jpg", "Amber Heard", "Amber Heard", 0, false, null },
                    { new Guid("64ab8ec5-76cf-49e2-93be-042c206ca112"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/1 (1).jpg", "Superman", "Superman", 0, false, null },
                    { new Guid("a486b9c6-5c0f-408e-81f4-d59a1ce8aabb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/2 (2).jpg", "Soldier", "Soldier", 0, false, null },
                    { new Guid("b5e95b0c-3a46-4602-908c-907dde77902b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/3 (4).jpg", "Keanu Reeves", "Keanu Reeves", 0, false, null },
                    { new Guid("c3015e19-05eb-4dfa-9224-542197ed2855"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/18.jpg", "A cute adorable phoenix", "A cute adorable phoenix", 0, true, null },
                    { new Guid("c5de37e1-cde8-4e8d-8d0f-0e786cc8ba08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/capt.jpg", "Captain America", "Captain America", 0, false, null },
                    { new Guid("c6b8e4fe-80bd-4448-91fc-f9860d8c285c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/13.jpg", "Azure female viking warrior", "Azure female viking warrior", 0, true, null },
                    { new Guid("d5fd2352-45e9-4d02-8f4c-112ecd1445fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/brr.jpg", "Brad Pitt", "Brad Pitt", 0, false, null },
                    { new Guid("db7336af-90fd-4902-bd00-386d38c0e28c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/011.jpg", "Evening Dresses", "Evening Dresses", 0, false, null },
                    { new Guid("dfb457f1-a651-4ce8-aea4-e9a54d27aa34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/4.jpg", "platinum short hair playboy model", "platinum short hair playboy model", 0, true, null },
                    { new Guid("ed8b9223-ff4b-4bf4-a8c1-6149040bf4e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/kardas.jpg", "Kim Kardashian", "Kim Kardashian", 0, false, null },
                    { new Guid("f91928b0-da67-4b19-9a06-81ec19597873"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "https://storages.aiart.limited/app/realai/generated/platin.jpg", "Platinum Short", "Platinum Short", 0, false, null },
                    { new Guid("fa583dff-c0f0-45a6-b893-74a8bb1aca2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "https://storages.aiart.limited/app/realai/generated/15.jpg", "A bird pokemon with horns and 4 wings", "A bird pokemon with horns and 4 wings", 0, true, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 52, 244, 229, 62, 144, 103, 83, 101, 189, 223, 154, 77, 108, 47, 23, 243, 26, 51, 155, 186, 109, 82, 166, 190, 107, 60, 141, 110, 181, 221, 215, 226, 106, 151, 243, 30, 165, 199, 129, 9, 103, 61, 237, 244, 15, 215, 121, 104, 98, 253, 13, 59, 55, 69, 65, 205, 160, 220, 13, 187, 225, 162, 121, 55 }, new byte[] { 251, 5, 3, 240, 42, 195, 155, 160, 223, 159, 48, 43, 91, 16, 222, 128, 218, 165, 203, 94, 183, 96, 236, 75, 250, 69, 38, 3, 20, 96, 135, 95, 65, 57, 89, 155, 2, 224, 111, 12, 110, 54, 184, 193, 105, 152, 94, 78, 139, 167, 83, 242, 166, 206, 198, 143, 134, 79, 132, 127, 187, 138, 241, 190, 166, 65, 75, 79, 177, 191, 117, 82, 55, 72, 2, 54, 247, 127, 36, 181, 5, 25, 175, 238, 86, 10, 151, 168, 77, 3, 86, 214, 123, 53, 216, 68, 109, 74, 102, 49, 31, 3, 54, 169, 122, 55, 8, 236, 38, 225, 129, 171, 178, 87, 34, 14, 65, 150, 232, 172, 67, 46, 37, 163, 134, 253, 97, 177 } });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("41a9647f-4c6b-4eb6-b51a-23286cbeaedf"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("43ba0ab7-cb94-4baf-994d-63fd2e140ba7"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("4c41dc63-3af9-4338-a878-80b6ea77da99"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("806d209a-f694-45a4-9dee-b4ee8a176a45"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("96e1afab-3f79-4947-bc21-04ca28593120"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("ab8cf470-1b6f-499b-a1e0-b7247b735ee0"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("d9f3b980-e45f-4911-9559-77b9265d2d78"));

            migrationBuilder.DeleteData(
                table: "ArtStyles",
                keyColumn: "Id",
                keyValue: new Guid("e42cb429-f02f-4a05-8736-62c3e656002f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1817a1a1-d1ee-4dea-82ee-46cc759f4b23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3286434b-85f4-4115-83f2-940578d2f808"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7adc89be-1318-439e-9768-b08f8b86d955"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("936752dd-d745-493a-a98a-54f8df67305b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b72f69b6-15b9-4041-aa90-f299001935bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc12df89-1d47-4344-80f7-dfbb135cada4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe52206b-46e3-4ad5-a686-99dd13ad1cf8"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("17cbbe36-75e7-48a4-b560-198eece45cbd"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("24f7a4f7-5141-4b30-a55f-41201317face"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("329c6e55-7fa2-4ff8-a58c-3ba670d4da80"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("3496fa36-699d-427e-a6a4-ba8ff4455d22"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("3ce85dbb-5457-48bc-a3b7-8338e6e48e95"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("41966764-2182-4981-9b5b-bce9a6610360"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("4862ea92-ad81-4d2e-83db-89859d367570"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("53e4b80d-a8b9-4ce5-b38d-b4821c8bcda4"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("577ee5cc-f4d6-443e-ba33-27b57f7fb534"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("64ab8ec5-76cf-49e2-93be-042c206ca112"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("a486b9c6-5c0f-408e-81f4-d59a1ce8aabb"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("b5e95b0c-3a46-4602-908c-907dde77902b"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c3015e19-05eb-4dfa-9224-542197ed2855"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c5de37e1-cde8-4e8d-8d0f-0e786cc8ba08"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("c6b8e4fe-80bd-4448-91fc-f9860d8c285c"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("d5fd2352-45e9-4d02-8f4c-112ecd1445fb"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("db7336af-90fd-4902-bd00-386d38c0e28c"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("dfb457f1-a651-4ce8-aea4-e9a54d27aa34"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("ed8b9223-ff4b-4bf4-a8c1-6149040bf4e3"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("f91928b0-da67-4b19-9a06-81ec19597873"));

            migrationBuilder.DeleteData(
                table: "PreparedPrompts",
                keyColumn: "Id",
                keyValue: new Guid("fa583dff-c0f0-45a6-b893-74a8bb1aca2f"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ImageLike_LikeId",
                table: "ImageLike",
                column: "LikeId");
        }
    }
}
