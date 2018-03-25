using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM2.Migrations
{
    public partial class deleteobsoleteFKS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Customers_cuId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_cuId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "cuId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "cuId",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "tmId",
                table: "Levels");

            migrationBuilder.DropColumn(
                name: "cuId",
                table: "Headcounts");

            migrationBuilder.DropColumn(
                name: "lvId",
                table: "Headcounts");

            migrationBuilder.DropColumn(
                name: "tmId",
                table: "Headcounts");

            migrationBuilder.AddColumn<int>(
                name: "Customerid",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Customerid",
                table: "Teams",
                column: "Customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Customers_Customerid",
                table: "Teams",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Customers_Customerid",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Customerid",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Customerid",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "cuId",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cuId",
                table: "Levels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tmId",
                table: "Levels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cuId",
                table: "Headcounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lvId",
                table: "Headcounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tmId",
                table: "Headcounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_cuId",
                table: "Teams",
                column: "cuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Customers_cuId",
                table: "Teams",
                column: "cuId",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
