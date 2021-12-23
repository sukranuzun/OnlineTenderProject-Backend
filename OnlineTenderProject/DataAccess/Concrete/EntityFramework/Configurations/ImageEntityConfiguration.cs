using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class ImageEntityConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(i => i.ImageId);

            builder.Property(i => i.ImageId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(i => new { i.TenderId });

            builder.Property(i => i.TenderId).IsRequired();

            builder.Property(i => i.ImagePath)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
