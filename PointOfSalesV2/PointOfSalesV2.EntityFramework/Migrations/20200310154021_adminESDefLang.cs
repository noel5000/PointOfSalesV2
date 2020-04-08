using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class adminESDefLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 926, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 908, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 908, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 900, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                columns: new[] { "CreatedDate", "LanguageCode" },
                values: new object[] { new DateTime(2020, 3, 10, 11, 40, 19, 917, DateTimeKind.Local).AddTicks(970), "ES" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 552, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 551, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 551, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 532, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 532, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 519, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 540, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 540, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                columns: new[] { "CreatedDate", "LanguageCode" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 542, DateTimeKind.Local).AddTicks(1202), "EN" });
        }
    }
}
