using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class CashFlowReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "CashRegisterFlowDetails");

            migrationBuilder.AddColumn<long>(
                name: "PaymentTypeId",
                table: "CashRegisterFlowDetails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "CashRegisterFlowDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterFlowDetails_PaymentTypeId",
                table: "CashRegisterFlowDetails",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CashRegisterFlowDetails_PaymentTypes_PaymentTypeId",
                table: "CashRegisterFlowDetails",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CashRegisterFlowDetails_PaymentTypes_PaymentTypeId",
                table: "CashRegisterFlowDetails");

            migrationBuilder.DropIndex(
                name: "IX_CashRegisterFlowDetails_PaymentTypeId",
                table: "CashRegisterFlowDetails");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "CashRegisterFlowDetails");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "CashRegisterFlowDetails");

            migrationBuilder.AddColumn<byte>(
                name: "PaymentType",
                table: "CashRegisterFlowDetails",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
