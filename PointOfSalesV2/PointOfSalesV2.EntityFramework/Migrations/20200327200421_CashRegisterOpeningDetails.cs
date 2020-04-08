using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class CashRegisterOpeningDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsDetails_InvoicesLeads_InvoiceLeadId",
                table: "LeadsDetails");

            migrationBuilder.CreateTable(
                name: "CashRegisterOpeningDetails",
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
                    IsClosing = table.Column<bool>(nullable: false),
                    CashRegisterOpeningId = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRegisterOpeningDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpeningDetails_CashRegisterOpenings_CashRegisterOpeningId",
                        column: x => x.CashRegisterOpeningId,
                        principalTable: "CashRegisterOpenings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpeningDetails_CashRegisterOpeningId",
                table: "CashRegisterOpeningDetails",
                column: "CashRegisterOpeningId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsDetails_InvoicesLeads_InvoiceLeadId",
                table: "LeadsDetails",
                column: "InvoiceLeadId",
                principalTable: "InvoicesLeads",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsDetails_InvoicesLeads_InvoiceLeadId",
                table: "LeadsDetails");

            migrationBuilder.DropTable(
                name: "CashRegisterOpeningDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsDetails_InvoicesLeads_InvoiceLeadId",
                table: "LeadsDetails",
                column: "InvoiceLeadId",
                principalTable: "InvoicesLeads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
