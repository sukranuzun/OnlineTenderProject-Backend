using Core.Entities.Concrete;
using DataAccess.Concrete.Configurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class DataContext: DbContext
    {

        public DbSet<Admin> admins { get; set; }
        public DbSet<BidClient> bidclients { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Tender> tenders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<OperationClaim> operationClaims { get; set; }
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb; database=OnlineTenderManagement; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BidClientEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImageEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TenderEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OperationClaimEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserOperationClaimEntityConfiguration).Assembly);
        }

    }
}
