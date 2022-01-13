using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace config.Migrations
{
    public partial class Edit_Confige : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCongige",
                table: "AppCongige");

            migrationBuilder.RenameTable(
                name: "AppCongige",
                newName: "AppConfig");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppConfig",
                table: "AppConfig",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppConfig",
                table: "AppConfig");

            migrationBuilder.RenameTable(
                name: "AppConfig",
                newName: "AppCongige");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCongige",
                table: "AppCongige",
                column: "Id");
        }
    }
}
