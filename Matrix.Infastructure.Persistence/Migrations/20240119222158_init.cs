using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Matrix.Infastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaID);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "MenuList",
                columns: table => new
                {
                    MenuListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuListTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuListDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuListParentId = table.Column<int>(type: "int", nullable: false),
                    MenuListHasChildren = table.Column<bool>(type: "bit", nullable: false),
                    MenuListSortOrder = table.Column<int>(type: "int", nullable: true),
                    MenuListNavigationUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuListIconClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuList", x => x.MenuListId);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelID);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoice",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoice", x => x.RecID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserLoginID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    WareHouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WareHouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.WareHouseID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlAccountID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailAccountID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agreement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cluster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipleID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NTN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KickbackAllowed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecIncentive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KickbackMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddIncentive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPersonID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditLimit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_Areas_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Areas",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeWarranty",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    WarrantyPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarrantyFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarrantyUpto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CashBack = table.Column<double>(type: "float", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeWarranty", x => x.RecID);
                    table.ForeignKey(
                        name: "FK_TradeWarranty_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalPurchase",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Others = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalPurchase", x => x.RecID);
                    table.ForeignKey(
                        name: "FK_LocalPurchase_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WareHouseInHoldProducts",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    WareHouseID = table.Column<int>(type: "int", nullable: false),
                    QTY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouseInHoldProducts", x => x.RecID);
                    table.ForeignKey(
                        name: "FK_WareHouseInHoldProducts_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WareHouseInHoldProducts_WareHouses_WareHouseID",
                        column: x => x.WareHouseID,
                        principalTable: "WareHouses",
                        principalColumn: "WareHouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomerBrands",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomerBrands", x => x.RecID);
                    table.ForeignKey(
                        name: "FK_tblCustomerBrands_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCustomerBrands_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalPurchaseDetails",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalPurchaseID = table.Column<int>(type: "int", nullable: false),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    QTY = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WareHouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalPurchaseDetails", x => x.RecID);
                    table.ForeignKey(
                        name: "FK_LocalPurchaseDetails_LocalPurchase_LocalPurchaseID",
                        column: x => x.LocalPurchaseID,
                        principalTable: "LocalPurchase",
                        principalColumn: "RecID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocalPurchaseDetails_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocalPurchaseDetails_WareHouses_WareHouseID",
                        column: x => x.WareHouseID,
                        principalTable: "WareHouses",
                        principalColumn: "WareHouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblTradeWarrantyDetails",
                columns: table => new
                {
                    RecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeWarrantyID = table.Column<int>(type: "int", nullable: false),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    QTY = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WareHouseID = table.Column<int>(type: "int", nullable: false),
                    tblTradeWarrantyRecID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTradeWarrantyDetails", x => x.RecID);
                    table.ForeignKey(
                        name: "FK_tblTradeWarrantyDetails_LocalPurchase_TradeWarrantyID",
                        column: x => x.TradeWarrantyID,
                        principalTable: "LocalPurchase",
                        principalColumn: "RecID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblTradeWarrantyDetails_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblTradeWarrantyDetails_TradeWarranty_tblTradeWarrantyRecID",
                        column: x => x.tblTradeWarrantyRecID,
                        principalTable: "TradeWarranty",
                        principalColumn: "RecID");
                    table.ForeignKey(
                        name: "FK_tblTradeWarrantyDetails_WareHouses_WareHouseID",
                        column: x => x.WareHouseID,
                        principalTable: "WareHouses",
                        principalColumn: "WareHouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaID", "AreaCode", "AreaName", "IsActive", "OrderBy" },
                values: new object[,]
                {
                    { 1, "001", "East", 2, 1 },
                    { 2, "002", "West", 2, 2 },
                    { 3, "003", "North", 2, 3 },
                    { 4, "004", "South", 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankID", "BankName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Meezan Bank", 2 },
                    { 2, "Habib Metro", 2 },
                    { 3, "Bank Alfalah", 2 },
                    { 4, "Habib Bank", 2 },
                    { 5, "Muslim Commercial Bank Limited", 2 },
                    { 6, "National Bank of Pakistan", 2 },
                    { 7, "Allied Bank Limited", 2 },
                    { 8, "Faisal Bank", 2 }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "BrandName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Infinix", 2 },
                    { 2, "Realme", 2 },
                    { 3, "Samsung", 2 },
                    { 4, "Dell", 2 },
                    { 5, "Sony", 2 },
                    { 6, "Itel", 2 },
                    { 7, "Tecno", 2 },
                    { 8, "Huawei", 2 },
                    { 9, "Nokia", 2 },
                    { 10, "OtherBrands", 2 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelID", "IsActive", "ModelName" },
                values: new object[,]
                {
                    { 1, 2, "3310" },
                    { 2, 2, "C3" },
                    { 3, 2, "Note-30" },
                    { 4, 2, "Camon-30" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "IsActive", "SupplierName" },
                values: new object[,]
                {
                    { 1, 2, "Taha" },
                    { 2, 2, "Aaqib" },
                    { 3, 2, "Sahil" },
                    { 4, 2, "Daniyal" }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseID", "IsActive", "WareHouseName" },
                values: new object[,]
                {
                    { 1, 2, "WH-1" },
                    { 2, 2, "WH-2" },
                    { 3, 2, "WH-3" },
                    { 4, 2, "WH-4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AreaID",
                table: "Customers",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_LocalPurchase_SupplierID",
                table: "LocalPurchase",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_LocalPurchaseDetails_LocalPurchaseID",
                table: "LocalPurchaseDetails",
                column: "LocalPurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_LocalPurchaseDetails_ModelID",
                table: "LocalPurchaseDetails",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_LocalPurchaseDetails_WareHouseID",
                table: "LocalPurchaseDetails",
                column: "WareHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerBrands_BrandID",
                table: "tblCustomerBrands",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerBrands_CustomerID",
                table: "tblCustomerBrands",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTradeWarrantyDetails_ModelID",
                table: "tblTradeWarrantyDetails",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTradeWarrantyDetails_tblTradeWarrantyRecID",
                table: "tblTradeWarrantyDetails",
                column: "tblTradeWarrantyRecID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTradeWarrantyDetails_TradeWarrantyID",
                table: "tblTradeWarrantyDetails",
                column: "TradeWarrantyID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTradeWarrantyDetails_WareHouseID",
                table: "tblTradeWarrantyDetails",
                column: "WareHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_TradeWarranty_ModelID",
                table: "TradeWarranty",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_WareHouseInHoldProducts_ModelID",
                table: "WareHouseInHoldProducts",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_WareHouseInHoldProducts_WareHouseID",
                table: "WareHouseInHoldProducts",
                column: "WareHouseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "LocalPurchaseDetails");

            migrationBuilder.DropTable(
                name: "MenuList");

            migrationBuilder.DropTable(
                name: "SalesInvoice");

            migrationBuilder.DropTable(
                name: "tblCustomerBrands");

            migrationBuilder.DropTable(
                name: "tblTradeWarrantyDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WareHouseInHoldProducts");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "LocalPurchase");

            migrationBuilder.DropTable(
                name: "TradeWarranty");

            migrationBuilder.DropTable(
                name: "WareHouses");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Models");
        }
    }
}
