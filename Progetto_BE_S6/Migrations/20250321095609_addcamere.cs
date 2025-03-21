using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Progetto_BE_S6.Migrations
{
    /// <inheritdoc />
    public partial class addcamere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Camera",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Camera",
                columns: new[] { "CameraId", "IsDisponibile", "Numero", "Prezzo", "Tipo" },
                values: new object[,]
                {
                    { new Guid("37241cf4-f846-46fc-bcd0-87176f5f03b5"), true, "106", 90.00m, "Doppia" },
                    { new Guid("4c7a6e1a-bf7c-47b0-adad-fd6b745aacac"), true, "105", 70.00m, "Singola" },
                    { new Guid("73054329-4d2c-485a-9fb3-38924288d4e3"), true, "101", 70.00m, "Singola" },
                    { new Guid("7aa8a66e-ae03-43bc-9511-3f78c54a8355"), true, "109", 70.00m, "Singola" },
                    { new Guid("861085c0-84f4-4d25-b6c8-4deb85b7876a"), true, "102", 90.00m, "Doppia" },
                    { new Guid("8d23b43a-d9ad-46c6-95ba-a13cfc19bb75"), true, "108", 150.00m, "Quadrupla" },
                    { new Guid("b015eb82-0a5b-4f2d-919a-3bba9399ef78"), true, "110", 90.00m, "Doppia" },
                    { new Guid("c419c24c-3aed-4418-8c4a-9c9b9a5df549"), true, "103", 110.00m, "Tripla" },
                    { new Guid("dd5b9e01-19a8-465d-8f7d-6768a33699c2"), true, "111", 110.00m, "Tripla" },
                    { new Guid("e68e57bc-e586-4d0c-a086-db754f35866f"), true, "104", 150.00m, "Quadrupla" },
                    { new Guid("e7e360d5-9e00-4d0c-aa08-1f9cc8b49c48"), true, "107", 110.00m, "Tripla" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("37241cf4-f846-46fc-bcd0-87176f5f03b5"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("4c7a6e1a-bf7c-47b0-adad-fd6b745aacac"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("73054329-4d2c-485a-9fb3-38924288d4e3"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("7aa8a66e-ae03-43bc-9511-3f78c54a8355"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("861085c0-84f4-4d25-b6c8-4deb85b7876a"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("8d23b43a-d9ad-46c6-95ba-a13cfc19bb75"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("b015eb82-0a5b-4f2d-919a-3bba9399ef78"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("c419c24c-3aed-4418-8c4a-9c9b9a5df549"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("dd5b9e01-19a8-465d-8f7d-6768a33699c2"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("e68e57bc-e586-4d0c-a086-db754f35866f"));

            migrationBuilder.DeleteData(
                table: "Camera",
                keyColumn: "CameraId",
                keyValue: new Guid("e7e360d5-9e00-4d0c-aa08-1f9cc8b49c48"));

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Camera",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
