using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class AdminEntityConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.AdminId);

            builder.Property(a => a.AdminId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(a => new { a.UserId });

            builder.Property(a => a.UserId).IsRequired();

        }
    }
}
