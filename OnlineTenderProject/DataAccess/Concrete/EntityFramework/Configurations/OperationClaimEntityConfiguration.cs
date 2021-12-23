using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class OperationClaimEntityConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(o => o.OperationClaimId);

            builder.Property(o => o.OperationClaimId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(o => o.OperationClaimName)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
