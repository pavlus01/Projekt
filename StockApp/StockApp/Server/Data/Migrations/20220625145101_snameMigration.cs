using Microsoft.EntityFrameworkCore.Migrations;

namespace StockApp.Server.Data.Migrations
{
    public partial class snameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sname",
                table: "WatchedList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sname",
                table: "MyList",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sname",
                table: "WatchedList");

            migrationBuilder.DropColumn(
                name: "sname",
                table: "MyList");
        }
    }
}
