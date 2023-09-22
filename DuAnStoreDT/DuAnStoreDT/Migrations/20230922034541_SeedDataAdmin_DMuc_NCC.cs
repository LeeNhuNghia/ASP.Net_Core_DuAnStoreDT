using Microsoft.EntityFrameworkCore.Migrations;

namespace DuAnStoreDT.Migrations
{
    public partial class SeedDataAdmin_DMuc_NCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "useradmin", "passwordadmin" },
                values: new object[,]
                {
                    { "admin1", "admin1" },
                    { "admin2", "admin2" }
                });

            migrationBuilder.InsertData(
                table: "DanhMucs",
                columns: new[] { "madm", "tendm" },
                values: new object[,]
                {
                    { "DM1", "Điện thoại" },
                    { "DM2", "Laptop" },
                    { "DM3", "Tai nghe" }
                });

            migrationBuilder.InsertData(
                table: "NhaCungCaps",
                columns: new[] { "mancc", "tenncc" },
                values: new object[,]
                {
                    { "NSS", "SAMSUNG" },
                    { "NAP", "APPLE" },
                    { "NOP", "OPPO" },
                    { "NLN", "LENOVO" },
                    { "NMA", "MAC" },
                    { "NAS", "ASUS" },
                    { "NSN", "SONY" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "useradmin",
                keyValue: "admin1");

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "useradmin",
                keyValue: "admin2");

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "madm",
                keyValue: "DM1");

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "madm",
                keyValue: "DM2");

            migrationBuilder.DeleteData(
                table: "DanhMucs",
                keyColumn: "madm",
                keyValue: "DM3");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NAP");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NAS");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NLN");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NMA");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NOP");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NSN");

            migrationBuilder.DeleteData(
                table: "NhaCungCaps",
                keyColumn: "mancc",
                keyValue: "NSS");
        }
    }
}
