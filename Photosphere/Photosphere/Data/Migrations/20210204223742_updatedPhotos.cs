using Microsoft.EntityFrameworkCore.Migrations;

namespace Photosphere.Data.Migrations
{
    public partial class updatedPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Photos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Favourite",
                table: "Photos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LikeDislike",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "Favourite",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "LikeDislike",
                table: "Photos");
        }
    }
}
