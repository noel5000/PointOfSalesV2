using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchOffices",
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
                    TranslationData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchOffices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
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
                    Code = table.Column<string>(maxLength: 3, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsLocalCurrency = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 2, nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Id = table.Column<long>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "MovementTypes",
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
                    Code = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningsAmounts",
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
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Order = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningsAmounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
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
                    TranslationData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
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
                    Code = table.Column<short>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
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
                    TranslationData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
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
                    Controllers = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SequencesControl",
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
                    Code = table.Column<short>(nullable: false),
                    NumericControl = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequencesControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
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
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CardId = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
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
                    Rate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TRNsControl",
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
                    Series = table.Column<string>(nullable: false),
                    Type = table.Column<string>(maxLength: 2, nullable: true),
                    Sequence = table.Column<long>(nullable: false),
                    NumericControl = table.Column<long>(nullable: false),
                    Quantity = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRNsControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
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
                    TranslationData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
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
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashRegisters",
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
                    LocationId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashRegisters_BranchOffices_LocationId",
                        column: x => x.LocationId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
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
                    BranchOfficeId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditNotes",
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
                    OriginInvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    AppliedInvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    Applied = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditNotes_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
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
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Price2 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Price3 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    DetailsClass = table.Column<string>(nullable: true),
                    IsService = table.Column<bool>(nullable: false),
                    IsCompositeProduct = table.Column<bool>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    Existence = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageKeys",
                columns: table => new
                {
                    LanguageCode = table.Column<string>(maxLength: 2, nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageKeys", x => new { x.LanguageCode, x.Key });
                    table.ForeignKey(
                        name: "FK_LanguageKeys_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
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
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleSections",
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
                    RoleId = table.Column<long>(nullable: false),
                    SectionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleSections_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleSections_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectionOperations",
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
                    SectionId = table.Column<long>(nullable: true),
                    OperationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionOperations_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectionOperations_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
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
                    PaymentTypeId = table.Column<long>(nullable: false),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    SupplierId = table.Column<long>(nullable: false),
                    ExpenseReference = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ReturnedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    GivenAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    TRN = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpensesPayments",
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
                    SupplierId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    ExpenseCurrencyId = table.Column<long>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    ExpenseReference = table.Column<string>(maxLength: 50, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OutstandingAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensesPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpensesPayments_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpensesPayments_Currencies_ExpenseCurrencyId",
                        column: x => x.ExpenseCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpensesPayments_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuppliersBalances",
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
                    SupplierId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuppliersBalances_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersBalances_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
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
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    CardId = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    ZoneId = table.Column<long>(nullable: true),
                    ComissionRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ComissionByProduct = table.Column<bool>(nullable: false),
                    FixedComission = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CashRegisterOpenings",
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
                    UserId = table.Column<Guid>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    CashRegisterId = table.Column<long>(nullable: false),
                    LocationId = table.Column<long>(nullable: false),
                    OpeningDate = table.Column<DateTime>(nullable: false),
                    MaxClosureDate = table.Column<DateTime>(nullable: false),
                    ClosureDate = table.Column<DateTime>(nullable: false),
                    OpeningDetails = table.Column<string>(nullable: true),
                    ClosureDetails = table.Column<string>(nullable: true),
                    TotalPaymentsAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OpeningClosureDifference = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(nullable: false),
                    TotalOpeningAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalClosureAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRegisterOpenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpenings_CashRegisters_CashRegisterId",
                        column: x => x.CashRegisterId,
                        principalTable: "CashRegisters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpenings_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpenings_BranchOffices_LocationId",
                        column: x => x.LocationId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
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
                    CardId = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceDueDays = table.Column<long>(nullable: false),
                    BillingAmountLimit = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CreditAmountLimit = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AssignedWarehouseId = table.Column<long>(nullable: true),
                    ZoneId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    TRNType = table.Column<string>(maxLength: 50, nullable: true),
                    TRNControlId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Warehouses_AssignedWarehouseId",
                        column: x => x.AssignedWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_TRNsControl_TRNControlId",
                        column: x => x.TRNControlId,
                        principalTable: "TRNsControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    LanguageCode = table.Column<string>(maxLength: 2, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    Mobile = table.Column<string>(maxLength: 15, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    ContentType = table.Column<string>(maxLength: 15, nullable: true),
                    Width = table.Column<double>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    Size = table.Column<double>(nullable: true),
                    BranchOfficeId = table.Column<long>(nullable: true),
                    CashRegisterId = table.Column<long>(nullable: true),
                    WarehouseId = table.Column<long>(nullable: true),
                    CashRegisterOpenningTimeHours = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_CashRegisters_CashRegisterId",
                        column: x => x.CashRegisterId,
                        principalTable: "CashRegisters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
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
                    WarehouseId = table.Column<long>(nullable: false),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventory_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventory_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryEntries",
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
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTaxes",
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
                    ProductId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTaxes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductTaxes_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuppliersReturns",
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
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitProductsEquivalences",
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
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Equivalence = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitProductsEquivalences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitProductsEquivalences_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitProductsEquivalences_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WarehousesMovements",
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
                    WarehouseId = table.Column<long>(nullable: false),
                    LocationId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    MovementType = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousesMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_BranchOffices_LocationId",
                        column: x => x.LocationId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WarehousesTransfers",
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
                    OrigingId = table.Column<long>(nullable: false),
                    DestinyId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    UnitId = table.Column<long>(nullable: false),
                    OriginId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousesTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Warehouses_DestinyId",
                        column: x => x.DestinyId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Warehouses_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTaxes",
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
                    ExpenseId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseTaxes_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseTaxes_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseTaxes_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersBalance",
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
                    CurrencyId = table.Column<long>(nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersBalance_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersBalance_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
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
                    ZoneId = table.Column<long>(nullable: false),
                    DocumentNumber = table.Column<string>(maxLength: 50, nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerId = table.Column<long>(nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CashRegisterId = table.Column<long>(nullable: true),
                    ReturnedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ReceivedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AppliedCreditNoteAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NRC = table.Column<string>(maxLength: 100, nullable: true),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TRN = table.Column<string>(maxLength: 50, nullable: true),
                    TRNType = table.Column<string>(maxLength: 2, nullable: true),
                    TRNControlId = table.Column<long>(nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    BillingDate = table.Column<DateTime>(nullable: true),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_TRNsControl_TRNControlId",
                        column: x => x.TRNControlId,
                        principalTable: "TRNsControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserOperation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationId = table.Column<long>(nullable: false),
                    SectionId = table.Column<long>(nullable: true),
                    Controllers = table.Column<string>(nullable: true),
                    SectionName = table.Column<string>(nullable: true),
                    OperationName = table.Column<string>(nullable: true),
                    OperationViewName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersClaims",
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
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(maxLength: 100, nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompositeProducts",
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
                    ProductId = table.Column<long>(nullable: false),
                    BaseProductId = table.Column<long>(nullable: false),
                    BaseProductUnitId = table.Column<long>(nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompositeProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_Products_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_UnitProductsEquivalences_BaseProductUnitId",
                        column: x => x.BaseProductUnitId,
                        principalTable: "UnitProductsEquivalences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersPayments",
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
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    InvoiceCurrencyId = table.Column<long>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OutstandingAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    CheckbookNumber = table.Column<string>(maxLength: 50, nullable: true),
                    SellerId = table.Column<long>(nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    InvoiceId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Currencies_InvoiceCurrencyId",
                        column: x => x.InvoiceCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersReturns",
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
                    InvoiceId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersReturns_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoicesDetails",
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
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Free = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Comments = table.Column<string>(maxLength: 200, nullable: true),
                    PrincipalCurrencyAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    WarehouseId = table.Column<long>(nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CreditNoteAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ParentId = table.Column<long>(nullable: true),
                    UnitId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoicesDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoicesTaxes",
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
                    InvoiceId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoicesTaxes_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesTaxes_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesTaxes_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
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
                    PaymentId = table.Column<long>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BillingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersReturnDetails",
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
                    ProductoId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    WarehouseId = table.Column<long>(nullable: true),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    Defective = table.Column<bool>(nullable: false),
                    UnitId = table.Column<long>(nullable: true),
                    CustomerReturnId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersReturnDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_CustomersReturns_CustomerReturnId",
                        column: x => x.CustomerReturnId,
                        principalTable: "CustomersReturns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_Products_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Code", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "Id", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(538), 1L, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ENGLISH\"}]}" },
                    { "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(1663), 2L, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SPANISH\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "MovementTypes",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 261, DateTimeKind.Local).AddTicks(4244), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IN\"}]}" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 261, DateTimeKind.Local).AddTicks(4493), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OUT\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { 1L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 249, DateTimeKind.Local).AddTicks(7316), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}" },
                    { 2L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3593), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}" },
                    { 3L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3732), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}" },
                    { 4L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3756), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}" },
                    { 5L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3791), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}" },
                    { 6L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3813), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READPAGED\"}]}" },
                    { 7L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 254, DateTimeKind.Local).AddTicks(3833), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 4L, true, (short)4, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3885), null, null, null, "BANKTRANSFER", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}" },
                    { 3L, true, (short)3, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3775), null, null, null, "CREDITCARD", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3739), null, null, null, "CHECK", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}" },
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 256, DateTimeKind.Local).AddTicks(3507), null, null, null, "CASH", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { 27L, true, "BranchOffice,Warehouse,User,Product,Unit", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5111), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" },
                    { 28L, true, "Product,Unit,", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5146), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}" },
                    { 29L, true, "Role", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5174), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}" },
                    { 30L, true, "Section", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5203), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}" },
                    { 31L, true, "Operation", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5237), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}" },
                    { 32L, true, "Seller,Zone,BranchOffice", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5267), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" },
                    { 33L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5300), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" },
                    { 34L, true, "Users,Role,UserRole", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5331), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" },
                    { 35L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5364), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]}" },
                    { 36L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5393), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]}" },
                    { 44L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5645), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]}" },
                    { 38L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5458), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]}" },
                    { 39L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5492), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]}" },
                    { 40L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5521), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]}" },
                    { 41L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5555), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]}" },
                    { 42L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5583), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]}" },
                    { 43L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5616), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]}" },
                    { 26L, true, "Supplier,Expense,Tax,Currency", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5083), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}" },
                    { 45L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5675), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]}" },
                    { 46L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5742), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]}" },
                    { 47L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5772), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" },
                    { 37L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5422), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]}" },
                    { 25L, true, "Invoice,Product,InvoiceDetail,Customer", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4896), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" },
                    { 22L, true, "CashRegister,User,CashRegisterOpening", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4799), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}" },
                    { 23L, true, "CashRegister,User,CashRegisterOpening", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4829), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}" },
                    { 1L, true, "User,UserClaims,Role,RoleSection,Section,SectionOperation", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(1501), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}" },
                    { 2L, true, "Customer,CustomerRate", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4048), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}" },
                    { 3L, true, "Product,ProductTax", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4099), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" },
                    { 4L, true, "Customer,CustomerPayment", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4142), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" },
                    { 5L, true, "Currency", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4173), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}" },
                    { 6L, true, "Taxe", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4213), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}" },
                    { 24L, true, "Supplier,Product,Tax,User", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4865), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}" },
                    { 8L, true, "Invoice,InvoiceDetail,Unit,UnitProductEquivalence,Seller,Currency,Customer", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4281), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" },
                    { 9L, true, "Customer,BranchOffice,Warehouse,TRNControl,Zone", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4311), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" },
                    { 10L, true, "BranchOffice,Warehouse", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4343), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}" },
                    { 11L, true, "*", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4380), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" },
                    { 7L, true, "Invoice,InvoiceDetail,TRNControl,Unit,UnitProductEquivalence,Seller,BranchOffice,Warehouse,CreditNote,Currency,Customer,Inventory,PaymentType", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4244), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" },
                    { 13L, true, "TRNControl", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4446), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}" },
                    { 14L, true, "Supplier,Expense,Tax,ExpenseTax,Currency", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4477), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" },
                    { 15L, true, "BranchOffice,Warehouse", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4512), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}" },
                    { 16L, true, "Supplier,BranchOffice,User,Currency,Tax", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4542), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" },
                    { 17L, true, "Supplier", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4634), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}" },
                    { 18L, true, "Unit", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4667), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}" },
                    { 19L, true, "User,BranchOffice,Warehouse,CashRegister", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4696), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}" },
                    { 20L, true, "PaymentType", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4734), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}" },
                    { 21L, true, "CashRegister,BranchOffice", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4770), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}" },
                    { 12L, true, "Inventory,Product,BranchOffice,Warehouse,Supplier", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4411), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "SequencesControl",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "NumericControl", "TranslationData" },
                values: new object[,]
                {
                    { 9L, true, (short)9, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7673), null, null, null, "SupplierReturns", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturns\"}]}" },
                    { 8L, true, (short)8, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7533), null, null, null, "CustomersReturns", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" },
                    { 7L, true, (short)7, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7496), null, null, null, "InventoryIncomes", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" },
                    { 6L, true, (short)6, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7450), null, null, null, "WarehouseTransfers", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" },
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(6941), null, null, null, "Invoices", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" },
                    { 4L, true, (short)4, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7367), null, null, null, "Quotes", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" },
                    { 3L, true, (short)3, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7322), null, null, null, "Customers", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7213), null, null, null, "Sellers", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" },
                    { 10L, true, (short)10, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7729), null, null, null, "CustomerPayments", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" },
                    { 5L, true, (short)5, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7403), null, null, null, "Expenses", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" },
                    { 11L, true, (short)11, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 258, DateTimeKind.Local).AddTicks(7768), null, null, null, "ExpensesPayments", 0L, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "LanguageCode", "Key", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Value" },
                values: new object[,]
                {
                    { "EN", "unitNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(3228), 1L, null, null, null, "Unit does not exist." },
                    { "ES", "cannotDeleteTax_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7952), 2L, null, null, null, "Cannot delete product tax. " },
                    { "ES", "cannotRemoveBaseProduct_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7953), 2L, null, null, null, "Cannot remove base product." },
                    { "ES", "sequenceError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7955), 2L, null, null, null, "Sequence Error." },
                    { "ES", "start_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7957), 2L, null, null, null, "Start" },
                    { "ES", "user_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7959), 2L, null, null, null, "User" },
                    { "ES", "changePass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7961), 2L, null, null, null, "Change Password" },
                    { "ES", "login_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7968), 2L, null, null, null, "Login" },
                    { "ES", "cannotEraseUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7949), 2L, null, null, null, "Cannot erase product unit." },
                    { "ES", "logOut_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7970), 2L, null, null, null, "Log out" },
                    { "ES", "core_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7973), 2L, null, null, null, "Configurations" },
                    { "ES", "branchOffice_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7976), 2L, null, null, null, "Branch Offices" },
                    { "ES", "warehouse_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7978), 2L, null, null, null, "Warehouses" },
                    { "ES", "currencies_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7980), 2L, null, null, null, "Currencies" },
                    { "ES", "suppliers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7982), 2L, null, null, null, "Suppliers" },
                    { "ES", "taxes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7984), 2L, null, null, null, "Taxes" },
                    { "ES", "units_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7986), 2L, null, null, null, "Units" },
                    { "ES", "resetPass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7971), 2L, null, null, null, "Reset Password" },
                    { "ES", "productNeedsPrimaryUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7948), 2L, null, null, null, "Product needs one primary unit." },
                    { "ES", "productNeedsUnits_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7945), 2L, null, null, null, "Product needs at least one unit." },
                    { "ES", "amountIsGreater_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7943), 2L, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "ES", "ok_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7905), 2L, null, null, null, "Operation completed successfully." },
                    { "ES", "error_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7907), 2L, null, null, null, "Error: Could not completed the current operation. " },
                    { "ES", "cannotUpdatePayment_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7910), 2L, null, null, null, "Cannot update payment. " },
                    { "ES", "invalidInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7913), 2L, null, null, null, "Invalid invoice." },
                    { "ES", "owedAmountOutdated_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7916), 2L, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "ES", "invoicePaid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7918), 2L, null, null, null, "Invoice is already paid." },
                    { "ES", "paymentNotValid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7920), 2L, null, null, null, "Payment is not valid." },
                    { "ES", "emptyInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7923), 2L, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "ES", "creditLimitReached_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7925), 2L, null, null, null, "Credit limit reached. Cannot continue." },
                    { "ES", "trnNotAvailable_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7927), 2L, null, null, null, "TRN is not available." },
                    { "ES", "outOfStock_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7928), 2L, null, null, null, "Product is out of stock." },
                    { "ES", "defWarehouseNotExit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7930), 2L, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "ES", "notExistingClass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7932), 2L, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "ES", "warehouseError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7934), 2L, null, null, null, "Warehouse does not exist." },
                    { "ES", "creditNoteNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7936), 2L, null, null, null, "Credit note does not exist. " },
                    { "ES", "creditNoteApplied_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7939), 2L, null, null, null, "Credit note is already applied." },
                    { "ES", "differentCurrency_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7941), 2L, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "ES", "TRNControl_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7987), 2L, null, null, null, "TRN Control" },
                    { "ES", "zones_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7989), 2L, null, null, null, "Zones" },
                    { "ES", "sellers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7991), 2L, null, null, null, "Sellers" },
                    { "ES", "customers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7993), 2L, null, null, null, "Customers" },
                    { "ES", "accountState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8034), 2L, null, null, null, "Account State" },
                    { "ES", "movements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8038), 2L, null, null, null, "Movements" },
                    { "ES", "resultState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8039), 2L, null, null, null, "Result State" },
                    { "ES", "taxesReport_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8041), 2L, null, null, null, "Taxes Report" },
                    { "ES", "inventoryIn_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8043), 2L, null, null, null, "Inventory Incomes" },
                    { "ES", "warehouseTransfers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8045), 2L, null, null, null, "Warehouses Transfers" },
                    { "ES", "suppliersReturns_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8052), 2L, null, null, null, "Suppliers Returns" },
                    { "ES", "auth_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8053), 2L, null, null, null, "Auth" },
                    { "ES", "users_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8056), 2L, null, null, null, "Users" },
                    { "ES", "roles_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8058), 2L, null, null, null, "Roles" },
                    { "ES", "profile_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8060), 2L, null, null, null, "Profile" },
                    { "ES", "logOut_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8062), 2L, null, null, null, "Log Out" },
                    { "ES", "dashboard_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8065), 2L, null, null, null, "Dashboard" },
                    { "ES", "remember_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8067), 2L, null, null, null, "Remember me?" },
                    { "ES", "forgotPass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8069), 2L, null, null, null, "Forgot Password?" },
                    { "ES", "password_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8070), 2L, null, null, null, "Password" },
                    { "ES", "customersReturns_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8074), 2L, null, null, null, "Customers Returns" },
                    { "ES", "customersList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8032), 2L, null, null, null, "Customers List" },
                    { "ES", "parentUnitDoesntExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7902), 2L, null, null, null, "Parent unit does not exist." },
                    { "ES", "pricesList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8030), 2L, null, null, null, "Prices List" },
                    { "ES", "productsMovements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8027), 2L, null, null, null, "Products Movements" },
                    { "ES", "products_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7994), 2L, null, null, null, "Products" },
                    { "ES", "cashRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7997), 2L, null, null, null, "Cash Registers" },
                    { "ES", "cashRegisterManteinance_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7999), 2L, null, null, null, "Manteinance" },
                    { "ES", "cashROpenClose_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8000), 2L, null, null, null, "Opening/Closing" },
                    { "ES", "billing_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8002), 2L, null, null, null, "Billing" },
                    { "ES", "quotes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8005), 2L, null, null, null, "Quotes" },
                    { "ES", "invoices_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8006), 2L, null, null, null, "Invoices" },
                    { "ES", "customerPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8008), 2L, null, null, null, "Payments" },
                    { "ES", "expenses_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8010), 2L, null, null, null, "Expenses" },
                    { "ES", "expensesRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8012), 2L, null, null, null, "Register expenses" },
                    { "ES", "expensesPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8014), 2L, null, null, null, "Payments" },
                    { "ES", "reports_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8015), 2L, null, null, null, "Reports" },
                    { "ES", "sales_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8017), 2L, null, null, null, "Sales" },
                    { "ES", "accountsReceivable_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8019), 2L, null, null, null, "Accounts Receivable" },
                    { "ES", "incomeReceipts_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8021), 2L, null, null, null, "Income Receipts" },
                    { "ES", "commissions_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8023), 2L, null, null, null, "Commissions" },
                    { "ES", "inventory_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8025), 2L, null, null, null, "Inventory" },
                    { "ES", "debtsToPay_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8028), 2L, null, null, null, "Debts To Pay" },
                    { "ES", "unitNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7898), 2L, null, null, null, "Unit does not exist." },
                    { "ES", "email_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(8072), 2L, null, null, null, "Email" },
                    { "EN", "customersReturns_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7653), 1L, null, null, null, "Customers Returns" },
                    { "EN", "cannotDeleteTax_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7488), 1L, null, null, null, "Cannot delete product tax. " },
                    { "EN", "cannotRemoveBaseProduct_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7491), 1L, null, null, null, "Cannot remove base product." },
                    { "EN", "sequenceError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7493), 1L, null, null, null, "Sequence Error." },
                    { "EN", "start_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7496), 1L, null, null, null, "Start" },
                    { "EN", "user_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7509), 1L, null, null, null, "User" },
                    { "EN", "changePass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7512), 1L, null, null, null, "Change Password" },
                    { "EN", "login_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7514), 1L, null, null, null, "Login" },
                    { "EN", "productNeedsPrimaryUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7484), 1L, null, null, null, "Product needs one primary unit." },
                    { "EN", "logOut_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7517), 1L, null, null, null, "Log out" },
                    { "EN", "core_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7522), 1L, null, null, null, "Configurations" },
                    { "EN", "branchOffice_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7525), 1L, null, null, null, "Branch Offices" },
                    { "EN", "warehouse_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7528), 1L, null, null, null, "Warehouses" },
                    { "EN", "currencies_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7530), 1L, null, null, null, "Currencies" },
                    { "EN", "suppliers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7533), 1L, null, null, null, "Suppliers" },
                    { "EN", "taxes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7535), 1L, null, null, null, "Taxes" },
                    { "EN", "units_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7538), 1L, null, null, null, "Units" },
                    { "EN", "resetPass_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7519), 1L, null, null, null, "Reset Password" },
                    { "EN", "productNeedsUnits_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7481), 1L, null, null, null, "Product needs at least one unit." },
                    { "EN", "amountIsGreater_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7478), 1L, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "EN", "differentCurrency_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7475), 1L, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "EN", "parentUnitDoesntExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7113), 1L, null, null, null, "Parent unit does not exist." },
                    { "EN", "ok_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7362), 1L, null, null, null, "Operation completed successfully." },
                    { "EN", "error_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7381), 1L, null, null, null, "Error: Could not completed the current operation. " },
                    { "EN", "cannotUpdatePayment_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7385), 1L, null, null, null, "Cannot update payment. " },
                    { "EN", "invalidInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7404), 1L, null, null, null, "Invalid invoice." },
                    { "EN", "owedAmountOutdated_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7411), 1L, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "EN", "invoicePaid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7432), 1L, null, null, null, "Invoice is already paid." },
                    { "EN", "paymentNotValid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7437), 1L, null, null, null, "Payment is not valid." },
                    { "EN", "emptyInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7446), 1L, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "EN", "creditLimitReached_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7449), 1L, null, null, null, "Credit limit reached. Cannot continue." },
                    { "EN", "trnNotAvailable_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7452), 1L, null, null, null, "TRN is not available." },
                    { "EN", "outOfStock_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7455), 1L, null, null, null, "Product is out of stock." },
                    { "EN", "defWarehouseNotExit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7458), 1L, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "EN", "notExistingClass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7462), 1L, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "EN", "warehouseError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7466), 1L, null, null, null, "Warehouse does not exist." },
                    { "EN", "creditNoteNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7468), 1L, null, null, null, "Credit note does not exist. " },
                    { "EN", "creditNoteApplied_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7473), 1L, null, null, null, "Credit note is already applied." },
                    { "EN", "TRNControl_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7540), 1L, null, null, null, "TRN Control" },
                    { "EN", "zones_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7543), 1L, null, null, null, "Zones" },
                    { "EN", "cannotEraseUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7486), 1L, null, null, null, "Cannot erase product unit." },
                    { "EN", "customers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7548), 1L, null, null, null, "Customers" },
                    { "EN", "accountState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7605), 1L, null, null, null, "Account State" },
                    { "EN", "movements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7609), 1L, null, null, null, "Movements" },
                    { "EN", "resultState_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7611), 1L, null, null, null, "Result State" },
                    { "EN", "taxesReport_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7614), 1L, null, null, null, "Taxes Report" },
                    { "EN", "inventoryIn_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7620), 1L, null, null, null, "Inventory Incomes" },
                    { "EN", "suppliersReturns_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7625), 1L, null, null, null, "Suppliers Returns" },
                    { "EN", "auth_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7629), 1L, null, null, null, "Auth" },
                    { "EN", "users_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7631), 1L, null, null, null, "Users" },
                    { "EN", "roles_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7634), 1L, null, null, null, "Roles" },
                    { "EN", "profile_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7636), 1L, null, null, null, "Profile" },
                    { "EN", "logOut_btn", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7639), 1L, null, null, null, "Log Out" },
                    { "EN", "dashboard_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7641), 1L, null, null, null, "Dashboard" },
                    { "EN", "remember_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7644), 1L, null, null, null, "Remember me?" },
                    { "EN", "forgotPass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7646), 1L, null, null, null, "Forgot Password?" },
                    { "EN", "password_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7648), 1L, null, null, null, "Password" },
                    { "EN", "sellers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7546), 1L, null, null, null, "Sellers" },
                    { "EN", "email_input", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7651), 1L, null, null, null, "Email" },
                    { "EN", "customersList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7602), 1L, null, null, null, "Customers List" },
                    { "EN", "pricesList_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7600), 1L, null, null, null, "Prices List" },
                    { "EN", "warehouseTransfers_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7623), 1L, null, null, null, "Warehouses Transfers" },
                    { "EN", "productsMovements_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7595), 1L, null, null, null, "Products Movements" },
                    { "EN", "products_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7551), 1L, null, null, null, "Products" },
                    { "EN", "debtsToPay_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7597), 1L, null, null, null, "Debts To Pay" },
                    { "EN", "cashRegisterManteinance_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7556), 1L, null, null, null, "Manteinance" },
                    { "EN", "cashROpenClose_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7558), 1L, null, null, null, "Opening/Closing" },
                    { "EN", "billing_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7561), 1L, null, null, null, "Billing" },
                    { "EN", "quotes_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7563), 1L, null, null, null, "Quotes" },
                    { "EN", "invoices_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7566), 1L, null, null, null, "Invoices" },
                    { "EN", "customerPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7568), 1L, null, null, null, "Payments" },
                    { "EN", "expenses_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7571), 1L, null, null, null, "Expenses" },
                    { "EN", "cashRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7553), 1L, null, null, null, "Cash Registers" },
                    { "EN", "expensesPayment_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7576), 1L, null, null, null, "Payments" },
                    { "EN", "reports_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7578), 1L, null, null, null, "Reports" },
                    { "EN", "sales_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7581), 1L, null, null, null, "Sales" },
                    { "EN", "accountsReceivable_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7583), 1L, null, null, null, "Accounts Receivable" },
                    { "EN", "incomeReceipts_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7586), 1L, null, null, null, "Income Receipts" },
                    { "EN", "commissions_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7588), 1L, null, null, null, "Commissions" },
                    { "EN", "inventory_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7592), 1L, null, null, null, "Inventory" },
                    { "EN", "expensesRegister_menu", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 281, DateTimeKind.Local).AddTicks(7573), 1L, null, null, null, "Register expenses" }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 254L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5295), null, null, null, 6L, 32L },
                    { 253L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5294), null, null, null, 5L, 32L },
                    { 252L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5292), null, null, null, 4L, 32L },
                    { 251L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5291), null, null, null, 3L, 32L },
                    { 250L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5289), null, null, null, 2L, 32L },
                    { 249L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5288), null, null, null, 1L, 32L },
                    { 247L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5262), null, null, null, 7L, 31L },
                    { 246L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5261), null, null, null, 6L, 31L },
                    { 242L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5255), null, null, null, 2L, 31L },
                    { 244L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5258), null, null, null, 4L, 31L },
                    { 243L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5257), null, null, null, 3L, 31L },
                    { 241L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5254), null, null, null, 1L, 31L },
                    { 239L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5233), null, null, null, 7L, 30L },
                    { 238L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5232), null, null, null, 6L, 30L },
                    { 237L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5230), null, null, null, 5L, 30L },
                    { 255L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5297), null, null, null, 7L, 32L },
                    { 245L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5260), null, null, null, 5L, 31L },
                    { 257L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5318), null, null, null, 1L, 33L },
                    { 278L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5388), null, null, null, 6L, 35L },
                    { 259L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5321), null, null, null, 3L, 33L },
                    { 236L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5229), null, null, null, 4L, 30L },
                    { 277L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5387), null, null, null, 5L, 35L },
                    { 276L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5385), null, null, null, 4L, 35L },
                    { 275L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5384), null, null, null, 3L, 35L },
                    { 274L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5382), null, null, null, 2L, 35L },
                    { 273L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5381), null, null, null, 1L, 35L },
                    { 271L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5360), null, null, null, 7L, 34L },
                    { 270L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5359), null, null, null, 6L, 34L },
                    { 269L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5357), null, null, null, 5L, 34L }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 268L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5356), null, null, null, 4L, 34L },
                    { 267L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5354), null, null, null, 3L, 34L },
                    { 266L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5349), null, null, null, 2L, 34L },
                    { 265L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5347), null, null, null, 1L, 34L },
                    { 263L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5327), null, null, null, 7L, 33L },
                    { 262L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5325), null, null, null, 6L, 33L },
                    { 261L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5324), null, null, null, 5L, 33L },
                    { 260L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5322), null, null, null, 4L, 33L },
                    { 258L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5319), null, null, null, 2L, 33L },
                    { 235L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5227), null, null, null, 3L, 30L },
                    { 189L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4889), null, null, null, 5L, 24L },
                    { 233L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5224), null, null, null, 1L, 30L },
                    { 207L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5108), null, null, null, 7L, 26L },
                    { 206L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5106), null, null, null, 6L, 26L },
                    { 205L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5105), null, null, null, 5L, 26L },
                    { 204L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5103), null, null, null, 4L, 26L },
                    { 203L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5102), null, null, null, 3L, 26L },
                    { 202L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5100), null, null, null, 2L, 26L },
                    { 201L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5099), null, null, null, 1L, 26L },
                    { 199L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5078), null, null, null, 7L, 25L },
                    { 198L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5077), null, null, null, 6L, 25L },
                    { 197L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5075), null, null, null, 5L, 25L },
                    { 196L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5074), null, null, null, 4L, 25L },
                    { 195L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5072), null, null, null, 3L, 25L },
                    { 194L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5071), null, null, null, 2L, 25L },
                    { 193L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5069), null, null, null, 1L, 25L },
                    { 191L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4892), null, null, null, 7L, 24L },
                    { 190L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4890), null, null, null, 6L, 24L },
                    { 279L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5390), null, null, null, 7L, 35L },
                    { 209L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5128), null, null, null, 1L, 27L },
                    { 234L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5226), null, null, null, 2L, 30L },
                    { 210L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5129), null, null, null, 2L, 27L },
                    { 212L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5132), null, null, null, 4L, 27L },
                    { 231L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5200), null, null, null, 7L, 29L },
                    { 230L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5198), null, null, null, 6L, 29L },
                    { 229L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5197), null, null, null, 5L, 29L },
                    { 228L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5195), null, null, null, 4L, 29L },
                    { 227L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5194), null, null, null, 3L, 29L },
                    { 226L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5193), null, null, null, 2L, 29L },
                    { 225L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5191), null, null, null, 1L, 29L },
                    { 223L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5170), null, null, null, 7L, 28L },
                    { 222L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5169), null, null, null, 6L, 28L },
                    { 221L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5167), null, null, null, 5L, 28L },
                    { 220L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5166), null, null, null, 4L, 28L },
                    { 219L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5165), null, null, null, 3L, 28L },
                    { 218L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5163), null, null, null, 2L, 28L },
                    { 217L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5162), null, null, null, 1L, 28L },
                    { 215L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5142), null, null, null, 7L, 27L },
                    { 214L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5140), null, null, null, 6L, 27L },
                    { 213L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5139), null, null, null, 5L, 27L },
                    { 211L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5131), null, null, null, 3L, 27L },
                    { 281L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5409), null, null, null, 1L, 36L },
                    { 326L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5578), null, null, null, 6L, 41L },
                    { 283L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5412), null, null, null, 3L, 36L },
                    { 349L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5669), null, null, null, 5L, 44L },
                    { 348L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5667), null, null, null, 4L, 44L },
                    { 347L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5665), null, null, null, 3L, 44L },
                    { 346L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5664), null, null, null, 2L, 44L },
                    { 345L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5663), null, null, null, 1L, 44L },
                    { 343L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5641), null, null, null, 7L, 43L },
                    { 342L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5640), null, null, null, 6L, 43L },
                    { 350L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5670), null, null, null, 6L, 44L },
                    { 341L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5638), null, null, null, 5L, 43L },
                    { 339L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5636), null, null, null, 3L, 43L },
                    { 338L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5634), null, null, null, 2L, 43L },
                    { 337L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5633), null, null, null, 1L, 43L },
                    { 335L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5608), null, null, null, 7L, 42L },
                    { 334L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5606), null, null, null, 6L, 42L },
                    { 333L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5605), null, null, null, 5L, 42L },
                    { 332L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5604), null, null, null, 4L, 42L },
                    { 340L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5637), null, null, null, 4L, 43L },
                    { 351L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5672), null, null, null, 7L, 44L },
                    { 353L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5729), null, null, null, 1L, 45L },
                    { 354L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5730), null, null, null, 2L, 45L },
                    { 188L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4887), null, null, null, 4L, 24L },
                    { 372L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5798), null, null, null, 4L, 47L },
                    { 371L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5797), null, null, null, 3L, 47L },
                    { 370L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5795), null, null, null, 2L, 47L },
                    { 369L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5794), null, null, null, 1L, 47L },
                    { 367L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5769), null, null, null, 7L, 46L },
                    { 366L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5767), null, null, null, 6L, 46L },
                    { 365L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5766), null, null, null, 5L, 46L },
                    { 364L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5764), null, null, null, 4L, 46L },
                    { 363L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5763), null, null, null, 3L, 46L },
                    { 362L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5761), null, null, null, 2L, 46L },
                    { 361L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5760), null, null, null, 1L, 46L },
                    { 359L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5738), null, null, null, 7L, 45L },
                    { 358L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5736), null, null, null, 6L, 45L },
                    { 357L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5735), null, null, null, 5L, 45L },
                    { 356L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5734), null, null, null, 4L, 45L },
                    { 355L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5732), null, null, null, 3L, 45L },
                    { 331L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5602), null, null, null, 3L, 42L },
                    { 330L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5601), null, null, null, 2L, 42L },
                    { 329L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5599), null, null, null, 1L, 42L },
                    { 327L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5579), null, null, null, 7L, 41L },
                    { 302L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5486), null, null, null, 6L, 38L },
                    { 301L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5485), null, null, null, 5L, 38L },
                    { 300L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5483), null, null, null, 4L, 38L },
                    { 299L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5482), null, null, null, 3L, 38L },
                    { 298L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5481), null, null, null, 2L, 38L },
                    { 297L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5479), null, null, null, 1L, 38L },
                    { 295L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5454), null, null, null, 7L, 37L },
                    { 294L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5452), null, null, null, 6L, 37L },
                    { 293L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5448), null, null, null, 5L, 37L },
                    { 292L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5447), null, null, null, 4L, 37L },
                    { 291L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5445), null, null, null, 3L, 37L },
                    { 290L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5444), null, null, null, 2L, 37L },
                    { 289L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5443), null, null, null, 1L, 37L },
                    { 287L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5417), null, null, null, 7L, 36L },
                    { 286L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5416), null, null, null, 6L, 36L },
                    { 285L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5415), null, null, null, 5L, 36L },
                    { 284L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5413), null, null, null, 4L, 36L },
                    { 303L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5488), null, null, null, 7L, 38L },
                    { 282L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5410), null, null, null, 2L, 36L },
                    { 305L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5509), null, null, null, 1L, 39L },
                    { 307L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5512), null, null, null, 3L, 39L },
                    { 373L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5800), null, null, null, 5L, 47L },
                    { 325L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5576), null, null, null, 5L, 41L },
                    { 324L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5575), null, null, null, 4L, 41L },
                    { 323L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5574), null, null, null, 3L, 41L },
                    { 322L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5572), null, null, null, 2L, 41L },
                    { 321L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5571), null, null, null, 1L, 41L },
                    { 319L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5551), null, null, null, 7L, 40L },
                    { 318L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5549), null, null, null, 6L, 40L },
                    { 317L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5548), null, null, null, 5L, 40L },
                    { 316L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5546), null, null, null, 4L, 40L },
                    { 315L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5545), null, null, null, 3L, 40L },
                    { 314L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5544), null, null, null, 2L, 40L },
                    { 313L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5542), null, null, null, 1L, 40L },
                    { 311L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5518), null, null, null, 7L, 39L },
                    { 310L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5516), null, null, null, 6L, 39L },
                    { 309L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5515), null, null, null, 5L, 39L },
                    { 308L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5513), null, null, null, 4L, 39L },
                    { 306L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5511), null, null, null, 2L, 39L },
                    { 187L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4886), null, null, null, 3L, 24L },
                    { 93L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4438), null, null, null, 5L, 12L },
                    { 185L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4883), null, null, null, 1L, 24L },
                    { 65L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4330), null, null, null, 1L, 9L },
                    { 63L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4307), null, null, null, 7L, 8L },
                    { 62L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4306), null, null, null, 6L, 8L },
                    { 61L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4304), null, null, null, 5L, 8L },
                    { 60L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4302), null, null, null, 4L, 8L },
                    { 59L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4301), null, null, null, 3L, 8L },
                    { 58L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4299), null, null, null, 2L, 8L },
                    { 66L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4332), null, null, null, 2L, 9L },
                    { 57L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4297), null, null, null, 1L, 8L },
                    { 54L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4275), null, null, null, 6L, 7L },
                    { 53L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4273), null, null, null, 5L, 7L },
                    { 52L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4272), null, null, null, 4L, 7L },
                    { 51L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4270), null, null, null, 3L, 7L },
                    { 50L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4263), null, null, null, 2L, 7L },
                    { 49L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4261), null, null, null, 1L, 7L },
                    { 47L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4240), null, null, null, 7L, 6L },
                    { 55L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4276), null, null, null, 7L, 7L },
                    { 67L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4333), null, null, null, 3L, 9L },
                    { 68L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4335), null, null, null, 4L, 9L },
                    { 69L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4336), null, null, null, 5L, 9L },
                    { 89L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4432), null, null, null, 1L, 12L },
                    { 87L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4407), null, null, null, 7L, 11L },
                    { 86L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4406), null, null, null, 6L, 11L },
                    { 85L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4404), null, null, null, 5L, 11L },
                    { 84L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4403), null, null, null, 4L, 11L },
                    { 83L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4401), null, null, null, 3L, 11L },
                    { 82L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4400), null, null, null, 2L, 11L },
                    { 81L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4398), null, null, null, 1L, 11L },
                    { 79L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4376), null, null, null, 7L, 10L },
                    { 78L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4374), null, null, null, 6L, 10L },
                    { 77L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4373), null, null, null, 5L, 10L },
                    { 76L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4371), null, null, null, 4L, 10L },
                    { 75L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4370), null, null, null, 3L, 10L },
                    { 74L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4367), null, null, null, 2L, 10L },
                    { 73L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4365), null, null, null, 1L, 10L },
                    { 71L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4339), null, null, null, 7L, 9L },
                    { 70L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4338), null, null, null, 6L, 9L },
                    { 46L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4239), null, null, null, 6L, 6L },
                    { 90L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4434), null, null, null, 2L, 12L },
                    { 45L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4237), null, null, null, 5L, 6L },
                    { 43L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4234), null, null, null, 3L, 6L },
                    { 18L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4128), null, null, null, 2L, 3L },
                    { 17L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4127), null, null, null, 1L, 3L },
                    { 15L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4094), null, null, null, 7L, 2L },
                    { 14L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4092), null, null, null, 6L, 2L },
                    { 13L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4091), null, null, null, 5L, 2L },
                    { 12L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4089), null, null, null, 4L, 2L },
                    { 11L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4087), null, null, null, 3L, 2L },
                    { 19L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4130), null, null, null, 3L, 3L },
                    { 10L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4085), null, null, null, 2L, 2L },
                    { 7L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3999), null, null, null, 7L, 1L },
                    { 6L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3997), null, null, null, 6L, 1L },
                    { 5L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3992), null, null, null, 5L, 1L },
                    { 4L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3989), null, null, null, 4L, 1L },
                    { 3L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3985), null, null, null, 3L, 1L },
                    { 2L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(3963), null, null, null, 2L, 1L },
                    { 1L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(2283), null, null, null, 1L, 1L },
                    { 9L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4082), null, null, null, 1L, 2L },
                    { 20L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4133), null, null, null, 4L, 3L },
                    { 21L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4134), null, null, null, 5L, 3L },
                    { 22L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4136), null, null, null, 6L, 3L },
                    { 42L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4233), null, null, null, 2L, 6L },
                    { 41L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4231), null, null, null, 1L, 6L },
                    { 39L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4209), null, null, null, 7L, 5L },
                    { 38L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4207), null, null, null, 6L, 5L },
                    { 37L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4205), null, null, null, 5L, 5L },
                    { 36L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4203), null, null, null, 4L, 5L },
                    { 35L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4202), null, null, null, 3L, 5L },
                    { 34L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4200), null, null, null, 2L, 5L },
                    { 33L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4199), null, null, null, 1L, 5L },
                    { 31L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4169), null, null, null, 7L, 4L },
                    { 30L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4168), null, null, null, 6L, 4L }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 29L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4166), null, null, null, 5L, 4L },
                    { 28L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4165), null, null, null, 4L, 4L },
                    { 27L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4163), null, null, null, 3L, 4L },
                    { 26L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4161), null, null, null, 2L, 4L },
                    { 25L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4160), null, null, null, 1L, 4L },
                    { 23L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4137), null, null, null, 7L, 3L },
                    { 44L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4236), null, null, null, 4L, 6L },
                    { 186L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4884), null, null, null, 2L, 24L },
                    { 91L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4435), null, null, null, 3L, 12L },
                    { 374L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5801), null, null, null, 6L, 47L },
                    { 159L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4766), null, null, null, 7L, 20L },
                    { 158L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4764), null, null, null, 6L, 20L },
                    { 157L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4758), null, null, null, 5L, 20L },
                    { 156L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4756), null, null, null, 4L, 20L },
                    { 155L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4755), null, null, null, 3L, 20L },
                    { 154L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4753), null, null, null, 2L, 20L },
                    { 153L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4752), null, null, null, 1L, 20L },
                    { 161L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4786), null, null, null, 1L, 21L },
                    { 151L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4730), null, null, null, 7L, 19L },
                    { 149L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4727), null, null, null, 5L, 19L },
                    { 148L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4726), null, null, null, 4L, 19L },
                    { 147L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4723), null, null, null, 3L, 19L },
                    { 146L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4721), null, null, null, 2L, 19L },
                    { 145L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4720), null, null, null, 1L, 19L },
                    { 143L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4692), null, null, null, 7L, 18L },
                    { 142L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4690), null, null, null, 6L, 18L },
                    { 150L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4729), null, null, null, 6L, 19L },
                    { 162L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4788), null, null, null, 2L, 21L },
                    { 163L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4789), null, null, null, 3L, 21L },
                    { 164L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4791), null, null, null, 4L, 21L },
                    { 183L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4861), null, null, null, 7L, 23L },
                    { 182L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4860), null, null, null, 6L, 23L },
                    { 181L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4858), null, null, null, 5L, 23L },
                    { 180L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4857), null, null, null, 4L, 23L },
                    { 179L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4855), null, null, null, 3L, 23L },
                    { 178L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4854), null, null, null, 2L, 23L },
                    { 177L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4852), null, null, null, 1L, 23L },
                    { 175L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4825), null, null, null, 7L, 22L },
                    { 174L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4823), null, null, null, 6L, 22L },
                    { 173L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4822), null, null, null, 5L, 22L },
                    { 172L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4820), null, null, null, 4L, 22L },
                    { 171L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4819), null, null, null, 3L, 22L },
                    { 170L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4817), null, null, null, 2L, 22L },
                    { 169L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4816), null, null, null, 1L, 22L },
                    { 167L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4795), null, null, null, 7L, 21L },
                    { 166L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4793), null, null, null, 6L, 21L },
                    { 165L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4792), null, null, null, 5L, 21L },
                    { 141L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4689), null, null, null, 5L, 18L },
                    { 92L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4437), null, null, null, 4L, 12L },
                    { 140L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4688), null, null, null, 4L, 18L },
                    { 138L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4685), null, null, null, 2L, 18L },
                    { 113L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4529), null, null, null, 1L, 15L },
                    { 111L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4508), null, null, null, 7L, 14L },
                    { 110L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4506), null, null, null, 6L, 14L },
                    { 109L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4505), null, null, null, 5L, 14L },
                    { 108L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4503), null, null, null, 4L, 14L },
                    { 107L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4502), null, null, null, 3L, 14L },
                    { 106L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4500), null, null, null, 2L, 14L },
                    { 105L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4499), null, null, null, 1L, 14L },
                    { 103L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4473), null, null, null, 7L, 13L },
                    { 102L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4471), null, null, null, 6L, 13L },
                    { 101L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4470), null, null, null, 5L, 13L },
                    { 100L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4468), null, null, null, 4L, 13L },
                    { 99L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4467), null, null, null, 3L, 13L },
                    { 98L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4465), null, null, null, 2L, 13L },
                    { 97L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4464), null, null, null, 1L, 13L },
                    { 95L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4441), null, null, null, 7L, 12L },
                    { 94L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4440), null, null, null, 6L, 12L },
                    { 114L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4530), null, null, null, 2L, 15L },
                    { 139L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4686), null, null, null, 3L, 18L },
                    { 115L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4531), null, null, null, 3L, 15L },
                    { 117L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4534), null, null, null, 5L, 15L },
                    { 137L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4683), null, null, null, 1L, 18L },
                    { 135L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4663), null, null, null, 7L, 17L },
                    { 134L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4661), null, null, null, 6L, 17L },
                    { 133L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4660), null, null, null, 5L, 17L },
                    { 132L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4658), null, null, null, 4L, 17L },
                    { 131L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4657), null, null, null, 3L, 17L },
                    { 130L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4656), null, null, null, 2L, 17L },
                    { 116L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4533), null, null, null, 4L, 15L },
                    { 129L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4654), null, null, null, 1L, 17L },
                    { 126L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4627), null, null, null, 6L, 16L },
                    { 125L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4625), null, null, null, 5L, 16L },
                    { 124L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4563), null, null, null, 4L, 16L },
                    { 123L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4562), null, null, null, 3L, 16L },
                    { 122L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4560), null, null, null, 2L, 16L },
                    { 121L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4559), null, null, null, 1L, 16L },
                    { 119L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4537), null, null, null, 7L, 15L },
                    { 118L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4536), null, null, null, 6L, 15L },
                    { 127L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(4629), null, null, null, 7L, 16L },
                    { 375L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 268, DateTimeKind.Local).AddTicks(5803), null, null, null, 7L, 47L }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "Address", "BirthDay", "BranchOfficeId", "CashRegisterId", "CashRegisterOpenningTimeHours", "ContentType", "CreatedBy", "CreatedByName", "CreatedDate", "Email", "Gender", "Height", "ImageData", "LanguageCode", "LastName", "Mobile", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "Password", "Phone", "Size", "UserName", "WarehouseId", "Width" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), true, "", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "", new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2020, 1, 4, 21, 16, 20, 269, DateTimeKind.Local).AddTicks(1313), "admin@admin.com", "M", null, null, "EN", "admin", "8095555555", null, null, null, "admin", "yeLiBgtdL//mX+coUwD6bw==", "8095555555", null, "admin", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_CashRegisterId",
                table: "CashRegisterOpenings",
                column: "CashRegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_CurrencyId",
                table: "CashRegisterOpenings",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_LocationId",
                table: "CashRegisterOpenings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisters_LocationId",
                table: "CashRegisters",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_BaseProductId",
                table: "CompositeProducts",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_BaseProductUnitId",
                table: "CompositeProducts",
                column: "BaseProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_CurrencyId",
                table: "CompositeProducts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_ProductId",
                table: "CompositeProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditNotes_CurrencyId",
                table: "CreditNotes",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AssignedWarehouseId",
                table: "Customers",
                column: "AssignedWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CurrencyId",
                table: "Customers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TRNControlId",
                table: "Customers",
                column: "TRNControlId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ZoneId",
                table: "Customers",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersBalance_CurrencyId",
                table: "CustomersBalance",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersBalance_CustomerId",
                table: "CustomersBalance",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_CurrencyId",
                table: "CustomersPayments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_CustomerId",
                table: "CustomersPayments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_InvoiceCurrencyId",
                table: "CustomersPayments",
                column: "InvoiceCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_InvoiceId",
                table: "CustomersPayments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_SellerId",
                table: "CustomersPayments",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_CustomerId",
                table: "CustomersReturnDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_CustomerReturnId",
                table: "CustomersReturnDetails",
                column: "CustomerReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_ProductoId",
                table: "CustomersReturnDetails",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_WarehouseId",
                table: "CustomersReturnDetails",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturns_InvoiceId",
                table: "CustomersReturns",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_BranchOfficeId",
                table: "Expenses",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CurrencyId",
                table: "Expenses",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_SupplierId",
                table: "Expenses",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_CurrencyId",
                table: "ExpensesPayments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_ExpenseCurrencyId",
                table: "ExpensesPayments",
                column: "ExpenseCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_SupplierId",
                table: "ExpensesPayments",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTaxes_CurrencyId",
                table: "ExpenseTaxes",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTaxes_ExpenseId",
                table: "ExpenseTaxes",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTaxes_TaxId",
                table: "ExpenseTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductId",
                table: "Inventory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UnitId",
                table: "Inventory",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_WarehouseId",
                table: "Inventory",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_ProductId",
                table: "InventoryEntries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_SupplierId",
                table: "InventoryEntries",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_UnitId",
                table: "InventoryEntries",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_WarehouseId",
                table: "InventoryEntries",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BranchOfficeId",
                table: "Invoices",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CurrencyId",
                table: "Invoices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SellerId",
                table: "Invoices",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_TRNControlId",
                table: "Invoices",
                column: "TRNControlId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ZoneId",
                table: "Invoices",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_InvoiceId",
                table: "InvoicesDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_ProductId",
                table: "InvoicesDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_UnitId",
                table: "InvoicesDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesTaxes_CurrencyId",
                table: "InvoicesTaxes",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesTaxes_InvoiceId",
                table: "InvoicesTaxes",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesTaxes_TaxId",
                table: "InvoicesTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_InvoiceId",
                table: "PaymentDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CurrencyId",
                table: "Products",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTaxes_ProductId",
                table: "ProductTaxes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTaxes_TaxId",
                table: "ProductTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSections_RoleId",
                table: "RoleSections",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSections_SectionId",
                table: "RoleSections",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOperations_OperationId",
                table: "SectionOperations",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOperations_SectionId",
                table: "SectionOperations",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_ZoneId",
                table: "Sellers",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersBalances_CurrencyId",
                table: "SuppliersBalances",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersBalances_SupplierId",
                table: "SuppliersBalances",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_ProductId",
                table: "SuppliersReturns",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_SupplierId",
                table: "SuppliersReturns",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_UnitId",
                table: "SuppliersReturns",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_WarehouseId",
                table: "SuppliersReturns",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitProductsEquivalences_ProductId",
                table: "UnitProductsEquivalences",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitProductsEquivalences_UnitId",
                table: "UnitProductsEquivalences",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperation_UserId",
                table: "UserOperation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchOfficeId",
                table: "Users",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CashRegisterId",
                table: "Users",
                column: "CashRegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LanguageCode",
                table: "Users",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WarehouseId",
                table: "Users",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClaims_UserId",
                table: "UsersClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_BranchOfficeId",
                table: "Warehouses",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_LocationId",
                table: "WarehousesMovements",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_ProductId",
                table: "WarehousesMovements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_UnitId",
                table: "WarehousesMovements",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_WarehouseId",
                table: "WarehousesMovements",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_DestinyId",
                table: "WarehousesTransfers",
                column: "DestinyId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_OriginId",
                table: "WarehousesTransfers",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_ProductId",
                table: "WarehousesTransfers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_UnitId",
                table: "WarehousesTransfers",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRegisterOpenings");

            migrationBuilder.DropTable(
                name: "CompositeProducts");

            migrationBuilder.DropTable(
                name: "CreditNotes");

            migrationBuilder.DropTable(
                name: "CustomersBalance");

            migrationBuilder.DropTable(
                name: "CustomersPayments");

            migrationBuilder.DropTable(
                name: "CustomersReturnDetails");

            migrationBuilder.DropTable(
                name: "ExpensesPayments");

            migrationBuilder.DropTable(
                name: "ExpenseTaxes");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "InventoryEntries");

            migrationBuilder.DropTable(
                name: "InvoicesDetails");

            migrationBuilder.DropTable(
                name: "InvoicesTaxes");

            migrationBuilder.DropTable(
                name: "LanguageKeys");

            migrationBuilder.DropTable(
                name: "MovementTypes");

            migrationBuilder.DropTable(
                name: "OpeningsAmounts");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "ProductTaxes");

            migrationBuilder.DropTable(
                name: "RoleSections");

            migrationBuilder.DropTable(
                name: "SectionOperations");

            migrationBuilder.DropTable(
                name: "SequencesControl");

            migrationBuilder.DropTable(
                name: "SuppliersBalances");

            migrationBuilder.DropTable(
                name: "SuppliersReturns");

            migrationBuilder.DropTable(
                name: "UserOperation");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UsersClaims");

            migrationBuilder.DropTable(
                name: "WarehousesMovements");

            migrationBuilder.DropTable(
                name: "WarehousesTransfers");

            migrationBuilder.DropTable(
                name: "UnitProductsEquivalences");

            migrationBuilder.DropTable(
                name: "CustomersReturns");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "CashRegisters");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "TRNsControl");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "BranchOffices");
        }
    }
}
