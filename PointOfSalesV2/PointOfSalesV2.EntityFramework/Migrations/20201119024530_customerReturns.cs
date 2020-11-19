using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class customerReturns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "InvoiceId",
                table: "CustomersReturns",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BeforeTaxesAmount",
                table: "CustomersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "BranchOfficeId",
                table: "CustomersReturns",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreditNoteId",
                table: "CustomersReturns",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "CreditNoteNumber",
                table: "CustomersReturns",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CurrencyId",
                table: "CustomersReturns",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "CustomersReturns",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "CustomersReturns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "CustomersReturns",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxesAmount",
                table: "CustomersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "CustomersReturns",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "CreditNotes",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturns_BranchOfficeId",
                table: "CustomersReturns",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturns_CreditNoteId",
                table: "CustomersReturns",
                column: "CreditNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturns_CurrencyId",
                table: "CustomersReturns",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturns_CustomerId",
                table: "CustomersReturns",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersReturns_BranchOffices_BranchOfficeId",
                table: "CustomersReturns",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersReturns_CreditNotes_CreditNoteId",
                table: "CustomersReturns",
                column: "CreditNoteId",
                principalTable: "CreditNotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersReturns_Currencies_CurrencyId",
                table: "CustomersReturns",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersReturns_Customers_CustomerId",
                table: "CustomersReturns",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersReturns_BranchOffices_BranchOfficeId",
                table: "CustomersReturns");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomersReturns_CreditNotes_CreditNoteId",
                table: "CustomersReturns");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomersReturns_Currencies_CurrencyId",
                table: "CustomersReturns");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomersReturns_Customers_CustomerId",
                table: "CustomersReturns");

            migrationBuilder.DropIndex(
                name: "IX_CustomersReturns_BranchOfficeId",
                table: "CustomersReturns");

            migrationBuilder.DropIndex(
                name: "IX_CustomersReturns_CreditNoteId",
                table: "CustomersReturns");

            migrationBuilder.DropIndex(
                name: "IX_CustomersReturns_CurrencyId",
                table: "CustomersReturns");

            migrationBuilder.DropIndex(
                name: "IX_CustomersReturns_CustomerId",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "BeforeTaxesAmount",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "BranchOfficeId",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "CreditNoteId",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "CreditNoteNumber",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "TaxesAmount",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CreditNotes");

            migrationBuilder.AlterColumn<long>(
                name: "InvoiceId",
                table: "CustomersReturns",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));
        }
    }
}
