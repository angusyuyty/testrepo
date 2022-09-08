using CADPLIS.Domain.Shared.Users;
using CADPLIS.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class UserEntityTypeConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("PLIS_USER");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();
            builder.Property(x => x.UId).HasColumnName("uid");
            builder.Property(x => x.UserId).HasColumnName("user_id").HasMaxLength(UserConsts.MaxUserIdLength);
            builder.Property(x => x.UserType).HasColumnName("user_type").HasMaxLength(UserConsts.MaxUserTypeLength);
            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(UserConsts.MaxPasswordLength);
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(UserConsts.MaxEmailLength);
            builder.Property(x => x.RecState).HasColumnName("rec_state").HasMaxLength(UserConsts.MaxRecStateLength).IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(UserConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(UserConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(UserConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(UserConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.Is2FAEnabled).HasColumnName("is_2FA_enabled");
            builder.Property(x => x.PasswordExpiryDate).HasColumnName("password_expiry_date");
            builder.Property(x => x.UserName).HasColumnName("user_name").HasMaxLength(UserConsts.MaxUserNameLength).IsRequired();
            builder.Property(x => x.CorpAdmin).HasColumnName("corp_admin");

        }
    }
}
