﻿// <auto-generated />
using BM2.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BM2.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BM2.DataAccess.Entities.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cuName")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BM2.DataAccess.Entities.Headcount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Customerid");

                    b.Property<string>("HcFtecost");

                    b.Property<int?>("Levelid");

                    b.Property<int?>("Teamid");

                    b.Property<string>("hcBudgetowner");

                    b.Property<string>("hcFteextern");

                    b.Property<string>("hcFtegr");

                    b.Property<string>("hcNofte");

                    b.Property<string>("hcYear")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("Customerid");

                    b.HasIndex("Levelid");

                    b.HasIndex("Teamid");

                    b.ToTable("Headcounts");
                });

            modelBuilder.Entity("BM2.DataAccess.Entities.Level", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Customerid");

                    b.Property<int?>("Teamid");

                    b.Property<string>("lvBudgetowner");

                    b.Property<string>("lvGrade");

                    b.Property<string>("lvName")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("Customerid");

                    b.HasIndex("Teamid");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("BM2.DataAccess.Entities.Team", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Customerid");

                    b.Property<string>("tmBudgetowner");

                    b.Property<string>("tmLocation");

                    b.Property<string>("tmMission");

                    b.Property<string>("tmName")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("Customerid");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BM2.DataAccess.Entities.Headcount", b =>
                {
                    b.HasOne("BM2.DataAccess.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid");

                    b.HasOne("BM2.DataAccess.Entities.Level", "Level")
                        .WithMany()
                        .HasForeignKey("Levelid");

                    b.HasOne("BM2.DataAccess.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("Teamid");
                });

            modelBuilder.Entity("BM2.DataAccess.Entities.Level", b =>
                {
                    b.HasOne("BM2.DataAccess.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid");

                    b.HasOne("BM2.DataAccess.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("Teamid");
                });

            modelBuilder.Entity("BM2.DataAccess.Entities.Team", b =>
                {
                    b.HasOne("BM2.DataAccess.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid");
                });
#pragma warning restore 612, 618
        }
    }
}
