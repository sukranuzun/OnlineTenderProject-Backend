using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();



            builder.Property(c => c.CategoryName)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
