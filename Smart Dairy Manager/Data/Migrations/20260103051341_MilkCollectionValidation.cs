using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart_Dairy_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class MilkCollectionValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MorningYield",
                table: "MilkCollections",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MorningYield",
                table: "MilkCollections",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
