using Microsoft.EntityFrameworkCore.Migrations;

namespace DuAnStoreDT.Migrations
{
    public partial class SeedDataChiTietHDM_CTHDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "chiTietHoaDonBans",
                columns: new[] { "macthdb", "dongiaban", "masp", "soluong" },
                values: new object[,]
                {
                    { "CTB01", 22990000, "SP01", 1 },
                    { "CTB02", 17000000, "SP02", 1 },
                    { "CTB03", 17000000, "SP06", 1 },
                    { "CTB04", 17000000, "SP07", 1 }
                });

            migrationBuilder.InsertData(
                table: "chiTietHoaDonMuas",
                columns: new[] { "macthdm", "dongiamua", "masp", "soluong" },
                values: new object[,]
                {
                    { "CTM01", 21990000, "SP01", 5 },
                    { "CTM02", 10000000, "SP02", 7 },
                    { "CTM03", 13000000, "SP06", 6 },
                    { "CTM04", 16000000, "SP07", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chiTietHoaDonBans",
                keyColumn: "macthdb",
                keyValue: "CTB01");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonBans",
                keyColumn: "macthdb",
                keyValue: "CTB02");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonBans",
                keyColumn: "macthdb",
                keyValue: "CTB03");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonBans",
                keyColumn: "macthdb",
                keyValue: "CTB04");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonMuas",
                keyColumn: "macthdm",
                keyValue: "CTM01");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonMuas",
                keyColumn: "macthdm",
                keyValue: "CTM02");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonMuas",
                keyColumn: "macthdm",
                keyValue: "CTM03");

            migrationBuilder.DeleteData(
                table: "chiTietHoaDonMuas",
                keyColumn: "macthdm",
                keyValue: "CTM04");
        }
    }
}
