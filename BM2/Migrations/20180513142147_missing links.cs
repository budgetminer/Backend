using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM2.Migrations
{
    public partial class missinglinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartTypeId",
                table: "part",
                type: "numeric(28, 0)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ActivityGroupId",
                table: "activity",
                type: "numeric(28, 0)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_part_PartTypeId",
                table: "part",
                column: "PartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_activity_ActivityGroupId",
                table: "activity",
                column: "ActivityGroupId");

            migrationBuilder.AddForeignKey(
                name: "activity_activitygroup_fk",
                table: "activity",
                column: "ActivityGroupId",
                principalTable: "activitygroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "part_partstype_fk",
                table: "part",
                column: "PartTypeId",
                principalTable: "parttype",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "activity_activitygroup_fk",
                table: "activity");

            migrationBuilder.DropForeignKey(
                name: "part_partstype_fk",
                table: "part");

            migrationBuilder.DropIndex(
                name: "IX_part_PartTypeId",
                table: "part");

            migrationBuilder.DropIndex(
                name: "IX_activity_ActivityGroupId",
                table: "activity");

            migrationBuilder.DropColumn(
                name: "PartTypeId",
                table: "part");

            migrationBuilder.DropColumn(
                name: "ActivityGroupId",
                table: "activity");
        }
    }
}
