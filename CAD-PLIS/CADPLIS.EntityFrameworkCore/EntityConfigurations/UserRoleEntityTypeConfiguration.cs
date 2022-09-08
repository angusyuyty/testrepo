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
    class UserRoleEntityTypeConfiguration: IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("PLIS_USER_ROLE");
            builder.HasKey(x => x.UserRoleId);
            builder.Property(x => x.UserRoleId).HasColumnName("user_role_id").IsRequired();
            builder.Property(x => x.RoleId).HasColumnName("role_id");
            builder.Property(x => x.UserId).HasColumnName("user_id").HasMaxLength(UserRoleConsts.MaxUserIdLength);
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(UserConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(UserConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(UserConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(UserConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");

        }
    }
}
