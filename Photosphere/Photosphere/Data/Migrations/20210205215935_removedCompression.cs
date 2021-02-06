using Microsoft.EntityFrameworkCore.Migrations;

namespace Photosphere.Data.Migrations
{
    public partial class removedCompression : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Compression",
                table: "Photos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Compression",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
