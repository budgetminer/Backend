using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BudgetMiner.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "main");

            migrationBuilder.CreateTable(
                name: "costtype",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    @short = table.Column<string>(name: "short", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costtype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "department",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    @short = table.Column<string>(name: "short", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parttype",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    @short = table.Column<string>(name: "short", type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parttype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stacklayer",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    @short = table.Column<string>(name: "short", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stacklayer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "team",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "component",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    @short = table.Column<string>(name: "short", type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_component", x => x.id);
                    table.ForeignKey(
                        name: "component_customer_fk",
                        column: x => x.customer_id,
                        principalSchema: "main",
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activitygroup",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    groupname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stacklayer_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activitygroup", x => x.id);
                    table.ForeignKey(
                        name: "activitygroup_stacklayer_fk",
                        column: x => x.stacklayer_id,
                        principalSchema: "main",
                        principalTable: "stacklayer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "individual",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    firstname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    lastname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    team_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_individual", x => x.id);
                    table.ForeignKey(
                        name: "individual_customer_fk",
                        column: x => x.customer_id,
                        principalSchema: "main",
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "individual_department_fk",
                        column: x => x.department_id,
                        principalSchema: "main",
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "individual_team_fk",
                        column: x => x.team_id,
                        principalSchema: "main",
                        principalTable: "team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "partsgroup",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    component_id = table.Column<int>(type: "int", nullable: false),
                    groupname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stacklayer_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partsgroup", x => x.id);
                    table.ForeignKey(
                        name: "partsgroup_component_fk",
                        column: x => x.component_id,
                        principalSchema: "main",
                        principalTable: "component",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "partsgroup_stacklayer_fk",
                        column: x => x.stacklayer_id,
                        principalSchema: "main",
                        principalTable: "stacklayer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activity",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityGroupId = table.Column<int>(type: "int", nullable: false),
                    individual_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    team_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activity", x => x.id);
                    table.ForeignKey(
                        name: "activity_activitygroup_fk",
                        column: x => x.ActivityGroupId,
                        principalSchema: "main",
                        principalTable: "activitygroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "activity_individual_fk",
                        column: x => x.individual_id,
                        principalSchema: "main",
                        principalTable: "individual",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "activity_team_fk",
                        column: x => x.team_id,
                        principalSchema: "main",
                        principalTable: "team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "part",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    contractexpirydate = table.Column<DateTime>(type: "date", nullable: true),
                    contractno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    individual_id = table.Column<int>(type: "int", nullable: false),
                    metric = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PartTypeId = table.Column<int>(type: "int", nullable: false),
                    partsgroup_id = table.Column<int>(type: "int", nullable: false),
                    renawaldate = table.Column<DateTime>(type: "date", nullable: true),
                    units = table.Column<decimal>(type: "numeric(28, 0)", nullable: true),
                    vendor = table.Column<decimal>(type: "numeric(28, 0)", nullable: true),
                    yearlyincrease = table.Column<decimal>(type: "numeric(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_part", x => x.id);
                    table.ForeignKey(
                        name: "part_individual_fk",
                        column: x => x.individual_id,
                        principalSchema: "main",
                        principalTable: "individual",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "part_partstype_fk",
                        column: x => x.PartTypeId,
                        principalSchema: "main",
                        principalTable: "parttype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "part_partsgroup_fk",
                        column: x => x.partsgroup_id,
                        principalSchema: "main",
                        principalTable: "partsgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activitycosts",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    activity_id = table.Column<int>(type: "int", nullable: false),
                    comment = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    cost = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    costtype_id = table.Column<int>(type: "int", nullable: false),
                    enddate = table.Column<DateTime>(type: "date", nullable: true),
                    period = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    startdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activitycosts", x => x.id);
                    table.ForeignKey(
                        name: "activitycosts_activity_fk",
                        column: x => x.activity_id,
                        principalSchema: "main",
                        principalTable: "activity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "activitycosts_costtype_fk",
                        column: x => x.costtype_id,
                        principalSchema: "main",
                        principalTable: "costtype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "costs",
                schema: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comment = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    cost = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    costtype_id = table.Column<int>(type: "int", nullable: false),
                    enddate = table.Column<DateTime>(type: "date", nullable: true),
                    part_id = table.Column<int>(type: "int", nullable: false),
                    period = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    startdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costs", x => x.id);
                    table.ForeignKey(
                        name: "costs_costtype_fk",
                        column: x => x.costtype_id,
                        principalSchema: "main",
                        principalTable: "costtype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "costs_part_fk",
                        column: x => x.part_id,
                        principalSchema: "main",
                        principalTable: "part",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activity_ActivityGroupId",
                schema: "main",
                table: "activity",
                column: "ActivityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_activity_individual_id",
                schema: "main",
                table: "activity",
                column: "individual_id");

            migrationBuilder.CreateIndex(
                name: "IX_activity_team_id",
                schema: "main",
                table: "activity",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_activitycosts_activity_id",
                schema: "main",
                table: "activitycosts",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_activitycosts_costtype_id",
                schema: "main",
                table: "activitycosts",
                column: "costtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_activitygroup_stacklayer_id",
                schema: "main",
                table: "activitygroup",
                column: "stacklayer_id");

            migrationBuilder.CreateIndex(
                name: "IX_component_customer_id",
                schema: "main",
                table: "component",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_costs_costtype_id",
                schema: "main",
                table: "costs",
                column: "costtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_costs_part_id",
                schema: "main",
                table: "costs",
                column: "part_id");

            migrationBuilder.CreateIndex(
                name: "IX_individual_customer_id",
                schema: "main",
                table: "individual",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_individual_department_id",
                schema: "main",
                table: "individual",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_individual_team_id",
                schema: "main",
                table: "individual",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_part_individual_id",
                schema: "main",
                table: "part",
                column: "individual_id");

            migrationBuilder.CreateIndex(
                name: "IX_part_PartTypeId",
                schema: "main",
                table: "part",
                column: "PartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_part_partsgroup_id",
                schema: "main",
                table: "part",
                column: "partsgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_partsgroup_component_id",
                schema: "main",
                table: "partsgroup",
                column: "component_id");

            migrationBuilder.CreateIndex(
                name: "IX_partsgroup_stacklayer_id",
                schema: "main",
                table: "partsgroup",
                column: "stacklayer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activitycosts",
                schema: "main");

            migrationBuilder.DropTable(
                name: "costs",
                schema: "main");

            migrationBuilder.DropTable(
                name: "activity",
                schema: "main");

            migrationBuilder.DropTable(
                name: "costtype",
                schema: "main");

            migrationBuilder.DropTable(
                name: "part",
                schema: "main");

            migrationBuilder.DropTable(
                name: "activitygroup",
                schema: "main");

            migrationBuilder.DropTable(
                name: "individual",
                schema: "main");

            migrationBuilder.DropTable(
                name: "parttype",
                schema: "main");

            migrationBuilder.DropTable(
                name: "partsgroup",
                schema: "main");

            migrationBuilder.DropTable(
                name: "department",
                schema: "main");

            migrationBuilder.DropTable(
                name: "team",
                schema: "main");

            migrationBuilder.DropTable(
                name: "component",
                schema: "main");

            migrationBuilder.DropTable(
                name: "stacklayer",
                schema: "main");

            migrationBuilder.DropTable(
                name: "customer",
                schema: "main");
        }
    }
}
