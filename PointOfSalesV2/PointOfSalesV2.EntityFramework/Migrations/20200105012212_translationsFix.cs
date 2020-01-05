using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class translationsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 551, DateTimeKind.Local).AddTicks(8976), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]}" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 551, DateTimeKind.Local).AddTicks(9599), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]}" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 532, DateTimeKind.Local).AddTicks(8386), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]}" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 532, DateTimeKind.Local).AddTicks(9893), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 519, DateTimeKind.Local).AddTicks(6720), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(1902), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2085), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2123), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2155), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2288), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 526, DateTimeKind.Local).AddTicks(2322), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(3913), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(4093), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(4128), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 528, DateTimeKind.Local).AddTicks(4161), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}" });

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
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 540, DateTimeKind.Local).AddTicks(8383), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1751), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1846), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1904), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(1963), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2021), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2081), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2134), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2187), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2250), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2306), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2365), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2418), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2550), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2604), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2659), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2717), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2773), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2831), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2887), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2947), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(2998), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3057), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3107), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3166), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3218), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3271), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3330), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3383), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3441), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3494), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3546), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3608), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3663), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3723), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3775), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3832), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3893), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(3946), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4001), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4058), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4112), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4207), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4259), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4311), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4369), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 541, DateTimeKind.Local).AddTicks(4421), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6107), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6265), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6303), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6338), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6380), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6418), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6453), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6485), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6524), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6561), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 22, 10, 530, DateTimeKind.Local).AddTicks(6594), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 22, 10, 542, DateTimeKind.Local).AddTicks(1202));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(538), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]}" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(1663), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]}" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 261, DateTimeKind.Local).AddTicks(4244), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]}" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 261, DateTimeKind.Local).AddTicks(4493), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 249, DateTimeKind.Local).AddTicks(7316), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3593), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3732), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3756), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3791), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3813), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3833), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3507), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3739), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3775), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3885), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}" });

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(1501), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4048), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4099), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4142), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4173), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4213), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4244), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4281), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4311), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4343), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4380), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4411), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4446), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4477), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4512), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4542), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4634), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4667), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4696), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4734), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4770), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4799), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4829), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4865), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4896), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5083), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5111), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5146), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5174), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5203), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5237), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5267), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5300), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5331), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5364), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5393), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5422), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5458), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5492), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5521), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5555), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5583), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5616), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5645), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5675), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5742), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5772), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(6941), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7213), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7322), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7367), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7403), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7450), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7496), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7533), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7673), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7729), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7768), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 21, 16, 20, 269, DateTimeKind.Local).AddTicks(1313));
        }
    }
}
