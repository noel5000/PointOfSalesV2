using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Expenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateAmount",
                table: "ExpenseTaxes",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateAmount",
                table: "ExpensesPayments",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "ExpenseId",
                table: "ExpensesPayments",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ExpensesPayments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "PaymentTypeId",
                table: "Expenses",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateAmount",
                table: "Expenses",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "RateUpdateDate",
                table: "Currencies",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UpdatedRate",
                table: "Currencies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerPercentage = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    InvoiceCurrencyId = table.Column<long>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    ReceiptNumber = table.Column<string>(maxLength: 50, nullable: true),
                    SellerId = table.Column<long>(nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Currencies_InvoiceCurrencyId",
                        column: x => x.InvoiceCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_ExpenseId",
                table: "ExpensesPayments",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_PaymentTypeId",
                table: "ExpensesPayments",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_PaymentTypeId",
                table: "Expenses",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CurrencyId",
                table: "Payment",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_InvoiceCurrencyId",
                table: "Payment",
                column: "InvoiceCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentTypeId",
                table: "Payment",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SellerId",
                table: "Payment",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_PaymentTypes_PaymentTypeId",
                table: "Expenses",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesPayments_Expenses_ExpenseId",
                table: "ExpensesPayments",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesPayments_PaymentTypes_PaymentTypeId",
                table: "ExpensesPayments",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_PaymentTypes_PaymentTypeId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesPayments_Expenses_ExpenseId",
                table: "ExpensesPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesPayments_PaymentTypes_PaymentTypeId",
                table: "ExpensesPayments");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesPayments_ExpenseId",
                table: "ExpensesPayments");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesPayments_PaymentTypeId",
                table: "ExpensesPayments");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_PaymentTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExchangeRateAmount",
                table: "ExpenseTaxes");

            migrationBuilder.DropColumn(
                name: "ExchangeRateAmount",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "ExpenseId",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "ExchangeRateAmount",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "RateUpdateDate",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "UpdatedRate",
                table: "Currencies");

            migrationBuilder.AlterColumn<long>(
                name: "PaymentTypeId",
                table: "Expenses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
