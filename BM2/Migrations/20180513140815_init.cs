using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costtype",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
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
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
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
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
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
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
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
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
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
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    description = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    @short = table.Column<string>(name: "short", type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_component", x => x.id);
                    table.ForeignKey(
                        name: "component_customer_fk",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activitygroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    groupname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stacklayer_id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activitygroup", x => x.id);
                    table.ForeignKey(
                        name: "activitygroup_stacklayer_fk",
                        column: x => x.stacklayer_id,
                        principalTable: "stacklayer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "individual",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    department_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    lastname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    team_id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_individual", x => x.id);
                    table.ForeignKey(
                        name: "individual_customer_fk",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "individual_department_fk",
                        column: x => x.department_id,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "individual_team_fk",
                        column: x => x.team_id,
                        principalTable: "team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "partsgroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    component_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    groupname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stacklayer_id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partsgroup", x => x.id);
                    table.ForeignKey(
                        name: "partsgroup_component_fk",
                        column: x => x.component_id,
                        principalTable: "component",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "partsgroup_stacklayer_fk",
                        column: x => x.stacklayer_id,
                        principalTable: "stacklayer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activity",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    individual_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    team_id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activity", x => x.id);
                    table.ForeignKey(
                        name: "activity_individual_fk",
                        column: x => x.individual_id,
                        principalTable: "individual",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "activity_team_fk",
                        column: x => x.team_id,
                        principalTable: "team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "part",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    contractexpirydate = table.Column<DateTime>(type: "date", nullable: true),
                    contractno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    individual_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    metric = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    partsgroup_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
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
                        principalTable: "individual",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "part_partsgroup_fk",
                        column: x => x.partsgroup_id,
                        principalTable: "partsgroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "activitycosts",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    activity_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    comment = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    cost = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    costtype_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
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
                        principalTable: "activity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "activitycosts_costtype_fk",
                        column: x => x.costtype_id,
                        principalTable: "costtype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "costs",
                columns: table => new
                {
                    id = table.Column<int>(type: "numeric(28, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comment = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    cost = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    costtype_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    enddate = table.Column<DateTime>(type: "date", nullable: true),
                    part_id = table.Column<int>(type: "numeric(28, 0)", nullable: false),
                    period = table.Column<decimal>(type: "decimal(28, 0)", nullable: true),
                    startdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costs", x => x.id);
                    table.ForeignKey(
                        name: "costs_costtype_fk",
                        column: x => x.costtype_id,
                        principalTable: "costtype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "costs_part_fk",
                        column: x => x.part_id,
                        principalTable: "part",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activity_individual_id",
                table: "activity",
                column: "individual_id");

            migrationBuilder.CreateIndex(
                name: "IX_activity_team_id",
                table: "activity",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_activitycosts_activity_id",
                table: "activitycosts",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_activitycosts_costtype_id",
                table: "activitycosts",
                column: "costtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_activitygroup_stacklayer_id",
                table: "activitygroup",
                column: "stacklayer_id");

            migrationBuilder.CreateIndex(
                name: "IX_component_customer_id",
                table: "component",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_costs_costtype_id",
                table: "costs",
                column: "costtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_costs_part_id",
                table: "costs",
                column: "part_id");

            migrationBuilder.CreateIndex(
                name: "IX_individual_customer_id",
                table: "individual",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_individual_department_id",
                table: "individual",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_individual_team_id",
                table: "individual",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_part_individual_id",
                table: "part",
                column: "individual_id");

            migrationBuilder.CreateIndex(
                name: "IX_part_partsgroup_id",
                table: "part",
                column: "partsgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_partsgroup_component_id",
                table: "partsgroup",
                column: "component_id");

            migrationBuilder.CreateIndex(
                name: "IX_partsgroup_stacklayer_id",
                table: "partsgroup",
                column: "stacklayer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activitycosts");

            migrationBuilder.DropTable(
                name: "activitygroup");

            migrationBuilder.DropTable(
                name: "costs");

            migrationBuilder.DropTable(
                name: "parttype");

            migrationBuilder.DropTable(
                name: "activity");

            migrationBuilder.DropTable(
                name: "costtype");

            migrationBuilder.DropTable(
                name: "part");

            migrationBuilder.DropTable(
                name: "individual");

            migrationBuilder.DropTable(
                name: "partsgroup");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "team");

            migrationBuilder.DropTable(
                name: "component");

            migrationBuilder.DropTable(
                name: "stacklayer");

            migrationBuilder.DropTable(
                name: "customer");
        }
    }
}
