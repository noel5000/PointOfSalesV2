using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class auditableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Zones",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Zones",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "WarehousesTransfers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "WarehousesTransfers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "WarehousesMovements",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "WarehousesMovements",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Warehouses",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Warehouses",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "UsersClaims",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "UsersClaims",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "UserRoles",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "UserRoles",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Units",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Units",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "UnitProductsEquivalences",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "UnitProductsEquivalences",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "TRNsControl",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "TRNsControl",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Taxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Taxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SuppliersReturns",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SuppliersReturns",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SuppliersBalances",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SuppliersBalances",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Suppliers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Suppliers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SequencesControl",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SequencesControl",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Sellers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Sellers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Sections",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Sections",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SectionOperations",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SectionOperations",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "RoleSections",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "RoleSections",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Roles",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Roles",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "ProductTaxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "ProductTaxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Products",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Products",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "PaymentTypes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "PaymentTypes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "PaymentDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "PaymentDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Operations",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Operations",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "OpeningsAmounts",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "OpeningsAmounts",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "MovementTypes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "MovementTypes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Languages",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Languages",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "LanguageKeys",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "LanguageKeys",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "InvoicesTaxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "InvoicesTaxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "InvoicesDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "InvoicesDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Invoices",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Invoices",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "InventoryEntries",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "InventoryEntries",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Inventory",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Inventory",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "ExpenseTaxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "ExpenseTaxes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "ExpensesPayments",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "ExpensesPayments",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Expenses",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Expenses",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersReturns",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersReturns",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersReturnDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersReturnDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersPayments",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersPayments",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersBalance",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersBalance",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Customers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Customers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Currencies",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Currencies",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CreditNotes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CreditNotes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CompositeProducts",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CompositeProducts",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CashRegisters",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CashRegisters",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CashRegisterOpenings",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CashRegisterOpenings",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "BranchOffices",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "BranchOffices",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 485, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 458, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 458, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 382, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 454, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 454, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 454, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 454, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 454, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 454, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 455, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 455, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 455, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 455, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 463, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 457, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(9403));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Zones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Zones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "WarehousesTransfers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "WarehousesTransfers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "WarehousesMovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "WarehousesMovements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "UsersClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "UsersClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Units",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Units",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "UnitProductsEquivalences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "UnitProductsEquivalences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "TRNsControl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "TRNsControl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Taxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Taxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SuppliersReturns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SuppliersReturns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SuppliersBalances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SuppliersBalances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SequencesControl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SequencesControl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Sections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "SectionOperations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "SectionOperations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "RoleSections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "RoleSections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "ProductTaxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "ProductTaxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "PaymentTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "PaymentTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "PaymentDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "PaymentDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Operations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Operations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "OpeningsAmounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "OpeningsAmounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "MovementTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "MovementTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "LanguageKeys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "LanguageKeys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "InvoicesTaxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "InvoicesTaxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "InvoicesDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "InvoicesDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "InventoryEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "InventoryEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "ExpenseTaxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "ExpenseTaxes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "ExpensesPayments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "ExpensesPayments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersReturns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersReturns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersReturnDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersReturnDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersPayments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersPayments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CustomersBalance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CustomersBalance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CreditNotes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CreditNotes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CompositeProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CompositeProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CashRegisters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CashRegisters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "CashRegisterOpenings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "CashRegisterOpenings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedByName",
                table: "BranchOffices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByName",
                table: "BranchOffices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 800, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 801, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 800, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 800, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 777, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 777, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 762, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 786, DateTimeKind.Local).AddTicks(3681));
        }
    }
}
