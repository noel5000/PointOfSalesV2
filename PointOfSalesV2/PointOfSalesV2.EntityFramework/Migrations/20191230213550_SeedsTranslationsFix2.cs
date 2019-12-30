using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class SeedsTranslationsFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 800, DateTimeKind.Local).AddTicks(4363), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]}" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 800, DateTimeKind.Local).AddTicks(5376), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]}" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 777, DateTimeKind.Local).AddTicks(1166), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]}" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 777, DateTimeKind.Local).AddTicks(1373), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 762, DateTimeKind.Local).AddTicks(594), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(7909), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8151), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8190), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8222), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8270), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 768, DateTimeKind.Local).AddTicks(8306), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4017), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4284), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4348), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 771, DateTimeKind.Local).AddTicks(4387), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}" });

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
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(1308), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5292), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5447), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5486), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5520), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5562), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5595), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5636), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5669), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5708), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5742), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5779), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5811), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5847), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5879), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5911), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5948), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(5982), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6020), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6054), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6091), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6122), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6160), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6193), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6230), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6262), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6294), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6331), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6363), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6400), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6431), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6498), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6531), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6571), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6603), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 785, DateTimeKind.Local).AddTicks(6635), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(3972), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4270), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4331), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4379), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4447), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4497), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4544), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4597), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4643), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4691), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 35, 48, 774, DateTimeKind.Local).AddTicks(4736), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 35, 48, 786, DateTimeKind.Local).AddTicks(3681));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 469, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(2858), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 468, DateTimeKind.Local).AddTicks(3863), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]}]" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 445, DateTimeKind.Local).AddTicks(8875), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]}]" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 445, DateTimeKind.Local).AddTicks(9009), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 436, DateTimeKind.Local).AddTicks(3100), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 441, DateTimeKind.Local).AddTicks(163), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 441, DateTimeKind.Local).AddTicks(309), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 441, DateTimeKind.Local).AddTicks(333), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 441, DateTimeKind.Local).AddTicks(352), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 441, DateTimeKind.Local).AddTicks(388), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 441, DateTimeKind.Local).AddTicks(408), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 442, DateTimeKind.Local).AddTicks(7050), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 442, DateTimeKind.Local).AddTicks(7191), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 442, DateTimeKind.Local).AddTicks(7214), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 442, DateTimeKind.Local).AddTicks(7234), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(2420), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6588), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6694), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6754), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6817), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6883), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(6944), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7001), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7054), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7118), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7182), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7239), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7293), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7352), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7408), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7468), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7524), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7585), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7823), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(7889), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8099), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8349), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8405), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8462), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8525), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8582), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8647), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(8703), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9025), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9085), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9138), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9199), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9378), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9440), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9489), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 453, DateTimeKind.Local).AddTicks(9546), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3494), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3616), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3639), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3669), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3688), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3709), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3734), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3752), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3769), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3788), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 9, 4, 444, DateTimeKind.Local).AddTicks(3813), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}]" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 9, 4, 454, DateTimeKind.Local).AddTicks(6437));
        }
    }
}
