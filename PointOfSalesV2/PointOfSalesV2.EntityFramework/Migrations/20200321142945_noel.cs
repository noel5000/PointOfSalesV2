using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class noel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Currencies");

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 735, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 718, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 718, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 709, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 712, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 712, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 712, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 712, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 712, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 712, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 715, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 715, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 715, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 715, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 723, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 723, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 716, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 21, 10, 29, 43, 724, DateTimeKind.Local).AddTicks(8268));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Currencies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 227, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 227, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 210, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 220, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 233, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(9139));
        }
    }
}
