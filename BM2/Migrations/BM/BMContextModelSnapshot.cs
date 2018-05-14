﻿// <auto-generated />
using BM2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BM2.Migrations.BM
{
    [DbContext(typeof(BMContext))]
    partial class BMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("main")
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Activity", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.ActivityCosts", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.ActivityGroup", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Component", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Costs", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.CostType", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Customer", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Department", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Individual", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Part", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.PartsGroup", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.PartType", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Stacklayer", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Team", b =>
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

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Activity", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.ActivityGroup", "ActivityGroup")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityGroupId")
                        .HasConstraintName("activity_activitygroup_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.Individual", "Individual")
                        .WithMany("Activities")
                        .HasForeignKey("IndividualId")
                        .HasConstraintName("activity_individual_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.Team", "Team")
                        .WithMany("Activities")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("activity_team_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.ActivityCosts", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.Activity", "Activity")
                        .WithMany("ActivityCosts")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("activitycosts_activity_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.CostType", "Costtype")
                        .WithMany("ActivityCosts")
                        .HasForeignKey("CosttypeId")
                        .HasConstraintName("activitycosts_costtype_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.ActivityGroup", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.Stacklayer", "Stacklayer")
                        .WithMany("ActivityGroups")
                        .HasForeignKey("StacklayerId")
                        .HasConstraintName("activitygroup_stacklayer_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Component", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.Customer", "Customer")
                        .WithMany("Components")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("component_customer_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Costs", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.CostType", "Costtype")
                        .WithMany("Costs")
                        .HasForeignKey("CosttypeId")
                        .HasConstraintName("costs_costtype_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.Part", "Part")
                        .WithMany("Costs")
                        .HasForeignKey("PartId")
                        .HasConstraintName("costs_part_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Individual", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.Customer", "Customer")
                        .WithMany("Individuals")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("individual_customer_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.Department", "Department")
                        .WithMany("Individuals")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("individual_department_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.Team", "Team")
                        .WithMany("Individuals")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("individual_team_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.Part", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.Individual", "Individual")
                        .WithMany("Parts")
                        .HasForeignKey("IndividualId")
                        .HasConstraintName("part_individual_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.PartType", "PartType")
                        .WithMany("Parts")
                        .HasForeignKey("PartTypeId")
                        .HasConstraintName("part_partstype_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.PartsGroup", "Partsgroup")
                        .WithMany("Parts")
                        .HasForeignKey("PartsGroupId")
                        .HasConstraintName("part_partsgroup_fk");
                });

            modelBuilder.Entity("BM2.DataAccess.BMEntities.PartsGroup", b =>
                {
                    b.HasOne("BM2.DataAccess.BMEntities.Component", "Component")
                        .WithMany("PartsGroups")
                        .HasForeignKey("ComponentId")
                        .HasConstraintName("partsgroup_component_fk");

                    b.HasOne("BM2.DataAccess.BMEntities.Stacklayer", "Stacklayer")
                        .WithMany("PartsGroups")
                        .HasForeignKey("StacklayerId")
                        .HasConstraintName("partsgroup_stacklayer_fk");
                });
#pragma warning restore 612, 618
        }
    }
}
