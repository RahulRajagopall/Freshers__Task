using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Core_Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class Secondproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Permanentaddress",
                table: "Details");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: "Percentage");

            migrationBuilder.AlterColumn<string>(
                name: "totalpercentage",
                table: "Percentage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Percentage",
                table: "Percentage",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Percentage",
                table: "Percentage");

            migrationBuilder.RenameTable(
                name: "Percentage",
                newName: "Details");

            migrationBuilder.AlterColumn<string>(
                name: "totalpercentage",
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
                name: "Permanentaddress",
                table: "Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Name");
        }
    }
}
