using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.DataAccess.Migrations
{
    public partial class changepricetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SparePartPrice",
                table: "Spareparts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.AlterColumn<int>(
                name: "ProductPrice",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductPrice",
                value: 5000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductPrice",
                value: 10500);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductPrice",
                value: 6000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductPrice",
                value: 11000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductPrice",
                value: 7000);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SparePartPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SparePartPrice",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SparePartPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 4,
                column: "SparePartPrice",
                value: 400);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 5,
                column: "SparePartPrice",
                value: 600);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 6,
                column: "SparePartPrice",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 7,
                column: "SparePartPrice",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 8,
                column: "SparePartPrice",
                value: 400);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 9,
                column: "SparePartPrice",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 10,
                column: "SparePartPrice",
                value: 500);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SparePartPrice",
                table: "Spareparts",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductPrice",
                value: 5.200m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductPrice",
                value: 10.500m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductPrice",
                value: 6.000m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductPrice",
                value: 11.000m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductPrice",
                value: 7.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 1,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 2,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 3,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 4,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 5,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 6,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 7,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 8,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 9,
                column: "SparePartPrice",
                value: 1.000m);

            migrationBuilder.UpdateData(
                table: "Spareparts",
                keyColumn: "Id",
                keyValue: 10,
                column: "SparePartPrice",
                value: 1.000m);
        }
    }
}
