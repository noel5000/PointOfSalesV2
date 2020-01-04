using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class SectionsRefactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "Seller,Zone,BranchOffice", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3251), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3315), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "Users,Role,UserRole", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3347), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3411), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3441), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]}" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { 38L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3666), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]}" },
                    { 39L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3727), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]}" },
                    { 40L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3755), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]}" },
                    { 46L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4049), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]}" },
                    { 41L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3821), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]}" },
                    { 42L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3849), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]}" },
                    { 43L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3930), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]}" },
                    { 44L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3959), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]}" },
                    { 45L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4019), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]}" },
                    { 47L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4078), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" },
                    { 37L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3634), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]}" }
                });

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

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 289L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3650), null, null, null, 1L, 37L },
                    { 350L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3982), null, null, null, 6L, 44L },
                    { 349L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3981), null, null, null, 5L, 44L },
                    { 348L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3979), null, null, null, 4L, 44L },
                    { 347L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3978), null, null, null, 3L, 44L },
                    { 346L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3976), null, null, null, 2L, 44L },
                    { 345L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3975), null, null, null, 1L, 44L },
                    { 343L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3955), null, null, null, 7L, 43L },
                    { 342L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3954), null, null, null, 6L, 43L },
                    { 341L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3952), null, null, null, 5L, 43L },
                    { 340L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3951), null, null, null, 4L, 43L },
                    { 339L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3949), null, null, null, 3L, 43L },
                    { 338L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3948), null, null, null, 2L, 43L },
                    { 337L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3946), null, null, null, 1L, 43L },
                    { 335L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3926), null, null, null, 7L, 42L },
                    { 334L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3925), null, null, null, 6L, 42L },
                    { 351L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3984), null, null, null, 7L, 44L },
                    { 353L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4037), null, null, null, 1L, 45L },
                    { 354L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4039), null, null, null, 2L, 45L },
                    { 355L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4040), null, null, null, 3L, 45L },
                    { 373L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4165), null, null, null, 5L, 47L },
                    { 372L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4164), null, null, null, 4L, 47L },
                    { 371L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4162), null, null, null, 3L, 47L },
                    { 370L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4161), null, null, null, 2L, 47L },
                    { 369L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4159), null, null, null, 1L, 47L },
                    { 367L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4074), null, null, null, 7L, 46L },
                    { 366L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4073), null, null, null, 6L, 46L },
                    { 333L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3923), null, null, null, 5L, 42L },
                    { 365L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4071), null, null, null, 5L, 46L },
                    { 363L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4068), null, null, null, 3L, 46L },
                    { 362L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4067), null, null, null, 2L, 46L },
                    { 361L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4066), null, null, null, 1L, 46L },
                    { 359L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4046), null, null, null, 7L, 45L },
                    { 358L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4044), null, null, null, 6L, 45L },
                    { 357L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4043), null, null, null, 5L, 45L },
                    { 356L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4041), null, null, null, 4L, 45L },
                    { 364L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4070), null, null, null, 4L, 46L },
                    { 374L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4167), null, null, null, 6L, 47L },
                    { 332L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3922), null, null, null, 4L, 42L },
                    { 330L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3919), null, null, null, 2L, 42L },
                    { 306L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3744), null, null, null, 2L, 39L },
                    { 305L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3743), null, null, null, 1L, 39L },
                    { 303L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3723), null, null, null, 7L, 38L },
                    { 302L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3722), null, null, null, 6L, 38L },
                    { 301L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3720), null, null, null, 5L, 38L },
                    { 300L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3719), null, null, null, 4L, 38L },
                    { 299L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3718), null, null, null, 3L, 38L },
                    { 298L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3716), null, null, null, 2L, 38L },
                    { 297L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3714), null, null, null, 1L, 38L },
                    { 295L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3661), null, null, null, 7L, 37L },
                    { 294L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3660), null, null, null, 6L, 37L },
                    { 293L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3656), null, null, null, 5L, 37L },
                    { 292L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3655), null, null, null, 4L, 37L },
                    { 291L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3653), null, null, null, 3L, 37L },
                    { 290L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3652), null, null, null, 2L, 37L },
                    { 307L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3746), null, null, null, 3L, 39L },
                    { 308L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3747), null, null, null, 4L, 39L },
                    { 309L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3749), null, null, null, 5L, 39L },
                    { 310L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3750), null, null, null, 6L, 39L },
                    { 329L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3865), null, null, null, 1L, 42L },
                    { 327L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3845), null, null, null, 7L, 41L },
                    { 326L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3844), null, null, null, 6L, 41L },
                    { 325L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3842), null, null, null, 5L, 41L },
                    { 324L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3841), null, null, null, 4L, 41L },
                    { 323L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3839), null, null, null, 3L, 41L },
                    { 322L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3838), null, null, null, 2L, 41L },
                    { 331L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3920), null, null, null, 3L, 42L },
                    { 321L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3837), null, null, null, 1L, 41L },
                    { 318L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3815), null, null, null, 6L, 40L },
                    { 317L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3813), null, null, null, 5L, 40L },
                    { 316L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3812), null, null, null, 4L, 40L },
                    { 315L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3811), null, null, null, 3L, 40L },
                    { 314L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3809), null, null, null, 2L, 40L },
                    { 313L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3808), null, null, null, 1L, 40L },
                    { 311L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3752), null, null, null, 7L, 39L },
                    { 319L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(3817), null, null, null, 7L, 40L },
                    { 375L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 15, 43, 29, 676, DateTimeKind.Local).AddTicks(4168), null, null, null, 7L, 47L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L);

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
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "", new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3131), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "Seller,Zone,BranchOffice", new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3166), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "", new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3197), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Controllers", "CreatedDate", "TranslationData" },
                values: new object[] { "Users,Role,UserRole", new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3225), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 21, 17, 4, 464, DateTimeKind.Local).AddTicks(3259), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]}" });

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
    }
}
