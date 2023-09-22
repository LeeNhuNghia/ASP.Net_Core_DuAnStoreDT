using Microsoft.EntityFrameworkCore.Migrations;

namespace DuAnStoreDT.Migrations
{
    public partial class SeedDataAdminTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "useradmin", "passwordadmin" },
                values: new object[] { "admin1", "admin1" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "useradmin", "passwordadmin" },
                values: new object[] { "admin2", "admin2" });
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
        }
    }
}
