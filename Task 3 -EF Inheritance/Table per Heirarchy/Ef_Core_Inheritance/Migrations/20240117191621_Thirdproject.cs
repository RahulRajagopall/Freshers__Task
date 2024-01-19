using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Core_Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class Thirdproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Percentage");

            migrationBuilder.CreateTable(
                name: "Addressdetails",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Permanentaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rollno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addressdetails", x => x.Name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addressdetails");

            migrationBuilder.CreateTable(
                name: "Percentage",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rollno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalpercentage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Percentage", x => x.Name);
                });
        }
    }
}
