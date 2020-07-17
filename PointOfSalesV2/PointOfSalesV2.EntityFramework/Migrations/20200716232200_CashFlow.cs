using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class CashFlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashRegisterFlowDetails",
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
                    CashRegisterOpeningId = table.Column<long>(nullable: false),
                    PaymentType = table.Column<byte>(nullable: false),
                    MovementType = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRegisterFlowDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashRegisterFlowDetails_CashRegisterOpenings_CashRegisterOpeningId",
                        column: x => x.CashRegisterOpeningId,
                        principalTable: "CashRegisterOpenings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CashRegisterFlowDetails_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterFlowDetails_CashRegisterOpeningId",
                table: "CashRegisterFlowDetails",
                column: "CashRegisterOpeningId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterFlowDetails_CurrencyId",
                table: "CashRegisterFlowDetails",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRegisterFlowDetails");
        }
    }
}
