using Microsoft.EntityFrameworkCore.Migrations;

namespace DataServiceLayer.Migrations
{
    public partial class AddFieldCityInTableUserAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserAccount",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "UserAccount");
        }
    }
}
