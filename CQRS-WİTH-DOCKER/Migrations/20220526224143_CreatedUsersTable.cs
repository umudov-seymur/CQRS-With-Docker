using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRS_WİTH_DOCKER.Migrations
{
    public partial class CreatedUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 100, 0, "Ramal Abaszade" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 101, 0, "Rasul Quliyev" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 103, 0, "Seymur Umudov" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
