using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM2.Migrations
{
    public partial class nieuweentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headcounts_Customers_Customerid",
                table: "Headcounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Headcounts_Levels_Levelid",
                table: "Headcounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Headcounts_Teams_Teamid",
                table: "Headcounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Customers_Customerid",
                table: "Levels");

            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Teams_Teamid",
                table: "Levels");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Customers_Customerid",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "Customerid",
                table: "Teams",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teams",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_Customerid",
                table: "Teams",
                newName: "IX_Teams_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Teamid",
                table: "Levels",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "Customerid",
                table: "Levels",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Levels",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Levels_Teamid",
                table: "Levels",
                newName: "IX_Levels_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Levels_Customerid",
                table: "Levels",
                newName: "IX_Levels_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Teamid",
                table: "Headcounts",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "Levelid",
                table: "Headcounts",
                newName: "LevelId");

            migrationBuilder.RenameColumn(
                name: "Customerid",
                table: "Headcounts",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Headcounts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Headcounts_Teamid",
                table: "Headcounts",
                newName: "IX_Headcounts_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Headcounts_Levelid",
                table: "Headcounts",
                newName: "IX_Headcounts_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Headcounts_Customerid",
                table: "Headcounts",
                newName: "IX_Headcounts_CustomerId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Cotys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    abbrev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Litys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    abbrev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Litys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    budown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    critical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cuId = table.Column<int>(type: "int", nullable: true),
                    descr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lityId = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodyr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usrcnt = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lis_Cus_cuId",
                        column: x => x.cuId,
                        principalTable: "Cus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lis_Litys_lityId",
                        column: x => x.lityId,
                        principalTable: "Litys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Licos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cotyId = table.Column<int>(type: "int", nullable: true),
                    liId = table.Column<int>(type: "int", nullable: true),
                    licco = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    maintco = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    yr = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licos_Cotys_cotyId",
                        column: x => x.cotyId,
                        principalTable: "Cotys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Licos_Lis_liId",
                        column: x => x.liId,
                        principalTable: "Lis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Licos_cotyId",
                table: "Licos",
                column: "cotyId");

            migrationBuilder.CreateIndex(
                name: "IX_Licos_liId",
                table: "Licos",
                column: "liId");

            migrationBuilder.CreateIndex(
                name: "IX_Lis_cuId",
                table: "Lis",
                column: "cuId");

            migrationBuilder.CreateIndex(
                name: "IX_Lis_lityId",
                table: "Lis",
                column: "lityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Headcounts_Customers_CustomerId",
                table: "Headcounts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headcounts_Levels_LevelId",
                table: "Headcounts",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headcounts_Teams_TeamId",
                table: "Headcounts",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Customers_CustomerId",
                table: "Levels",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Teams_TeamId",
                table: "Levels",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Customers_CustomerId",
                table: "Teams",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headcounts_Customers_CustomerId",
                table: "Headcounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Headcounts_Levels_LevelId",
                table: "Headcounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Headcounts_Teams_TeamId",
                table: "Headcounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Customers_CustomerId",
                table: "Levels");

            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Teams_TeamId",
                table: "Levels");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Customers_CustomerId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Licos");

            migrationBuilder.DropTable(
                name: "Cotys");

            migrationBuilder.DropTable(
                name: "Lis");

            migrationBuilder.DropTable(
                name: "Cus");

            migrationBuilder.DropTable(
                name: "Litys");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Teams",
                newName: "Customerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teams",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_CustomerId",
                table: "Teams",
                newName: "IX_Teams_Customerid");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Levels",
                newName: "Teamid");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Levels",
                newName: "Customerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Levels",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Levels_TeamId",
                table: "Levels",
                newName: "IX_Levels_Teamid");

            migrationBuilder.RenameIndex(
                name: "IX_Levels_CustomerId",
                table: "Levels",
                newName: "IX_Levels_Customerid");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Headcounts",
                newName: "Teamid");

            migrationBuilder.RenameColumn(
                name: "LevelId",
                table: "Headcounts",
                newName: "Levelid");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Headcounts",
                newName: "Customerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Headcounts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Headcounts_TeamId",
                table: "Headcounts",
                newName: "IX_Headcounts_Teamid");

            migrationBuilder.RenameIndex(
                name: "IX_Headcounts_LevelId",
                table: "Headcounts",
                newName: "IX_Headcounts_Levelid");

            migrationBuilder.RenameIndex(
                name: "IX_Headcounts_CustomerId",
                table: "Headcounts",
                newName: "IX_Headcounts_Customerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Headcounts_Customers_Customerid",
                table: "Headcounts",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headcounts_Levels_Levelid",
                table: "Headcounts",
                column: "Levelid",
                principalTable: "Levels",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headcounts_Teams_Teamid",
                table: "Headcounts",
                column: "Teamid",
                principalTable: "Teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Customers_Customerid",
                table: "Levels",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Teams_Teamid",
                table: "Levels",
                column: "Teamid",
                principalTable: "Teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Customers_Customerid",
                table: "Teams",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
