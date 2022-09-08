using CADPLIS.Domain.Roles;
using CADPLIS.Domain.Shared.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<RoleInfo>
    {
        public void Configure(EntityTypeBuilder<RoleInfo> builder)
        {
            builder.ToTable("PLIS_ROLE");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();
            builder.Property(x => x.RoleId).HasColumnName("role_id").HasMaxLength(RoleConsts.Maxrole_idLength).IsRequired();
            builder.Property(x => x.RoleDescription).HasColumnName("role_description").HasMaxLength(RoleConsts.Maxrole_descriptionLength);
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(RoleConsts.Maxcreator_user_idLength).IsRequired();
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(RoleConsts.Maxcreator_uridLength);
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_urid").HasMaxLength(RoleConsts.Maxlast_updated_uridLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_user_id").HasMaxLength(RoleConsts.Maxlast_updated_user_idLength);
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.isAMEAMA).HasColumnName("is_ame_ama");


        }
    }
}
