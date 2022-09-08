using CADPLIS.Domain.Groups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class UserRoleGroupEntityTypeConfiguration : IEntityTypeConfiguration<UserRoleGroup>
    {
        public void Configure(EntityTypeBuilder<UserRoleGroup> builder)
        {
            builder.ToTable("PLIS_USER_ROLE_GROUP");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("user_role_group_id").IsRequired();
            builder.Property(x => x.UserRoleId).HasColumnName("user_role_id").IsRequired();
            builder.Property(x => x.GroupId).HasColumnName("group_id").IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id");
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid");
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
        }
    }
}
