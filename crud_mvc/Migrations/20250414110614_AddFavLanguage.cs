using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_mvc.Migrations
{
    public partial class AddFavLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavLanguage",
                table: "People",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavLanguage",
                table: "People");
        }
    }
}
