using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class UsersBranchOfficeCashOpening2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CashRegisterOpenings_BranchOffices_LocationId",
                table: "CashRegisterOpenings");

            migrationBuilder.DropIndex(
                name: "IX_CashRegisterOpenings_LocationId",
                table: "CashRegisterOpenings");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "CashRegisterOpenings");

            migrationBuilder.AddColumn<long>(
                name: "BranchOfficeId",
                table: "CashRegisterOpenings",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 409, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 391, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 391, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 381, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 384, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 384, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 384, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 384, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 384, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 384, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 387, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 387, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 387, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 387, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 398, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 390, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 21, 13, 31, 399, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_BranchOfficeId",
                table: "CashRegisterOpenings",
                column: "BranchOfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CashRegisterOpenings_BranchOffices_BranchOfficeId",
                table: "CashRegisterOpenings",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CashRegisterOpenings_BranchOffices_BranchOfficeId",
                table: "CashRegisterOpenings");

            migrationBuilder.DropIndex(
                name: "IX_CashRegisterOpenings_BranchOfficeId",
                table: "CashRegisterOpenings");

            migrationBuilder.DropColumn(
                name: "BranchOfficeId",
                table: "CashRegisterOpenings");

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "CashRegisterOpenings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 964, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 940, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 940, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 925, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 929, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 931, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 931, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 931, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 931, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 931, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 934, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 934, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 934, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 934, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 949, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 950, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 937, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 26, 20, 29, 19, 951, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_LocationId",
                table: "CashRegisterOpenings",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CashRegisterOpenings_BranchOffices_LocationId",
                table: "CashRegisterOpenings",
                column: "LocationId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
