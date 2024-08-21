using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIrstProject.Migrations
{
    /// <inheritdoc />
    public partial class tblbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_BookCovers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookWrittersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BookCovers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBNNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCoverId = table.Column<int>(type: "int", nullable: false),
                    BookWritterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Books", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_BookWritters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BookWritters", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_BookCovers");

            migrationBuilder.DropTable(
                name: "Tbl_Books");

            migrationBuilder.DropTable(
                name: "Tbl_BookWritters");
        }
    }
}
