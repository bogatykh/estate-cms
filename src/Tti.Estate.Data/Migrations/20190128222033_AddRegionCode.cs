using Microsoft.EntityFrameworkCore.Migrations;

namespace Tti.Estate.Data.Migrations
{
    public partial class AddRegionCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Region",
                fixedLength: true,
                maxLength: 7,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Region");
        }
    }
}
