using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Sequences3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesPayments_Payment_PaymentId",
                table: "ExpensesPayments");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesPayments_CompanyPayments_PaymentId",
                table: "ExpensesPayments",
                column: "PaymentId",
                principalTable: "CompanyPayments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesPayments_CompanyPayments_PaymentId",
                table: "ExpensesPayments");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesPayments_Payment_PaymentId",
                table: "ExpensesPayments",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
