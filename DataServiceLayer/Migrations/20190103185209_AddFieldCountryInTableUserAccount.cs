using Microsoft.EntityFrameworkCore.Migrations;

namespace DataServiceLayer.Migrations
{
    public partial class AddFieldCountryInTableUserAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "UserAccount",
                maxLength: 100,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "c18aa09f-91a2-431d-b83c-869868d40345", "Nombre 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "936f80f6-0713-4cb5-90a6-e9d55863d4a2", "Nombre 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "936f80f6-0713-4cb5-90a6-e9d55863d4a2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c18aa09f-91a2-431d-b83c-869868d40345");

            migrationBuilder.DropColumn(
                name: "country",
                table: "UserAccount");
        }
    }
}
