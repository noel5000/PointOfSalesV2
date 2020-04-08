using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class WarehouseTransfer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrigingId",
                table: "WarehousesTransfers");

            migrationBuilder.AlterColumn<long>(
                name: "OriginId",
                table: "WarehousesTransfers",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "OriginId",
                table: "WarehousesTransfers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "OrigingId",
                table: "WarehousesTransfers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
