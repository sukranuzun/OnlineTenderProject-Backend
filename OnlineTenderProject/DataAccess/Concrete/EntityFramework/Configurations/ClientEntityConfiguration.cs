using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class ClientEntityConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);

            builder.Property(c => c.ClientId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(c => new { c.UserId });

            builder.Property(c => c.UserId).IsRequired();

        }
    }
}
