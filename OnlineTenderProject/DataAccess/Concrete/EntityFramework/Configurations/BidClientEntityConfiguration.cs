using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class BidClientEntityConfiguration : IEntityTypeConfiguration<BidClient>
    {
        public void Configure(EntityTypeBuilder<BidClient> builder)
        {
            builder.HasKey(b => b.BidClientId);

            builder.Property(b => b.BidClientId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(b => new { b.ClientId, b.TenderId });

            builder.Property(b => b.ClientId).IsRequired();

            builder.Property(b => b.TenderId).IsRequired();

            builder.Property(b => b.UnitPrice).IsRequired();

        }
    }
}
