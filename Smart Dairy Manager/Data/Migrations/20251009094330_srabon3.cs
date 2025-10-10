using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart_Dairy_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class srabon3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeDay",
                table: "Cows");

            migrationBuilder.DropColumn(
                name: "AgeMonth",
                table: "Cows");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeDay",
                table: "Cows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgeMonth",
                table: "Cows",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
