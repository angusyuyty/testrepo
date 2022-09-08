using CADPLIS.Domain.References;
using CADPLIS.Domain.Shared.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class ReferenceValueEntityTypeConfiguration: IEntityTypeConfiguration<ReferenceValue>
    {
        public void Configure(EntityTypeBuilder<ReferenceValue> builder)
        {
            builder.ToTable("PLIS_REFERENCE_VALUE");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ReferenceType).HasColumnName("reference_type").HasMaxLength(ReferenceConsts.MaxReferenceTypeLength).IsRequired();
            builder.Property(x => x.Value).IsRequired();
        }
    }
}
