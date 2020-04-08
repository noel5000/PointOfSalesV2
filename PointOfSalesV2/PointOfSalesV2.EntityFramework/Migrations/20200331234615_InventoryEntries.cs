using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class InventoryEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BeforeTaxAmount",
                table: "InventoryEntries",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "BranchOfficeId",
                table: "InventoryEntries",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CurrencyId",
                table: "InventoryEntries",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "InventoryEntries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "InventoryEntries",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "InventoryEntries",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateAmount",
                table: "InventoryEntries",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductCost",
                table: "InventoryEntries",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Sequence",
                table: "InventoryEntries",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_BranchOfficeId",
                table: "InventoryEntries",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_CurrencyId",
                table: "InventoryEntries",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryEntries_BranchOffices_BranchOfficeId",
                table: "InventoryEntries",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryEntries_Currencies_CurrencyId",
                table: "InventoryEntries",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryEntries_BranchOffices_BranchOfficeId",
                table: "InventoryEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryEntries_Currencies_CurrencyId",
                table: "InventoryEntries");

            migrationBuilder.DropIndex(
                name: "IX_InventoryEntries_BranchOfficeId",
                table: "InventoryEntries");

            migrationBuilder.DropIndex(
                name: "IX_InventoryEntries_CurrencyId",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "BeforeTaxAmount",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "BranchOfficeId",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "ExchangeRateAmount",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "ProductCost",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "InventoryEntries");
        }
    }
}
