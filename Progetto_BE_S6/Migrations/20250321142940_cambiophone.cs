using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Progetto_BE_S6.Migrations
{
    /// <inheritdoc />
    public partial class cambiophone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("04b68353-21ea-4091-b302-a2278a734ca3"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("126b5249-bacd-48e2-81b7-727fb5f22732"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("27e4f5f3-358c-4cc7-9923-d2f09f2d078a"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("27f1ffd3-d86d-4715-8522-ac9f75033d04"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("a0e25b40-4a69-4912-b485-d1cfeeabcc47"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("a756ebbb-b05f-4985-bcf5-28e683680b80"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("aed90a20-389e-4d82-a26c-d1d8d4f7625f"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("c4b5f1f4-183c-4522-b984-6b74873be546"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("d86b6874-9a74-46d3-a80d-52a495cfbf99"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("e56cb8b7-0c61-4076-b9b4-874c034a2c7b"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("f9858fb5-a7e0-4fd4-b4ef-f81fc201a8de"));

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Clienti",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Camere",
                columns: new[] { "CameraId", "IsDisponibile", "Numero", "Prezzo", "Tipo" },
                values: new object[,]
                {
                    { new Guid("06072d4c-be28-4c4d-81fb-d2c410474f25"), true, "107", 110.00m, "Tripla" },
                    { new Guid("06a1b523-bfd2-44ca-a3cc-e77cfb427fe9"), true, "105", 70.00m, "Singola" },
                    { new Guid("68c9cf4c-b6f8-4769-8e9f-7e8a3a8c95ad"), true, "102", 90.00m, "Doppia" },
                    { new Guid("7fb7cba7-3d90-4759-8ea3-62c1d5111969"), true, "110", 90.00m, "Doppia" },
                    { new Guid("927ad9b7-a3b7-437f-9c13-beeee70f3865"), true, "108", 150.00m, "Quadrupla" },
                    { new Guid("9785cbb1-4e65-4562-b5d1-ea80e9a6c2df"), true, "101", 70.00m, "Singola" },
                    { new Guid("98d448e3-b2b9-43f4-bb5c-7be3a34d7ba2"), true, "106", 90.00m, "Doppia" },
                    { new Guid("a8c53266-a814-431e-8ea9-9bc61b12787c"), true, "104", 150.00m, "Quadrupla" },
                    { new Guid("b3019a42-1444-4d89-b5df-21128e00c3f2"), true, "103", 110.00m, "Tripla" },
                    { new Guid("b6f94d53-64a1-4ef0-b3aa-75edbfdea0e1"), true, "111", 110.00m, "Tripla" },
                    { new Guid("d1df4208-70d8-419e-816f-4364a07066f0"), true, "109", 70.00m, "Singola" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("06072d4c-be28-4c4d-81fb-d2c410474f25"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("06a1b523-bfd2-44ca-a3cc-e77cfb427fe9"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("68c9cf4c-b6f8-4769-8e9f-7e8a3a8c95ad"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("7fb7cba7-3d90-4759-8ea3-62c1d5111969"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("927ad9b7-a3b7-437f-9c13-beeee70f3865"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("9785cbb1-4e65-4562-b5d1-ea80e9a6c2df"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("98d448e3-b2b9-43f4-bb5c-7be3a34d7ba2"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("a8c53266-a814-431e-8ea9-9bc61b12787c"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("b3019a42-1444-4d89-b5df-21128e00c3f2"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("b6f94d53-64a1-4ef0-b3aa-75edbfdea0e1"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("d1df4208-70d8-419e-816f-4364a07066f0"));

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Clienti",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "Camere",
                columns: new[] { "CameraId", "IsDisponibile", "Numero", "Prezzo", "Tipo" },
                values: new object[,]
                {
                    { new Guid("04b68353-21ea-4091-b302-a2278a734ca3"), true, "110", 90.00m, "Doppia" },
                    { new Guid("126b5249-bacd-48e2-81b7-727fb5f22732"), true, "109", 70.00m, "Singola" },
                    { new Guid("27e4f5f3-358c-4cc7-9923-d2f09f2d078a"), true, "103", 110.00m, "Tripla" },
                    { new Guid("27f1ffd3-d86d-4715-8522-ac9f75033d04"), true, "106", 90.00m, "Doppia" },
                    { new Guid("a0e25b40-4a69-4912-b485-d1cfeeabcc47"), true, "107", 110.00m, "Tripla" },
                    { new Guid("a756ebbb-b05f-4985-bcf5-28e683680b80"), true, "101", 70.00m, "Singola" },
                    { new Guid("aed90a20-389e-4d82-a26c-d1d8d4f7625f"), true, "104", 150.00m, "Quadrupla" },
                    { new Guid("c4b5f1f4-183c-4522-b984-6b74873be546"), true, "102", 90.00m, "Doppia" },
                    { new Guid("d86b6874-9a74-46d3-a80d-52a495cfbf99"), true, "111", 110.00m, "Tripla" },
                    { new Guid("e56cb8b7-0c61-4076-b9b4-874c034a2c7b"), true, "108", 150.00m, "Quadrupla" },
                    { new Guid("f9858fb5-a7e0-4fd4-b4ef-f81fc201a8de"), true, "105", 70.00m, "Singola" }
                });
        }
    }
}
