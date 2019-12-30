using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Translation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TRNsControl");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Taxes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MovementTypes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CashRegisters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BranchOffices");

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
                columns: new[] { "CreatedDate", "LanguageCode" },
                values: new object[] { new DateTime(2019, 12, 30, 17, 5, 42, 633, DateTimeKind.Local).AddTicks(4626), "EN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Zones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Warehouses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Units",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TRNsControl",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Taxes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sections",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Operations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MovementTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CashRegisters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BranchOffices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 646, DateTimeKind.Local).AddTicks(8514), "English", "[]" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 646, DateTimeKind.Local).AddTicks(9116), "Spanish", "[]" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 628, DateTimeKind.Local).AddTicks(7658), "IN", "[]" });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 628, DateTimeKind.Local).AddTicks(7761), "OUT", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 622, DateTimeKind.Local).AddTicks(4690), "READ", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7571), "ADD", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7597), "UPDATE", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7602), "DELETE", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7605), "READALL", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7612), "READPAGED", "[]" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7615), "ALL", "[]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4139), "[]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4237), "[]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4242), "[]" });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4245), "[]" });

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(2499), "Permissions", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4949), "CustomerRates", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5029), "Products", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5045), "CustomerPayments", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5060), "Currencies", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5078), "Taxes", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5092), "Invoices", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5113), "Quotes", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5127), "Customers", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5143), "Warehouses", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5159), "All", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5174), "Inventories", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5250), "TRNControl", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5267), "Expenses", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5280), "BranchOffices", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5295), "ExpensesPayments", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5309), "Suppliers", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5325), "Units", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5345), "Users", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5361), "PaymentTypes", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5375), "CashRegisters", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5389), "CashRegisterOpenings", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5403), "CashRegisterOpeningsAmounts", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5423), "IncomeMovements", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5437), "CustomersReturns", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5451), "SuppliersReturns", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5464), "WarehouseTransfers", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5479), "ProductUnits", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5493), "Roles", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5513), "Sections", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5527), "Operations", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5541), "Menu", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5555), "Sellers", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5571), "Zones", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5585), "UserRoles", "[]" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "Name", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5604), "WarehouseMovements", "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(321), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(428), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(433), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(436), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(440), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(446), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(450), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(453), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(457), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(461), "[]" });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "TranslationData" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(464), "[]" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                columns: new[] { "CreatedDate", "LanguageCode" },
                values: new object[] { new DateTime(2019, 12, 29, 21, 58, 3, 635, DateTimeKind.Local).AddTicks(625), null });
        }
    }
}
