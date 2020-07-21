using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class customerszone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ZoneId",
                table: "Customers",
                nullable: true,
                defaultValue: null);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ZoneId",
                table: "Customers",
                column: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Zones_ZoneId",
                table: "Customers",
                column: "ZoneId",
                principalTable: "Zones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Zones_ZoneId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ZoneId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Customers");
        }
    }
}
