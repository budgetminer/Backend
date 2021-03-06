﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Context;
using BudgetMiner.DataAccess.BMEntities;

namespace BudgetMiner
{
    public partial class BMContext : EntityContextBase<BMContext>
    {
        public BMContext(DbContextOptions<BMContext> options) : base(options) {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityCosts> ActivityCosts { get; set; }
        public virtual DbSet<ActivityGroup> ActivityGroups { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Costs> Costs { get; set; }
        public virtual DbSet<CostType> CostTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departmens { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PartsGroup> PartsGroups { get; set; }
        public virtual DbSet<PartType> PartTypes { get; set; }
        public virtual DbSet<Stacklayer> StackLayers { get; set; }
        public virtual DbSet<Team> Teams { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("main");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("activity");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.IndividualId)
                    .HasColumnName("individual_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.IndividualId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("activity_individual_fk");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("activity_team_fk");

                entity.HasOne(a => a.ActivityGroup)
                    .WithMany(ag => ag.Activities)
                    .HasForeignKey(a => a.ActivityGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("activity_activitygroup_fk");
            });

            modelBuilder.Entity<ActivityCosts>(entity =>
            {
                entity.ToTable("activitycosts");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activity_id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.CosttypeId)
                    .HasColumnName("costtype_id");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityCosts)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("activitycosts_activity_fk");

                entity.HasOne(d => d.Costtype)
                    .WithMany(p => p.ActivityCosts)
                    .HasForeignKey(d => d.CosttypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("activitycosts_costtype_fk");
            });

            modelBuilder.Entity<ActivityGroup>(entity =>
            {
                entity.ToTable("activitygroup");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StacklayerId)
                    .HasColumnName("stacklayer_id");

                entity.HasOne(d => d.Stacklayer)
                    .WithMany(p => p.ActivityGroups)
                    .HasForeignKey(d => d.StacklayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("activitygroup_stacklayer_fk");
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.ToTable("component");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Short)
                    .HasColumnName("short")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Components)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("component_customer_fk");
            });

            modelBuilder.Entity<Costs>(entity =>
            {
                entity.ToTable("costs");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.CosttypeId)
                    .HasColumnName("costtype_id");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.PartId)
                    .HasColumnName("part_id");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Costtype)
                    .WithMany(p => p.Costs)
                    .HasForeignKey(d => d.CosttypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("costs_costtype_fk");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.Costs)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("costs_part_fk");
            });

            modelBuilder.Entity<CostType>(entity =>
            {
                entity.ToTable("costtype");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Short)
                    .IsRequired()
                    .HasColumnName("short")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Short)
                    .IsRequired()
                    .HasColumnName("short")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Individual>(entity =>
            {
                entity.ToTable("individual");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("department_id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Individuals)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("individual_customer_fk");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Individuals)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("individual_department_fk");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Individuals)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("individual_team_fk");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("part");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContractExpiryDate)
                    .HasColumnName("contractexpirydate")
                    .HasColumnType("date");

                entity.Property(e => e.ContractNumber)
                    .HasColumnName("contractno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndividualId)
                    .HasColumnName("individual_id");

                entity.Property(e => e.Metric)
                    .HasColumnName("metric")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PartsGroupId)
                    .HasColumnName("partsgroup_id");

                entity.Property(e => e.Renawaldate)
                    .HasColumnName("renawaldate")
                    .HasColumnType("date");

                entity.Property(e => e.Units)
                    .HasColumnName("units")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasColumnType("numeric(28, 0)");

                entity.Property(e => e.Yearlyincrease)
                    .HasColumnName("yearlyincrease")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Individual)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.IndividualId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("part_individual_fk");

                entity.HasOne(d => d.Partsgroup)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.PartsGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("part_partsgroup_fk");

                entity.HasOne(p => p.PartType)
                    .WithMany(pt => pt.Parts)
                    .HasForeignKey(p => p.PartTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("part_partstype_fk");
            });

            modelBuilder.Entity<PartsGroup>(entity =>
            {
                entity.ToTable("partsgroup");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentId)
                    .HasColumnName("component_id");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StacklayerId)
                    .HasColumnName("stacklayer_id");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.PartsGroups)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partsgroup_component_fk");

                entity.HasOne(d => d.Stacklayer)
                    .WithMany(p => p.PartsGroups)
                    .HasForeignKey(d => d.StacklayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partsgroup_stacklayer_fk");
            });

            modelBuilder.Entity<PartType>(entity =>
            {
                entity.ToTable("parttype");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Short)
                    .HasColumnName("short")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stacklayer>(entity =>
            {
                entity.ToTable("stacklayer");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Short)
                    .IsRequired()
                    .HasColumnName("short")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("team");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
