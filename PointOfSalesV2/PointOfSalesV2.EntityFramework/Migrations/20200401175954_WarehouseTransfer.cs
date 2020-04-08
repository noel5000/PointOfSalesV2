using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class WarehouseTransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "WarehousesTransfers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WarehousesTransfers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "DestinyBranchOfficeId",
                table: "WarehousesTransfers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "WarehousesTransfers",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OriginBranchOfficeId",
                table: "WarehousesTransfers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Sequence",
                table: "WarehousesTransfers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "LocationId",
                table: "WarehousesMovements",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "BranchOfficeId",
                table: "WarehousesMovements",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_DestinyBranchOfficeId",
                table: "WarehousesTransfers",
                column: "DestinyBranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_OriginBranchOfficeId",
                table: "WarehousesTransfers",
                column: "OriginBranchOfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WarehousesTransfers_BranchOffices_DestinyBranchOfficeId",
                table: "WarehousesTransfers",
                column: "DestinyBranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarehousesTransfers_BranchOffices_OriginBranchOfficeId",
                table: "WarehousesTransfers",
                column: "OriginBranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarehousesTransfers_BranchOffices_DestinyBranchOfficeId",
                table: "WarehousesTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_WarehousesTransfers_BranchOffices_OriginBranchOfficeId",
                table: "WarehousesTransfers");

            migrationBuilder.DropIndex(
                name: "IX_WarehousesTransfers_DestinyBranchOfficeId",
                table: "WarehousesTransfers");

            migrationBuilder.DropIndex(
                name: "IX_WarehousesTransfers_OriginBranchOfficeId",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "DestinyBranchOfficeId",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "OriginBranchOfficeId",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "BranchOfficeId",
                table: "WarehousesMovements");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "WarehousesTransfers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "LocationId",
                table: "WarehousesMovements",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
