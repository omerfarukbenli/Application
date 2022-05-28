using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spareparts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparepartCode = table.Column<int>(type: "int", nullable: false),
                    SparepartName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SparePartPrice = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spareparts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_Spareparts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SparepartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Spareparts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Spareparts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Spareparts_Spareparts_SparepartId",
                        column: x => x.SparepartId,
                        principalTable: "Spareparts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductCode", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 3434, "Asus-A-100 Laptop", 5.200m },
                    { 2, 2345, "Arçelik-E-400 Buzdolabı", 10.500m },
                    { 3, 3478, "Samsung-P-200 LCD Televizyon", 6.000m },
                    { 4, 2367, "IPhone 13-Akıllı Telefon", 11.000m },
                    { 5, 2348, "Beko-U-600 Çamaşır Makinesi", 7.000m }
                });

            migrationBuilder.InsertData(
                table: "Spareparts",
                columns: new[] { "Id", "SparePartPrice", "SparepartCode", "SparepartName" },
                values: new object[,]
                {
                    { 1, 1.000m, 6765, "4 GB bilgisayar Ram'i" },
                    { 2, 1.000m, 7645, "i9 bilgisayar İşlemcisi" },
                    { 3, 1.000m, 5423, "Buzdolabı Fan Motoru" },
                    { 4, 1.000m, 9765, "Buzdolabı TelRafı" },
                    { 5, 1.000m, 3214, "TV Anakartı" },
                    { 6, 1.000m, 3467, "TV Ayağı Aparatı" },
                    { 7, 1.000m, 1456, "Telefon Bataryası" },
                    { 8, 1.000m, 1389, "Telefon Ekranı" },
                    { 9, 1.000m, 4321, "Çamaşır Makina Kazanı" },
                    { 10, 1.000m, 4526, "Çamaşır Makine Rezistansı" }
                });

            migrationBuilder.InsertData(
                table: "Product_Spareparts",
                columns: new[] { "Id", "ProductId", "SparepartId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 },
                    { 5, 3, 5 },
                    { 6, 3, 6 },
                    { 7, 4, 7 },
                    { 8, 4, 8 },
                    { 9, 5, 9 },
                    { 10, 5, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Spareparts_ProductId",
                table: "Product_Spareparts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Spareparts_SparepartId",
                table: "Product_Spareparts",
                column: "SparepartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_Spareparts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Spareparts");
        }
    }
}
