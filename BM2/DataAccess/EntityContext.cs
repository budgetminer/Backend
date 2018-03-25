using BM2.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BM2.DataAccess {
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options) { }
        public EntityContext() : base() { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Level> Levels{ get; set; }
        public DbSet<Headcount> Headcounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if (!builder.IsConfigured) {
                builder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = Budgetminer; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
           
        }
    }
}
