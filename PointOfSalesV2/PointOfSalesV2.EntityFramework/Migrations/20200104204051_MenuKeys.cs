using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class MenuKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "LanguageCode", "Key", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Value" },
                values: new object[,]
                {
                    { "ES", "reports_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8981), 2L, null, null, null, "Reports" },
                    { "ES", "sales_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8984), 2L, null, null, null, "Sales" },
                    { "ES", "accountsReceivable_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8987), 2L, null, null, null, "Accounts Receivable" },
                    { "ES", "incomeReceipts_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8989), 2L, null, null, null, "Income Receipts" },
                    { "ES", "commissions_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8992), 2L, null, null, null, "Commissions" },
                    { "ES", "Inventory_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8995), 2L, null, null, null, "Inventory" },
                    { "ES", "productsMovements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8998), 2L, null, null, null, "Products Movements" },
                    { "ES", "debtsToPay_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9000), 2L, null, null, null, "Debts To Pay" },
                    { "ES", "pricesList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9003), 2L, null, null, null, "Prices List" },
                    { "ES", "customersList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9005), 2L, null, null, null, "Customers List" },
                    { "ES", "accountState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9008), 2L, null, null, null, "Account State" },
                    { "ES", "movements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9018), 2L, null, null, null, "Movements" },
                    { "ES", "resultState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9023), 2L, null, null, null, "Result State" },
                    { "ES", "inventoryIn_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9035), 2L, null, null, null, "Inventory Incomes" },
                    { "ES", "expensesPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8978), 2L, null, null, null, "Payments" },
                    { "ES", "warehouseTransfers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9047), 2L, null, null, null, "Warehouses Transfers" },
                    { "ES", "suppliersReturns_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9050), 2L, null, null, null, "Suppliers Returns" },
                    { "ES", "auth_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9057), 2L, null, null, null, "Auth" },
                    { "ES", "users_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9064), 2L, null, null, null, "Users" },
                    { "ES", "roles_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9067), 2L, null, null, null, "Roles" },
                    { "ES", "profile_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9070), 2L, null, null, null, "Profile" },
                    { "ES", "logout_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9074), 2L, null, null, null, "Log Out" },
                    { "ES", "dashboard_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9079), 2L, null, null, null, "Dashboard" },
                    { "ES", "remember_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9084), 2L, null, null, null, "Remember me?" },
                    { "ES", "forgotPass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9089), 2L, null, null, null, "Forgot Password?" },
                    { "ES", "password_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9094), 2L, null, null, null, "Password" },
                    { "ES", "email_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9099), 2L, null, null, null, "Email" },
                    { "ES", "taxesReport_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(9028), 2L, null, null, null, "Taxes Report" },
                    { "ES", "expensesRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8975), 2L, null, null, null, "Register expenses" },
                    { "EN", "start_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8439), 1L, null, null, null, "Start" },
                    { "ES", "customerPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8970), 2L, null, null, null, "Payments" },
                    { "EN", "accountsReceivable_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8516), 1L, null, null, null, "Accounts Receivable" },
                    { "EN", "sales_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8513), 1L, null, null, null, "Sales" },
                    { "EN", "reports_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8511), 1L, null, null, null, "Reports" },
                    { "EN", "expensesPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8508), 1L, null, null, null, "Payments" },
                    { "EN", "expensesRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8505), 1L, null, null, null, "Register expenses" },
                    { "EN", "expenses_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8503), 1L, null, null, null, "Expenses" },
                    { "EN", "customerPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8500), 1L, null, null, null, "Payments" },
                    { "EN", "incomeReceipts_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8518), 1L, null, null, null, "Income Receipts" },
                    { "EN", "invoices_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8498), 1L, null, null, null, "Invoices" },
                    { "EN", "billing_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8493), 1L, null, null, null, "Billing" },
                    { "EN", "cashROpenClose_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8491), 1L, null, null, null, "Opening/Closing" },
                    { "EN", "cashRegisterManteinance_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8488), 1L, null, null, null, "Manteinance" },
                    { "EN", "cashRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8485), 1L, null, null, null, "Cash Registers" },
                    { "EN", "products_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8483), 1L, null, null, null, "Products" },
                    { "EN", "customers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8480), 1L, null, null, null, "Customers" },
                    { "EN", "sellers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8477), 1L, null, null, null, "Sellers" },
                    { "EN", "quotes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8496), 1L, null, null, null, "Quotes" },
                    { "EN", "commissions_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8521), 1L, null, null, null, "Commissions" },
                    { "EN", "Inventory_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8523), 1L, null, null, null, "Inventory" },
                    { "EN", "productsMovements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8525), 1L, null, null, null, "Products Movements" },
                    { "EN", "remember_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8577), 1L, null, null, null, "Remember me?" },
                    { "EN", "dashboard_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8574), 1L, null, null, null, "Dashboard" },
                    { "EN", "logout_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8572), 1L, null, null, null, "Log Out" },
                    { "EN", "profile_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8569), 1L, null, null, null, "Profile" },
                    { "EN", "roles_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8562), 1L, null, null, null, "Roles" },
                    { "EN", "users_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8560), 1L, null, null, null, "Users" },
                    { "EN", "auth_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8558), 1L, null, null, null, "Auth" },
                    { "EN", "suppliersReturns_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8555), 1L, null, null, null, "Suppliers Returns" },
                    { "EN", "warehouseTransfers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8553), 1L, null, null, null, "Warehouses Transfers" },
                    { "EN", "inventoryIn_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8550), 1L, null, null, null, "Inventory Incomes" },
                    { "EN", "taxesReport_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8548), 1L, null, null, null, "Taxes Report" },
                    { "EN", "resultState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8546), 1L, null, null, null, "Result State" },
                    { "EN", "movements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8539), 1L, null, null, null, "Movements" },
                    { "EN", "accountState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8535), 1L, null, null, null, "Account State" },
                    { "EN", "customersList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8532), 1L, null, null, null, "Customers List" },
                    { "EN", "pricesList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8530), 1L, null, null, null, "Prices List" },
                    { "EN", "debtsToPay_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8528), 1L, null, null, null, "Debts To Pay" },
                    { "EN", "zones_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8475), 1L, null, null, null, "Zones" },
                    { "EN", "TRNControl_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8473), 1L, null, null, null, "TRN Control" },
                    { "ES", "expenses_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8973), 2L, null, null, null, "Expenses" },
                    { "EN", "taxes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8468), 1L, null, null, null, "Taxes" },
                    { "ES", "branchOffice_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8904), 2L, null, null, null, "Branch Offices" },
                    { "ES", "warehouse_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8906), 2L, null, null, null, "Warehouses" },
                    { "ES", "currencies_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8909), 2L, null, null, null, "Currencies" },
                    { "ES", "suppliers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8912), 2L, null, null, null, "Suppliers" },
                    { "ES", "taxes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8914), 2L, null, null, null, "Taxes" },
                    { "ES", "units_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8917), 2L, null, null, null, "Units" },
                    { "ES", "TRNControl_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8920), 2L, null, null, null, "TRN Control" },
                    { "ES", "core_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8899), 2L, null, null, null, "Configurations" },
                    { "ES", "zones_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8938), 2L, null, null, null, "Zones" },
                    { "ES", "customers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8949), 2L, null, null, null, "Customers" },
                    { "ES", "products_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8952), 2L, null, null, null, "Products" },
                    { "ES", "cashRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8954), 2L, null, null, null, "Cash Registers" },
                    { "ES", "cashRegisterManteinance_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8957), 2L, null, null, null, "Manteinance" },
                    { "ES", "invoices_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8967), 2L, null, null, null, "Invoices" },
                    { "ES", "billing_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8962), 2L, null, null, null, "Billing" },
                    { "ES", "quotes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8965), 2L, null, null, null, "Quotes" },
                    { "ES", "sellers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8945), 2L, null, null, null, "Sellers" },
                    { "ES", "restetPass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8897), 2L, null, null, null, "Reset Password" },
                    { "ES", "cashROpenClose_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8959), 2L, null, null, null, "Opening/Closing" },
                    { "ES", "login_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8891), 2L, null, null, null, "Login" },
                    { "ES", "logOut_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8894), 2L, null, null, null, "Log out" },
                    { "EN", "suppliers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8465), 1L, null, null, null, "Suppliers" },
                    { "EN", "currencies_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8463), 1L, null, null, null, "Currencies" },
                    { "EN", "warehouse_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8460), 1L, null, null, null, "Warehouses" },
                    { "EN", "branchOffice_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8458), 1L, null, null, null, "Branch Offices" },
                    { "EN", "core_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8453), 1L, null, null, null, "Configurations" },
                    { "EN", "restetPass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8451), 1L, null, null, null, "Reset Password" },
                    { "EN", "logOut_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8449), 1L, null, null, null, "Log out" },
                    { "EN", "units_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8470), 1L, null, null, null, "Units" },
                    { "EN", "changePass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8444), 1L, null, null, null, "Change Password" },
                    { "EN", "user_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8441), 1L, null, null, null, "User" },
                    { "EN", "forgotPass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8579), 1L, null, null, null, "Forgot Password?" },
                    { "EN", "password_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8581), 1L, null, null, null, "Password" },
                    { "EN", "email_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8584), 1L, null, null, null, "Email" },
                    { "ES", "start_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8875), 2L, null, null, null, "Start" },
                    { "ES", "user_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8878), 2L, null, null, null, "User" },
                    { "EN", "login_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8446), 1L, null, null, null, "Login" },
                    { "ES", "changePass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(8889), 2L, null, null, null, "Change Password" }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 226, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 211, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 211, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 199, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 206, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 206, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 206, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 206, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 206, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 206, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 207, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 208, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 208, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 208, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 216, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 209, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 16, 40, 50, 217, DateTimeKind.Local).AddTicks(2770));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "Inventory_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logout_btn" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "restetPass_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "Inventory_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logout_btn" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "restetPass_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" });

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 687, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 670, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 670, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 653, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 664, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 664, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 664, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 664, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 664, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 664, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 666, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 666, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 666, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 666, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 675, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 675, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 667, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 668, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(9992));
        }
    }
}
