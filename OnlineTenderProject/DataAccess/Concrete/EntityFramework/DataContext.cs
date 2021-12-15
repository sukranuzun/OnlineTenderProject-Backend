using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class DataContext: DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Admin> admins { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<BidClient> bidclients { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Category> categories { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Client> clients { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Image> images { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Tender> tenders { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<User> users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<OperationClaim> operationClaims { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<UserOperationClaim> userOperationClaims { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public object Tender { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb; database=OnlineTenderManagement; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
