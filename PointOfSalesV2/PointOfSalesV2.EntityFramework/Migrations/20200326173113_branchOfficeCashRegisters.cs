using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class branchOfficeCashRegisters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 439, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 440, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 421, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 421, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 411, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 415, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 415, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 415, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 415, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 415, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 415, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 417, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 417, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 417, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 417, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 428, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 419, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 13, 31, 11, 429, DateTimeKind.Local).AddTicks(8178));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 562, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 563, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 562, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 562, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 545, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 545, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 536, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 539, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 539, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 539, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 539, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 539, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 539, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 541, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 541, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 541, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 541, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 550, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 543, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 12, 46, 1, 551, DateTimeKind.Local).AddTicks(6500));
        }
    }
}
