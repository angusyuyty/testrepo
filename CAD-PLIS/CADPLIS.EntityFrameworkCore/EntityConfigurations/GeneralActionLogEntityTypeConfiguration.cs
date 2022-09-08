using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.Domain.Shared.GeneralActionLogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class GeneralActionLogEntityTypeConfiguration: IEntityTypeConfiguration<GeneralActionLog>
    {
        public void Configure(EntityTypeBuilder<GeneralActionLog> builder)
        {
            builder.ToTable("PLIS_GENERAL_ACTION_LOG");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Key).HasColumnName("key").HasMaxLength(GeneralActionLogConsts.MaxKeyLength).IsRequired();
            builder.Property(x => x.SubKey).HasColumnName("sub_key").HasMaxLength(GeneralActionLogConsts.MaxSubKeyLength);
            builder.Property(x => x.Form).HasColumnName("form").HasMaxLength(GeneralActionLogConsts.MaxFormLength).IsRequired();
            builder.Property(x => x.Action).HasColumnName("action").HasMaxLength(GeneralActionLogConsts.MaxActionLength).IsRequired();
            builder.Property(x => x.ActionType).HasColumnName("action_type").HasMaxLength(GeneralActionLogConsts.MaxActionLength).IsRequired();
            builder.Property(x => x.ActionBy).HasColumnName("action_by").HasMaxLength(GeneralActionLogConsts.MaxActionByLength);
            builder.Property(x => x.ActionByRole).HasColumnName("action_by_role").HasMaxLength(GeneralActionLogConsts.MaxActionByRoleLength);
            builder.Property(x => x.ActionDatetime).HasColumnName("action_datetime");

        }

    }
}
