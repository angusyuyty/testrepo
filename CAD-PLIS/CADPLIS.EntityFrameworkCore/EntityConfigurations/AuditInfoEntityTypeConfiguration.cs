using CADPLIS.Domain.AuditInfos;
using CADPLIS.Domain.Shared.AuditInfos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class AuditInfoEntityTypeConfiguration : IEntityTypeConfiguration<AuditInfo>
    {
        public void Configure(EntityTypeBuilder<AuditInfo> builder)
        {
            builder.ToTable("AuditInfo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(AuditInfoConsts.MaxIdLength).IsRequired();
            builder.Property(x => x.Operator).HasMaxLength(AuditInfoConsts.MaxOperatorLength).IsRequired();
            builder.Property(x => x.Controller).HasMaxLength(AuditInfoConsts.MaxControllerLength);
            builder.Property(x => x.ActionName).HasMaxLength(AuditInfoConsts.MaxActionNameLength);
            builder.Property(x => x.Method).HasMaxLength(AuditInfoConsts.MaxMethodLength);
            builder.Property(x => x.IpAddress).HasMaxLength(AuditInfoConsts.MaxIpAddressLength);
            builder.Property(x => x.Browser).HasMaxLength(AuditInfoConsts.MaxBrowserLength);
            builder.Property(x => x.ErrorMsg).HasMaxLength(AuditInfoConsts.MaxErrorMsgLength);
        }
    }
}
