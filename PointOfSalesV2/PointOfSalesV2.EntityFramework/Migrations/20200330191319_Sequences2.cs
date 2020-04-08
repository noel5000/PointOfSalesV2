using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Sequences2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Name", "TranslationData" },
                values: new object[] { "CompanyPayments", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}]}" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Name", "TranslationData" },
                values: new object[] { "ExpensesPayments", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });
        }
    }
}
