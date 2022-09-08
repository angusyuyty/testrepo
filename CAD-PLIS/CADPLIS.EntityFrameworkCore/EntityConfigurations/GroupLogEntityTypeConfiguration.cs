using CADPLIS.Domain.Shared.SystemAuditLogs;
using CADPLIS.Domain.SystemAuditLogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class GroupLogEntityTypeConfiguration: IEntityTypeConfiguration<GroupLog>
    {
        public void Configure(EntityTypeBuilder<GroupLog> builder)
        {
            builder.ToTable("PLIS_GROUP_LOG");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GroupKey).HasColumnName("group_key").IsRequired();
            builder.Property(x => x.GroupId).HasColumnName("group_id").HasMaxLength(GroupLogConsts.MaxGroupIdLength).IsRequired();
            builder.Property(x => x.GroupDescription).HasColumnName("group_description").HasMaxLength(GroupLogConsts.MaxGroupDescriptionLength);
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(GroupLogConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(GroupLogConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.LastUpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(GroupLogConsts.MaxUpdatedByLength);
            builder.Property(x => x.LastUpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(GroupLogConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.UpdatedBy).HasColumnName("update_by").HasMaxLength(UserLogConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("update_by_role").HasMaxLength(UserLogConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.UpdatedTime).HasColumnName("updated_datetime");
            builder.Property(x => x.DataType).HasColumnName("datatype").HasMaxLength(UserLogConsts.MaxDataTypeLength).IsRequired();
            builder.Property(x => x.Action).HasColumnName("action").HasMaxLength(UserLogConsts.MaxActionLength).IsRequired();


        }
    }
}
