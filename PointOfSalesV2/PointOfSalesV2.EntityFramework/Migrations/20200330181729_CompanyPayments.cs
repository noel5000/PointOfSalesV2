using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class CompanyPayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "ExpensesPayments");

            migrationBuilder.RenameColumn(
                name: "ReturnedAmount",
                table: "ExpensesPayments",
                newName: "PositiveBalance");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ExpensesPayments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "PaymentId",
                table: "ExpensesPayments",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PaymentSequence",
                table: "ExpensesPayments",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sequence",
                table: "Expenses",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyPayments",
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
                    DestinationType = table.Column<byte>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    GivenAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    PositiveBalance = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ExchangeRateAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OutstandingAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyPayments_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyPayments_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_PaymentId",
                table: "ExpensesPayments",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPayments_CurrencyId",
                table: "CompanyPayments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPayments_PaymentTypeId",
                table: "CompanyPayments",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesPayments_Payment_PaymentId",
                table: "ExpensesPayments",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesPayments_Payment_PaymentId",
                table: "ExpensesPayments");

            migrationBuilder.DropTable(
                name: "CompanyPayments");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesPayments_PaymentId",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "PaymentSequence",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "PositiveBalance",
                table: "ExpensesPayments",
                newName: "ReturnedAmount");

            migrationBuilder.AddColumn<string>(
                name: "Sequence",
                table: "ExpensesPayments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
