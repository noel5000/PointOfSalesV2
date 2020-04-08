using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class newController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[] { 48L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}]}" });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 377L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 48L },
                    { 378L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 48L },
                    { 379L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 48L },
                    { 380L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 48L },
                    { 381L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 48L },
                    { 382L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 48L },
                    { 383L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 48L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 48L);
        }
    }
}
