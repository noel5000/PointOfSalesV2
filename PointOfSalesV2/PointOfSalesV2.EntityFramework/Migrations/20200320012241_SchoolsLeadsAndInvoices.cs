using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class SchoolsLeadsAndInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Warehouses_AssignedWarehouseId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Zones_ZoneId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Zones_ZoneId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesDetails_Invoices_InvoiceId",
                table: "InvoicesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesDetails_Products_ProductId",
                table: "InvoicesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoicesDetails_Units_UnitId",
                table: "InvoicesDetails");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ZoneId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AssignedWarehouseId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ZoneId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoicesDetails",
                table: "InvoicesDetails");

            migrationBuilder.DropIndex(
                name: "IX_InvoicesDetails_InvoiceId",
                table: "InvoicesDetails");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "AssignedWarehouseId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "InvoicesDetails");

            migrationBuilder.RenameTable(
                name: "InvoicesDetails",
                newName: "LeadsDetails");

            migrationBuilder.RenameIndex(
                name: "IX_InvoicesDetails_UnitId",
                table: "LeadsDetails",
                newName: "IX_LeadsDetails_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoicesDetails_ProductId",
                table: "LeadsDetails",
                newName: "IX_LeadsDetails_ProductId");

            migrationBuilder.AddColumn<string>(
                name: "CodeName",
                table: "SequencesControl",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InvoiceLeadId",
                table: "LeadsDetails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeadsDetails",
                table: "LeadsDetails",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Schools",
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
                    TranslationData = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    LeadDueDays = table.Column<long>(nullable: false),
                    AssignedWarehouseId = table.Column<long>(nullable: true),
                    ZoneId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Warehouses_AssignedWarehouseId",
                        column: x => x.AssignedWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoicesLeads",
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
                    SchoolId = table.Column<long>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    ZoneId = table.Column<long>(nullable: false),
                    DocumentNumber = table.Column<string>(maxLength: 50, nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerId = table.Column<long>(nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CashRegisterId = table.Column<long>(nullable: true),
                    ReturnedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ReceivedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AppliedCreditNoteAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    BillingDate = table.Column<DateTime>(nullable: true),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesLeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesLeads_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolContacts",
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
                    TranslationData = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Position = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    SchoolId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolContacts_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 250, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 227, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 227, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 210, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 220, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 221, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 224, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 233, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "FAC", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "VEND", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "CLI", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "COT", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "GST", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "TRF", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "ENT", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "DEV", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "DEVS", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "R", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CodeName", "CreatedDate" },
                values: new object[] { "P", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.InsertData(
                table: "SequencesControl",
                columns: new[] { "Id", "Active", "Code", "CodeName", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "NumericControl", "TranslationData" },
                values: new object[,]
                {
                    { 13L, true, (short)13, "ESC", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8911), null, null, null, "Schools", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Schools\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Schools\"}]}" },
                    { 12L, true, (short)12, "CONDUCE", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 3, 19, 21, 22, 40, 225, DateTimeKind.Local).AddTicks(8890), null, null, null, "Leads", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Leads\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Leads\"}]}" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 19, 21, 22, 40, 234, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.CreateIndex(
                name: "IX_LeadsDetails_InvoiceLeadId",
                table: "LeadsDetails",
                column: "InvoiceLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_BranchOfficeId",
                table: "InvoicesLeads",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_CurrencyId",
                table: "InvoicesLeads",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_CustomerId",
                table: "InvoicesLeads",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_InvoiceId",
                table: "InvoicesLeads",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_SchoolId",
                table: "InvoicesLeads",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_SellerId",
                table: "InvoicesLeads",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesLeads_ZoneId",
                table: "InvoicesLeads",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolContacts_SchoolId",
                table: "SchoolContacts",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_AssignedWarehouseId",
                table: "Schools",
                column: "AssignedWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CurrencyId",
                table: "Schools",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CustomerId",
                table: "Schools",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_ZoneId",
                table: "Schools",
                column: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsDetails_InvoicesLeads_InvoiceLeadId",
                table: "LeadsDetails",
                column: "InvoiceLeadId",
                principalTable: "InvoicesLeads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsDetails_Products_ProductId",
                table: "LeadsDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadsDetails_Units_UnitId",
                table: "LeadsDetails",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadsDetails_InvoicesLeads_InvoiceLeadId",
                table: "LeadsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsDetails_Products_ProductId",
                table: "LeadsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadsDetails_Units_UnitId",
                table: "LeadsDetails");

            migrationBuilder.DropTable(
                name: "InvoicesLeads");

            migrationBuilder.DropTable(
                name: "SchoolContacts");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeadsDetails",
                table: "LeadsDetails");

            migrationBuilder.DropIndex(
                name: "IX_LeadsDetails_InvoiceLeadId",
                table: "LeadsDetails");

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DropColumn(
                name: "CodeName",
                table: "SequencesControl");

            migrationBuilder.DropColumn(
                name: "InvoiceLeadId",
                table: "LeadsDetails");

            migrationBuilder.RenameTable(
                name: "LeadsDetails",
                newName: "InvoicesDetails");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsDetails_UnitId",
                table: "InvoicesDetails",
                newName: "IX_InvoicesDetails_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_LeadsDetails_ProductId",
                table: "InvoicesDetails",
                newName: "IX_InvoicesDetails_ProductId");

            migrationBuilder.AddColumn<long>(
                name: "WarehouseId",
                table: "Invoices",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ZoneId",
                table: "Invoices",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AssignedWarehouseId",
                table: "Customers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ZoneId",
                table: "Customers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InvoiceId",
                table: "InvoicesDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoicesDetails",
                table: "InvoicesDetails",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountsReceivable_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "accountState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "auth_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "billing_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "branchOffice_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashRegisterManteinance_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cashROpenClose_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "changePass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "commissions_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "core_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "currencies_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customerPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "customersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "dashboard_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "debtsToPay_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "email_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expenses_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesPayment_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "expensesRegister_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "forgotPass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "incomeReceipts_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventory_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "inventoryIn_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoices_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "login_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "logOut_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "movements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "password_input" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "pricesList_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "products_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productsMovements_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "profile_btn" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "quotes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "remember_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "reports_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resetPass_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "resultState_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "roles_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sales_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sellers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "start_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "suppliersReturns_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxes_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "taxesReport_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "TRNControl_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "units_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "user_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "users_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouse_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseTransfers_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "zones_menu" },
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 926, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 927, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 908, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 908, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 900, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 903, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 905, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 300L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 340L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 915, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 916, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 907, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2020, 3, 10, 11, 40, 19, 917, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ZoneId",
                table: "Invoices",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AssignedWarehouseId",
                table: "Customers",
                column: "AssignedWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ZoneId",
                table: "Customers",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_InvoiceId",
                table: "InvoicesDetails",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Warehouses_AssignedWarehouseId",
                table: "Customers",
                column: "AssignedWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Zones_ZoneId",
                table: "Customers",
                column: "ZoneId",
                principalTable: "Zones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Zones_ZoneId",
                table: "Invoices",
                column: "ZoneId",
                principalTable: "Zones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesDetails_Invoices_InvoiceId",
                table: "InvoicesDetails",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesDetails_Products_ProductId",
                table: "InvoicesDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoicesDetails_Units_UnitId",
                table: "InvoicesDetails",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
