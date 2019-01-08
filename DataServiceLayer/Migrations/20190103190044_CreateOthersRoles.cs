using Microsoft.EntityFrameworkCore.Migrations;

namespace DataServiceLayer.Migrations
{
    public partial class CreateOthersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "9c290902-0f0d-45f6-9011-a01aa0f84b2d", "Nombre 1" },
                    { "e73097f8-2aa7-453c-9474-ed72d36eac7f", "Nombre 2" },
                    { "b94156a4-b313-4dda-8742-b9b76d773bd5", "Nombre 3" },
                    { "3975a581-7eef-41cc-a104-a21d9d60f405", "Nombre 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3975a581-7eef-41cc-a104-a21d9d60f405");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9c290902-0f0d-45f6-9011-a01aa0f84b2d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b94156a4-b313-4dda-8742-b9b76d773bd5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e73097f8-2aa7-453c-9474-ed72d36eac7f");

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
    }
}
