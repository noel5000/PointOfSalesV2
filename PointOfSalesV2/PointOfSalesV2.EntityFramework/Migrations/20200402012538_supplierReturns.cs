using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class supplierReturns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaxesAmount",
                table: "SuppliersReturns",
                newName: "TaxAmount");

            migrationBuilder.AddColumn<decimal>(
                name: "BeforeTaxAmount",
                table: "SuppliersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "BranchOfficeId",
                table: "SuppliersReturns",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CurrencyId",
                table: "SuppliersReturns",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "SuppliersReturns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "SuppliersReturns",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "SuppliersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateAmount",
                table: "SuppliersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsDefective",
                table: "SuppliersReturns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoTaxes",
                table: "SuppliersReturns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductCost",
                table: "SuppliersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Sequence",
                table: "SuppliersReturns",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_BranchOfficeId",
                table: "SuppliersReturns",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_CurrencyId",
                table: "SuppliersReturns",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersReturns_BranchOffices_BranchOfficeId",
                table: "SuppliersReturns",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersReturns_Currencies_CurrencyId",
                table: "SuppliersReturns",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersReturns_BranchOffices_BranchOfficeId",
                table: "SuppliersReturns");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersReturns_Currencies_CurrencyId",
                table: "SuppliersReturns");

            migrationBuilder.DropIndex(
                name: "IX_SuppliersReturns_BranchOfficeId",
                table: "SuppliersReturns");

            migrationBuilder.DropIndex(
                name: "IX_SuppliersReturns_CurrencyId",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "BeforeTaxAmount",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "BranchOfficeId",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "ExchangeRateAmount",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "IsDefective",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "NoTaxes",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "ProductCost",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "SuppliersReturns");

            migrationBuilder.RenameColumn(
                name: "TaxAmount",
                table: "SuppliersReturns",
                newName: "TaxesAmount");
        }
    }
}
