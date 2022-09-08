using CADPLIS.Domain.Groups;
using CADPLIS.Domain.Shared.Groups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class GroupEntityTypeConfiguration: IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("PLIS_GROUP");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GroupId).HasColumnName("group_id").HasMaxLength(GroupConsts.MaxGroupIdLength).IsRequired();
            builder.Property(x => x.GroupDescription).HasColumnName("group_description").HasMaxLength(GroupConsts.MaxGroupDescriptionLength);
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(GroupConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(GroupConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(GroupConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(GroupConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");

        }
    }
}
