using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Core_Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class Thirdprogram : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Addressdetails",
                table: "Addressdetails");

            migrationBuilder.RenameTable(
                name: "Addressdetails",
                newName: "Details");

            migrationBuilder.AlterColumn<string>(
                name: "Permanentaddress",
                table: "Details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Details",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "totalpercentage",
                table: "Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "totalpercentage",
                table: "Details");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: "Addressdetails");

            migrationBuilder.AlterColumn<string>(
                name: "Permanentaddress",
                table: "Addressdetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addressdetails",
                table: "Addressdetails",
                column: "Name");
        }
    }
}
