using Microsoft.EntityFrameworkCore.Migrations;

namespace DuAnStoreDT.Migrations
{
    public partial class SeedDataSanPham : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "masp", "giacu", "giamoi", "hinhanh", "madm", "mancc", "tensp" },
                values: new object[,]
                {
                    { "SP01", 31990000, 22990000, "img_StoreDienThoai\\7.jpg", "DM1", "NSS", "Samsung Galaxy S23 Ultra 256GB" },
                    { "SP15", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP14", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP13", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP12", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP11", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP10", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP16", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP09", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP07", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop ASUS TUF Gaming F15 FX506HC-HN144W" },
                    { "SP06", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP05", 50990000, 47000000, "img_StoreDienThoai\\1.jpg", "DM1", "NSS", "iPhone 13 Pro Max 128GB | Chính hãng VN/A" },
                    { "SP04", 50990000, 47000000, "img_StoreDienThoai\\1.jpg", "DM1", "NSS", "iPhone 13 Pro Max 128GB | Chính hãng VN/A" },
                    { "SP03", 50990000, 47000000, "img_StoreDienThoai\\1.jpg", "DM1", "NSS", "iPhone 13 Pro Max 128GB | Chính hãng VN/A" },
                    { "SP02", 20990000, 17000000, "img_StoreDienThoai\\9.jpg", "DM1", "NSS", "Samsung Galaxy A54 5G 8GB 128GB" },
                    { "SP08", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" },
                    { "SP17", 26990000, 17000000, "img_StoreDienThoai\\15.jpg", "DM2", "NSS", "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP01");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP02");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP03");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP04");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP05");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP06");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP07");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP08");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP09");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP10");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP11");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP12");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP13");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP14");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP15");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP16");

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "masp",
                keyValue: "SP17");
        }
    }
}
