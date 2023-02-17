using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DesafioDotNetCoreKhipo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Brand = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Brand", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hauck - Johnson", new DateTime(2022, 5, 20, 0, 31, 8, 0, DateTimeKind.Unspecified), "Incredible Plastic Pants", 827.00, new DateTime(2022, 5, 22, 2, 31, 8, 0, DateTimeKind.Unspecified) },
                    { 2, "Johns - Farrell", new DateTime(2022, 5, 20, 9, 5, 23, 0, DateTimeKind.Unspecified), "Electronic Wooden Tuna", 765.00, new DateTime(2022, 5, 20, 9, 5, 23, 0, DateTimeKind.Unspecified) },
                    { 3, "Paucek, Kuvalis and Zieme", new DateTime(2022, 5, 20, 2, 7, 28, 0, DateTimeKind.Unspecified), "Awesome Steel Mouse", 143.00, new DateTime(2022, 5, 23, 22, 35, 23, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
