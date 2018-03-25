using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM2.Migrations
{
    public partial class INIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cuName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cuId = table.Column<int>(type: "int", nullable: false),
                    tmBudgetowner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tmLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tmMission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tmName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                    table.ForeignKey(
                        name: "FK_Teams_Customers_cuId",
                        column: x => x.cuId,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Customerid = table.Column<int>(type: "int", nullable: true),
                    Teamid = table.Column<int>(type: "int", nullable: true),
                    cuId = table.Column<int>(type: "int", nullable: false),
                    lvBudgetowner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lvGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lvName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.id);
                    table.ForeignKey(
                        name: "FK_Levels_Customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Levels_Teams_Teamid",
                        column: x => x.Teamid,
                        principalTable: "Teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Headcounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Customerid = table.Column<int>(type: "int", nullable: true),
                    HcFtecost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Levelid = table.Column<int>(type: "int", nullable: true),
                    Teamid = table.Column<int>(type: "int", nullable: true),
                    cuId = table.Column<int>(type: "int", nullable: false),
                    hcBudgetowner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hcFteextern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hcFtegr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hcNofte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hcYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lvId = table.Column<int>(type: "int", nullable: false),
                    tmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headcounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Headcounts_Customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Headcounts_Levels_Levelid",
                        column: x => x.Levelid,
                        principalTable: "Levels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Headcounts_Teams_Teamid",
                        column: x => x.Teamid,
                        principalTable: "Teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Headcounts_Customerid",
                table: "Headcounts",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_Headcounts_Levelid",
                table: "Headcounts",
                column: "Levelid");

            migrationBuilder.CreateIndex(
                name: "IX_Headcounts_Teamid",
                table: "Headcounts",
                column: "Teamid");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Customerid",
                table: "Levels",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Teamid",
                table: "Levels",
                column: "Teamid");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_cuId",
                table: "Teams",
                column: "cuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Headcounts");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
