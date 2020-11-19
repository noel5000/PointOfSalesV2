using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class productIdRenameReturn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersReturnDetails_Products_ProductoId",
                table: "CustomersReturnDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomersReturnDetails_ProductoId",
                table: "CustomersReturnDetails");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "CustomersReturnDetails");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "CustomersReturnDetails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_ProductId",
                table: "CustomersReturnDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersReturnDetails_Products_ProductId",
                table: "CustomersReturnDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersReturnDetails_Products_ProductId",
                table: "CustomersReturnDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomersReturnDetails_ProductId",
                table: "CustomersReturnDetails");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CustomersReturnDetails");

            migrationBuilder.AddColumn<long>(
                name: "ProductoId",
                table: "CustomersReturnDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_ProductoId",
                table: "CustomersReturnDetails",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersReturnDetails_Products_ProductoId",
                table: "CustomersReturnDetails",
                column: "ProductoId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
