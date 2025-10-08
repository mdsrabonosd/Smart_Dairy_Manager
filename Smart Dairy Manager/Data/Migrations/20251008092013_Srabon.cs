using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart_Dairy_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class Srabon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cows",
                columns: table => new
                {
                    CowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeDay = table.Column<int>(type: "int", nullable: false),
                    AgeMonth = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cows", x => x.CowId);
                });

            migrationBuilder.CreateTable(
                name: "FeedManagements",
                columns: table => new
                {
                    FeedMGId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    FoodReports = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedManagements", x => x.FeedMGId);
                });

            migrationBuilder.CreateTable(
                name: "MeatProductions",
                columns: table => new
                {
                    MeatProductionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CowWeight = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeatProductions", x => x.MeatProductionId);
                });

            migrationBuilder.CreateTable(
                name: "VaccineApplies",
                columns: table => new
                {
                    VaccineApplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    ApplyAmmount = table.Column<double>(type: "float", nullable: false),
                    VaccineApplyMonth = table.Column<double>(type: "float", nullable: false),
                    VaccineApplyDay = table.Column<double>(type: "float", nullable: false),
                    VaccineApplyNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineApplies", x => x.VaccineApplyId);
                });

            migrationBuilder.CreateTable(
                name: "vaccines",
                columns: table => new
                {
                    VaccineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinePrice = table.Column<int>(type: "int", nullable: true),
                    VaccineAgeMonth = table.Column<int>(type: "int", nullable: false),
                    VaccineAgeDay = table.Column<int>(type: "int", nullable: false),
                    VaccineNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaccines", x => x.VaccineId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cows");

            migrationBuilder.DropTable(
                name: "FeedManagements");

            migrationBuilder.DropTable(
                name: "MeatProductions");

            migrationBuilder.DropTable(
                name: "VaccineApplies");

            migrationBuilder.DropTable(
                name: "vaccines");
        }
    }
}
