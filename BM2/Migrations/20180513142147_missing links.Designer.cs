﻿// <auto-generated />
using BM2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BM2.Migrations
{
    [DbContext(typeof(BMContext))]
    [Migration("20180513142147_missing links")]
    partial class missinglinks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BM2.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<int>("ActivityGroupId");

                    b.Property<int>("IndividualId")
                        .HasColumnName("individual_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("TeamId")
                        .HasColumnName("team_id")
                        .HasColumnType("numeric(28, 0)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityGroupId");

                    b.HasIndex("IndividualId");

                    b.HasIndex("TeamId");

                    b.ToTable("activity");
                });

            modelBuilder.Entity("BM2.ActivityCosts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<int>("ActivityId")
                        .HasColumnName("activity_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Comment")
                        .HasColumnName("comment")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<decimal?>("Cost")
                        .HasColumnName("cost")
                        .HasColumnType("decimal(28, 0)");

                    b.Property<int>("CosttypeId")
                        .HasColumnName("costtype_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<DateTime?>("Enddate")
                        .HasColumnName("enddate")
                        .HasColumnType("date");

                    b.Property<decimal?>("Period")
                        .HasColumnName("period")
                        .HasColumnType("decimal(28, 0)");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnName("startdate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("CosttypeId");

                    b.ToTable("activitycosts");
                });

            modelBuilder.Entity("BM2.ActivityGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Comments")
                        .HasColumnName("comments")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Groupname")
                        .HasColumnName("groupname")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("StacklayerId")
                        .HasColumnName("stacklayer_id")
                        .HasColumnType("numeric(28, 0)");

                    b.HasKey("Id");

                    b.HasIndex("StacklayerId");

                    b.ToTable("activitygroup");
                });

            modelBuilder.Entity("BM2.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<int>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Short")
                        .HasColumnName("short")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("component");
                });

            modelBuilder.Entity("BM2.Costs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Comment")
                        .HasColumnName("comment")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<decimal?>("Cost")
                        .HasColumnName("cost")
                        .HasColumnType("decimal(28, 0)");

                    b.Property<int>("CosttypeId")
                        .HasColumnName("costtype_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<DateTime?>("Enddate")
                        .HasColumnName("enddate")
                        .HasColumnType("date");

                    b.Property<int>("PartId")
                        .HasColumnName("part_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<decimal?>("Period")
                        .HasColumnName("period")
                        .HasColumnType("decimal(28, 0)");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnName("startdate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CosttypeId");

                    b.HasIndex("PartId");

                    b.ToTable("costs");
                });

            modelBuilder.Entity("BM2.CostType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Short")
                        .IsRequired()
                        .HasColumnName("short")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("costtype");
                });

            modelBuilder.Entity("BM2.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("BM2.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Short")
                        .IsRequired()
                        .HasColumnName("short")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("department");
                });

            modelBuilder.Entity("BM2.Individual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<int>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<int>("DepartmentId")
                        .HasColumnName("department_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("TeamId")
                        .HasColumnName("team_id")
                        .HasColumnType("numeric(28, 0)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TeamId");

                    b.ToTable("individual");
                });

            modelBuilder.Entity("BM2.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Comments")
                        .HasColumnName("comments")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ContractExpiryDate")
                        .HasColumnName("contractexpirydate")
                        .HasColumnType("date");

                    b.Property<string>("ContractNumber")
                        .HasColumnName("contractno")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("IndividualId")
                        .HasColumnName("individual_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Metric")
                        .HasColumnName("metric")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("PartTypeId");

                    b.Property<int>("PartsGroupId")
                        .HasColumnName("partsgroup_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<DateTime?>("Renawaldate")
                        .HasColumnName("renawaldate")
                        .HasColumnType("date");

                    b.Property<decimal?>("Units")
                        .HasColumnName("units")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<decimal?>("Vendor")
                        .HasColumnName("vendor")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<decimal?>("Yearlyincrease")
                        .HasColumnName("yearlyincrease")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("IndividualId");

                    b.HasIndex("PartTypeId");

                    b.HasIndex("PartsGroupId");

                    b.ToTable("part");
                });

            modelBuilder.Entity("BM2.PartsGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Comments")
                        .HasColumnName("comments")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int>("ComponentId")
                        .HasColumnName("component_id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Groupname")
                        .HasColumnName("groupname")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("StacklayerId")
                        .HasColumnName("stacklayer_id")
                        .HasColumnType("numeric(28, 0)");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("StacklayerId");

                    b.ToTable("partsgroup");
                });

            modelBuilder.Entity("BM2.PartType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Short")
                        .HasColumnName("short")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("parttype");
                });

            modelBuilder.Entity("BM2.Stacklayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Short")
                        .IsRequired()
                        .HasColumnName("short")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("stacklayer");
                });

            modelBuilder.Entity("BM2.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("numeric(28, 0)");

                    b.Property<string>("Comments")
                        .HasColumnName("comments")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("team");
                });

            modelBuilder.Entity("BM2.Activity", b =>
                {
                    b.HasOne("BM2.ActivityGroup", "ActivityGroup")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityGroupId")
                        .HasConstraintName("activity_activitygroup_fk");

                    b.HasOne("BM2.Individual", "Individual")
                        .WithMany("Activity")
                        .HasForeignKey("IndividualId")
                        .HasConstraintName("activity_individual_fk");

                    b.HasOne("BM2.Team", "Team")
                        .WithMany("Activity")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("activity_team_fk");
                });

            modelBuilder.Entity("BM2.ActivityCosts", b =>
                {
                    b.HasOne("BM2.Activity", "Activity")
                        .WithMany("Activitycosts")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("activitycosts_activity_fk");

                    b.HasOne("BM2.CostType", "Costtype")
                        .WithMany("Activitycosts")
                        .HasForeignKey("CosttypeId")
                        .HasConstraintName("activitycosts_costtype_fk");
                });

            modelBuilder.Entity("BM2.ActivityGroup", b =>
                {
                    b.HasOne("BM2.Stacklayer", "Stacklayer")
                        .WithMany("Activitygroup")
                        .HasForeignKey("StacklayerId")
                        .HasConstraintName("activitygroup_stacklayer_fk");
                });

            modelBuilder.Entity("BM2.Component", b =>
                {
                    b.HasOne("BM2.Customer", "Customer")
                        .WithMany("Component")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("component_customer_fk");
                });

            modelBuilder.Entity("BM2.Costs", b =>
                {
                    b.HasOne("BM2.CostType", "Costtype")
                        .WithMany("Costs")
                        .HasForeignKey("CosttypeId")
                        .HasConstraintName("costs_costtype_fk");

                    b.HasOne("BM2.Part", "Part")
                        .WithMany("Costs")
                        .HasForeignKey("PartId")
                        .HasConstraintName("costs_part_fk");
                });

            modelBuilder.Entity("BM2.Individual", b =>
                {
                    b.HasOne("BM2.Customer", "Customer")
                        .WithMany("Individual")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("individual_customer_fk");

                    b.HasOne("BM2.Department", "Department")
                        .WithMany("Individual")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("individual_department_fk");

                    b.HasOne("BM2.Team", "Team")
                        .WithMany("Individual")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("individual_team_fk");
                });

            modelBuilder.Entity("BM2.Part", b =>
                {
                    b.HasOne("BM2.Individual", "Individual")
                        .WithMany("Part")
                        .HasForeignKey("IndividualId")
                        .HasConstraintName("part_individual_fk");

                    b.HasOne("BM2.PartType", "PartType")
                        .WithMany("Parts")
                        .HasForeignKey("PartTypeId")
                        .HasConstraintName("part_partstype_fk");

                    b.HasOne("BM2.PartsGroup", "Partsgroup")
                        .WithMany("Part")
                        .HasForeignKey("PartsGroupId")
                        .HasConstraintName("part_partsgroup_fk");
                });

            modelBuilder.Entity("BM2.PartsGroup", b =>
                {
                    b.HasOne("BM2.Component", "Component")
                        .WithMany("Partsgroup")
                        .HasForeignKey("ComponentId")
                        .HasConstraintName("partsgroup_component_fk");

                    b.HasOne("BM2.Stacklayer", "Stacklayer")
                        .WithMany("Partsgroup")
                        .HasForeignKey("StacklayerId")
                        .HasConstraintName("partsgroup_stacklayer_fk");
                });
#pragma warning restore 612, 618
        }
    }
}
