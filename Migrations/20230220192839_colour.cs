using Microsoft.EntityFrameworkCore.Migrations;

namespace _WEB315_Summer22_ThemeDriving.Migrations
{
    public partial class colour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "colour",
                table: "ThemeDriving",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "modelnumber",
                table: "ThemeDriving",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "colour",
                table: "ThemeDriving");

            migrationBuilder.DropColumn(
                name: "modelnumber",
                table: "ThemeDriving");
        }
    }
}
