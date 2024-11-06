using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ormc.CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cf");

            migrationBuilder.CreateTable(
                name: "Driver",
                schema: "cf",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver",
                schema: "cf");
        }
    }
}
