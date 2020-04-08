using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Sequences1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SequencesControl",
                columns: new[] { "Id", "Active", "Code", "CodeName", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "NumericControl", "TranslationData" },
                values: new object[] { 14L, true, (short)14, "PG", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ExpensePayments", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensePayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensePayments\"}]}" });

            migrationBuilder.InsertData(
                table: "SequencesControl",
                columns: new[] { "Id", "Active", "Code", "CodeName", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "NumericControl", "TranslationData" },
                values: new object[] { 15L, true, (short)15, "PRO", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Products", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 15L);
        }
    }
}
