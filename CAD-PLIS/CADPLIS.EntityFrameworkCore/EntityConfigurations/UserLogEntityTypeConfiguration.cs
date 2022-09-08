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
    public class UserLogEntityTypeConfiguration: IEntityTypeConfiguration<UserLog>
    {
        public void Configure(EntityTypeBuilder<UserLog> builder)
        {
            builder.ToTable("PLIS_USER_LOG");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserKey).HasColumnName("user_key").IsRequired();
            builder.Property(x => x.UId).HasColumnName("uid");
            builder.Property(x => x.UserId).HasColumnName("user_id").HasMaxLength(UserLogConsts.MaxUserIdLength);
            builder.Property(x => x.UserType).HasColumnName("user_type").HasMaxLength(UserLogConsts.MaxUserTypeLength);
            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(UserLogConsts.MaxPasswordLength);
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(UserLogConsts.MaxEmailLength);
            builder.Property(x => x.RecState).HasColumnName("rec_state").HasMaxLength(UserLogConsts.MaxRecStateLength).IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(UserLogConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(UserLogConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.LastUpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(UserLogConsts.MaxUpdatedByLength);
            builder.Property(x => x.LastUpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(UserLogConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.LastUpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.Is2FAEnabled).HasColumnName("is_2FA_enabled");
            builder.Property(x => x.PasswordExpiryDate).HasColumnName("password_expiry_date");
            builder.Property(x => x.UserName).HasColumnName("user_name").HasMaxLength(UserLogConsts.MaxUserNameLength).IsRequired();
            builder.Property(x => x.isAMEAMA).HasColumnName("is_AME_AMA");
            builder.Property(x => x.CorpAdmin).HasColumnName("corp_admin");
            builder.Property(x => x.UpdatedBy).HasColumnName("update_by").HasMaxLength(UserLogConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("update_by_role").HasMaxLength(UserLogConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.UpdatedTime).HasColumnName("updated_datetime");
            builder.Property(x => x.DataType).HasColumnName("datatype").HasMaxLength(UserLogConsts.MaxDataTypeLength).IsRequired();
            builder.Property(x => x.Action).HasColumnName("action").HasMaxLength(UserLogConsts.MaxActionLength).IsRequired();


        }
    }
}
