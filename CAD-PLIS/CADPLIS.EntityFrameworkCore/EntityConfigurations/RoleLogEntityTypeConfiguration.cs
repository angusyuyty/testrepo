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
   public  class RoleLogEntityTypeConfiguration : IEntityTypeConfiguration<RoleLog>
    {
        public void Configure(EntityTypeBuilder<RoleLog> builder)
        {
            builder.ToTable("PLIS_ROLE_LOG");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoleKey).HasColumnName("role_key").IsRequired();
            builder.Property(x => x.RoleId).HasColumnName("role_id").HasMaxLength(RoleLogConsts.Maxrole_idLength).IsRequired();
            builder.Property(x => x.RoleDescription).HasColumnName("role_description").HasMaxLength(RoleLogConsts.Maxrole_descriptionLength);
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(RoleLogConsts.Maxcreator_user_idLength).IsRequired();
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(RoleLogConsts.Maxcreator_uridLength);
            builder.Property(x => x.LastUpdatedBy).HasColumnName("last_updated_urid").HasMaxLength(RoleLogConsts.Maxlast_updated_uridLength);
            builder.Property(x => x.LastUpdatedUserRoleId).HasColumnName("last_updated_user_id").HasMaxLength(RoleLogConsts.Maxlast_updated_user_idLength);
            builder.Property(x => x.LastUpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.UpdatedBy).HasColumnName("update_by").HasMaxLength(UserLogConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("update_by_role").HasMaxLength(UserLogConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.UpdatedTime).HasColumnName("updated_datetime");
            builder.Property(x => x.DataType).HasColumnName("datatype").HasMaxLength(UserLogConsts.MaxDataTypeLength).IsRequired();
            builder.Property(x => x.Action).HasColumnName("action").HasMaxLength(UserLogConsts.MaxActionLength).IsRequired();


        }

    }
}
