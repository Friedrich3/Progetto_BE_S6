using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Progetto_BE_S6.Migrations
{
    /// <inheritdoc />
    public partial class ennesima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Camere",
                columns: new[] { "CameraId", "IsDisponibile", "Numero", "Prezzo", "Tipo" },
                values: new object[,]
                {
                    { new Guid("217f91f5-8438-4016-8d67-a103f5136ce3"), true, "108", 150.00m, "Quadrupla" },
                    { new Guid("571008fc-819e-4da8-a661-a11b408bf279"), true, "102", 90.00m, "Doppia" },
                    { new Guid("800b248b-8e60-4e2c-913f-8dad476b1d3d"), true, "107", 110.00m, "Tripla" },
                    { new Guid("8703b42f-db9d-4263-beec-d06f3a508a8d"), true, "109", 70.00m, "Singola" },
                    { new Guid("a8b83bea-cb37-49cc-a6d8-047f65da58c1"), true, "110", 90.00m, "Doppia" },
                    { new Guid("b258b2d3-1f44-47bf-b856-3635bb7abaa4"), true, "105", 70.00m, "Singola" },
                    { new Guid("b436a40c-3851-4069-a84e-6fce0a8ed44e"), true, "103", 110.00m, "Tripla" },
                    { new Guid("bac778e8-7abe-4f4b-a188-a923d5711b72"), true, "111", 110.00m, "Tripla" },
                    { new Guid("d13caafb-b17a-4f1e-a5aa-aa3b73917716"), true, "106", 90.00m, "Doppia" },
                    { new Guid("dd384496-30e9-422e-9a54-ab7ddab2bee9"), true, "104", 150.00m, "Quadrupla" },
                    { new Guid("ddcdc003-36f0-47fe-9f42-18ca8e1237d6"), true, "101", 70.00m, "Singola" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("217f91f5-8438-4016-8d67-a103f5136ce3"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("571008fc-819e-4da8-a661-a11b408bf279"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("800b248b-8e60-4e2c-913f-8dad476b1d3d"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("8703b42f-db9d-4263-beec-d06f3a508a8d"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("a8b83bea-cb37-49cc-a6d8-047f65da58c1"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("b258b2d3-1f44-47bf-b856-3635bb7abaa4"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("b436a40c-3851-4069-a84e-6fce0a8ed44e"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("bac778e8-7abe-4f4b-a188-a923d5711b72"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("d13caafb-b17a-4f1e-a5aa-aa3b73917716"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("dd384496-30e9-422e-9a54-ab7ddab2bee9"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("ddcdc003-36f0-47fe-9f42-18ca8e1237d6"));

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
    }
}
