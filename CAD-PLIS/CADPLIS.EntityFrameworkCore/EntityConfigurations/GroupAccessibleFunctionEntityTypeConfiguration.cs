using CADPLIS.Domain.Functions;
using CADPLIS.Domain.Shared.Functions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    class GroupAccessibleFunctionEntityTypeConfiguration: IEntityTypeConfiguration<GroupAccessibleFunction>
    {
        public void Configure(EntityTypeBuilder<GroupAccessibleFunction> builder)
        {
            builder.ToTable("PLIS_GROUP_ACCESSIBLE_FUNCTION");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GroupId).HasColumnName("group_id").HasMaxLength(GroupAccessibleFunctionConsts.MaxGroupIdLength).IsRequired();
            builder.Property(x => x.FunctionId).HasColumnName("function_id").HasMaxLength(GroupAccessibleFunctionConsts.MaxFunctionIdLength).IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(GroupAccessibleFunctionConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(GroupAccessibleFunctionConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(GroupAccessibleFunctionConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(GroupAccessibleFunctionConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");

        }
    }
}
