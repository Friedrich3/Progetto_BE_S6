using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Progetto_BE_S6.Migrations
{
    /// <inheritdoc />
    public partial class uniqueEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("08539e4a-cba7-4bf0-9491-bc6e4faeca7d"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("228b555e-eefe-4133-8650-0fcba06cd0af"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("2a8b7bc6-ecfa-4a9b-b19a-6c0fa4760211"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("461448da-0c92-42b1-a289-808168099120"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("59e5ae23-7b1e-4a84-856e-1e4089b39c5c"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("8787bdaa-06f9-4384-a0e5-29330dc94b71"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("aceb24f8-6d8f-4a0f-a705-fe908fa28996"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("b8505eb9-ec33-4a8f-a988-ad001779d748"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("c3a9241b-87b3-4e13-a7bc-b47c8412b888"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("cd32c9d3-411c-4d46-84f7-186fc20bb025"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("f675b115-0636-4b63-9c84-83c8637ac40a"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clienti",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Clienti_Email",
                table: "Clienti",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clienti_Email",
                table: "Clienti");

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
                name: "Email",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Camere",
                columns: new[] { "CameraId", "IsDisponibile", "Numero", "Prezzo", "Tipo" },
                values: new object[,]
                {
                    { new Guid("08539e4a-cba7-4bf0-9491-bc6e4faeca7d"), true, "103", 110.00m, "Tripla" },
                    { new Guid("228b555e-eefe-4133-8650-0fcba06cd0af"), true, "101", 70.00m, "Singola" },
                    { new Guid("2a8b7bc6-ecfa-4a9b-b19a-6c0fa4760211"), true, "102", 90.00m, "Doppia" },
                    { new Guid("461448da-0c92-42b1-a289-808168099120"), true, "110", 90.00m, "Doppia" },
                    { new Guid("59e5ae23-7b1e-4a84-856e-1e4089b39c5c"), true, "104", 150.00m, "Quadrupla" },
                    { new Guid("8787bdaa-06f9-4384-a0e5-29330dc94b71"), true, "109", 70.00m, "Singola" },
                    { new Guid("aceb24f8-6d8f-4a0f-a705-fe908fa28996"), true, "106", 90.00m, "Doppia" },
                    { new Guid("b8505eb9-ec33-4a8f-a988-ad001779d748"), true, "105", 70.00m, "Singola" },
                    { new Guid("c3a9241b-87b3-4e13-a7bc-b47c8412b888"), true, "107", 110.00m, "Tripla" },
                    { new Guid("cd32c9d3-411c-4d46-84f7-186fc20bb025"), true, "108", 150.00m, "Quadrupla" },
                    { new Guid("f675b115-0636-4b63-9c84-83c8637ac40a"), true, "111", 110.00m, "Tripla" }
                });
        }
    }
}
