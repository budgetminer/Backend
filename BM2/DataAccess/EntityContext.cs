﻿using BM2.DataAccess.Entities;
using Digipolis.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace BM2.DataAccess {
    public class EntityContext : EntityContextBase<EntityContext>
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Level> Levels{ get; set; }
        public DbSet<HeadCount> Headcounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if (!builder.IsConfigured) {
                builder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = Budgetminer; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
           
        }
    }
}
