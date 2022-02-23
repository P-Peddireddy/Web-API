using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstInitialLastName_Reservations.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "Name" },
                values: new object[] { 1, "Email@Email.com", "Emily Brie" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "Name" },
                values: new object[] { 2, "Tien@abc.com", "John Tien" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
