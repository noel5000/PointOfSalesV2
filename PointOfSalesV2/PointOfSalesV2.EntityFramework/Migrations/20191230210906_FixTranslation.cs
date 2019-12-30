using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class FixTranslation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(2747), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 644, DateTimeKind.Local).AddTicks(3359), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 626, DateTimeKind.Local).AddTicks(1907), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 626, DateTimeKind.Local).AddTicks(2237), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 612, DateTimeKind.Local).AddTicks(8264), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 619, DateTimeKind.Local).AddTicks(863), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 619, DateTimeKind.Local).AddTicks(1344), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 619, DateTimeKind.Local).AddTicks(1384), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 619, DateTimeKind.Local).AddTicks(1437), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 619, DateTimeKind.Local).AddTicks(1476), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 619, DateTimeKind.Local).AddTicks(1510), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 621, DateTimeKind.Local).AddTicks(7857), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 621, DateTimeKind.Local).AddTicks(8071), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 621, DateTimeKind.Local).AddTicks(8114), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 621, DateTimeKind.Local).AddTicks(8150), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(2049), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4768), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4818), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4856), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4887), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4920), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4953), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(4982), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5086), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5117), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5152), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5183), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5217), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5246), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5275), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5308), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5337), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5371), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5399), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5435), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5465), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5499), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5529), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5562), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5592), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5626), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5655), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5685), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5718), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5748), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5781), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5811), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5845), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5875), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5908), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 632, DateTimeKind.Local).AddTicks(5937), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovements\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9463), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9668), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9722), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9756), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9789), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9825), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9865), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9899), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9932), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 623, DateTimeKind.Local).AddTicks(9973), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 624, DateTimeKind.Local).AddTicks(6), "[{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]},{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}]]" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 30, 17, 5, 42, 633, DateTimeKind.Local).AddTicks(4626));
        }
    }
}
