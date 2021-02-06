using Microsoft.EntityFrameworkCore.Migrations;

namespace Photosphere.Data.Migrations
{
    public partial class removedISO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISO",
                table: "Photos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISO",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
