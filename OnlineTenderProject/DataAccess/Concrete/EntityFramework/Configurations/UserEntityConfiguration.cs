using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.UserId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(u => u.Email);

            builder.Property(u => u.UserName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.PasswordHash)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(u => u.PasswordSalt)
               .HasMaxLength(255)
               .IsRequired();
        }
    }
}
