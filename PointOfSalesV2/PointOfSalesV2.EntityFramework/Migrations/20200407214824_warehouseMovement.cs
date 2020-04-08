using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class warehouseMovement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarehousesMovements_BranchOffices_LocationId",
                table: "WarehousesMovements");

            migrationBuilder.DropIndex(
                name: "IX_WarehousesMovements_LocationId",
                table: "WarehousesMovements");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "WarehousesMovements");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_BranchOfficeId",
                table: "WarehousesMovements",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_BranchOfficeId",
                table: "Inventory",
                column: "BranchOfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_BranchOffices_BranchOfficeId",
                table: "Inventory",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarehousesMovements_BranchOffices_BranchOfficeId",
                table: "WarehousesMovements",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_BranchOffices_BranchOfficeId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_WarehousesMovements_BranchOffices_BranchOfficeId",
                table: "WarehousesMovements");

            migrationBuilder.DropIndex(
                name: "IX_WarehousesMovements_BranchOfficeId",
                table: "WarehousesMovements");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_BranchOfficeId",
                table: "Inventory");

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "WarehousesMovements",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_LocationId",
                table: "WarehousesMovements",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_WarehousesMovements_BranchOffices_LocationId",
                table: "WarehousesMovements",
                column: "LocationId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
