using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addproandtoken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pros_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TokenHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TokenHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pros.Admin", null },
                    { 165, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pros.Read", null },
                    { 166, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pros.Write", null },
                    { 167, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pros.Add", null },
                    { 168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pros.Update", null },
                    { 169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pros.Delete", null },
                    { 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TokenHistories.Admin", null },
                    { 171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TokenHistories.Read", null },
                    { 172, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TokenHistories.Write", null },
                    { 173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TokenHistories.Add", null },
                    { 174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TokenHistories.Update", null },
                    { 175, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TokenHistories.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PasswordHash", "PasswordSalt" },
                values: new object[] { "husok99@mail.com", new byte[] { 181, 84, 200, 68, 20, 135, 133, 171, 206, 101, 246, 109, 129, 81, 2, 133, 173, 21, 191, 18, 227, 31, 106, 30, 223, 139, 240, 132, 147, 211, 54, 188, 195, 204, 71, 251, 165, 123, 174, 8, 171, 175, 142, 167, 95, 132, 237, 90, 131, 23, 167, 215, 219, 189, 100, 73, 173, 232, 150, 178, 28, 2, 95, 206 }, new byte[] { 239, 9, 134, 231, 31, 53, 1, 190, 15, 243, 96, 63, 176, 254, 201, 208, 85, 16, 241, 28, 161, 166, 177, 147, 236, 11, 140, 199, 56, 59, 79, 46, 97, 152, 18, 126, 114, 250, 211, 168, 176, 32, 50, 148, 64, 15, 229, 217, 109, 25, 182, 172, 83, 249, 168, 8, 13, 168, 102, 221, 81, 207, 63, 118, 27, 13, 206, 189, 89, 20, 158, 132, 4, 32, 203, 54, 28, 217, 226, 167, 28, 12, 93, 185, 163, 100, 161, 8, 68, 160, 30, 255, 205, 36, 93, 183, 240, 92, 156, 22, 93, 123, 140, 246, 111, 225, 253, 34, 80, 182, 93, 208, 97, 7, 67, 156, 28, 234, 90, 13, 19, 49, 209, 239, 216, 25, 75, 77 } });

            migrationBuilder.CreateIndex(
                name: "IX_Pros_UserId",
                table: "Pros",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TokenHistories_UserId",
                table: "TokenHistories",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pros");

            migrationBuilder.DropTable(
                name: "TokenHistories");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PasswordHash", "PasswordSalt" },
                values: new object[] { "admin@admin.com", new byte[] { 76, 32, 152, 22, 205, 43, 220, 188, 243, 57, 11, 161, 119, 133, 151, 86, 179, 71, 176, 67, 70, 165, 63, 101, 78, 35, 6, 185, 201, 212, 1, 138, 43, 97, 139, 53, 174, 61, 22, 81, 160, 94, 197, 99, 94, 64, 239, 232, 177, 49, 108, 211, 216, 248, 223, 148, 254, 217, 118, 228, 174, 99, 203, 36 }, new byte[] { 119, 236, 250, 199, 57, 190, 217, 170, 71, 201, 254, 56, 221, 97, 147, 191, 200, 166, 5, 218, 254, 105, 249, 117, 71, 130, 1, 170, 37, 142, 28, 233, 159, 156, 253, 38, 33, 25, 79, 4, 10, 156, 246, 232, 107, 150, 2, 236, 154, 244, 55, 74, 148, 245, 172, 124, 38, 167, 247, 7, 227, 107, 78, 66, 123, 151, 205, 186, 152, 176, 177, 182, 170, 7, 30, 185, 28, 47, 34, 206, 216, 171, 212, 228, 10, 117, 9, 49, 212, 25, 30, 67, 158, 62, 111, 114, 130, 24, 195, 195, 196, 206, 151, 36, 88, 83, 219, 192, 172, 255, 90, 63, 228, 130, 255, 16, 69, 26, 107, 158, 184, 89, 244, 181, 189, 243, 49, 196 } });
        }
    }
}
