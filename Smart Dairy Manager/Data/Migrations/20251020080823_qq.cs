using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart_Dairy_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class qq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MilkCollections",
                columns: table => new
                {
                    MilkCollectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MorningYield = table.Column<int>(type: "int", nullable: false),
                    EveningYield = table.Column<double>(type: "float", nullable: false),
                    TotalYield = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilkCollections", x => x.MilkCollectionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MilkCollections");
        }
    }
}
