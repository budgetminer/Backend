using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM2.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "miner");

            migrationBuilder.RenameTable(
                name: "team",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "stacklayer",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "parttype",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "partsgroup",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "part",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "individual",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "department",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "customer",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "costtype",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "costs",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "component",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "activitygroup",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "activitycosts",
                newSchema: "miner");

            migrationBuilder.RenameTable(
                name: "activity",
                newSchema: "miner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "team",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "stacklayer",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "parttype",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "partsgroup",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "part",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "individual",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "department",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "customer",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "costtype",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "costs",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "component",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "activitygroup",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "activitycosts",
                schema: "miner");

            migrationBuilder.RenameTable(
                name: "activity",
                schema: "miner");
        }
    }
}
