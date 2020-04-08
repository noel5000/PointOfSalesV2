using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class CashRegisterOpeningUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosureDetails",
                table: "CashRegisterOpenings");

            migrationBuilder.DropColumn(
                name: "OpeningDetails",
                table: "CashRegisterOpenings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClosureDetails",
                table: "CashRegisterOpenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningDetails",
                table: "CashRegisterOpenings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
