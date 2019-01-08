using Microsoft.EntityFrameworkCore.Migrations;

namespace DataServiceLayer.Migrations
{
    public partial class CreateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "936f80f6-0713-4cb5-90a6-e9d55863d4a2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c18aa09f-91a2-431d-b83c-869868d40345");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "cb99a53a-9314-4c7d-85c2-f303a468d4d4", "Nombre 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "41aed91e-65e9-4075-8226-51ec2b15c1dd", "Nombre 2" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "62696ce4-71c8-4f9d-a83f-738b967923fb", "Nombre 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "41aed91e-65e9-4075-8226-51ec2b15c1dd");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "62696ce4-71c8-4f9d-a83f-738b967923fb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cb99a53a-9314-4c7d-85c2-f303a468d4d4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "c18aa09f-91a2-431d-b83c-869868d40345", "Nombre 1" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { "936f80f6-0713-4cb5-90a6-e9d55863d4a2", "Nombre 2" });
        }
    }
}
