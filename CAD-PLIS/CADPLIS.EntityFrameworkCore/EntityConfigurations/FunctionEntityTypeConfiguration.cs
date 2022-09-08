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
    public class FunctionEntityTypeConfiguration: IEntityTypeConfiguration<Function>
    {
        public void Configure(EntityTypeBuilder<Function> builder)
        {
            builder.ToTable("PLIS_FUNCTION");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FunctionId).HasColumnName("function_id").HasMaxLength(FunctionConsts.MaxFunctionIdLength).IsRequired();
            builder.Property(x => x.FunctionType).HasColumnName("function_type").HasMaxLength(FunctionConsts.MaxFunctionTypeLength);
            builder.Property(x => x.FunctionDescription).HasColumnName("function_description").HasMaxLength(FunctionConsts.MaxFunctionDescriptionLength);
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").HasMaxLength(FunctionConsts.MaxCreatedByLength).IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").HasMaxLength(FunctionConsts.MaxCreatedUserRoleIdLength).IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id").HasMaxLength(FunctionConsts.MaxUpdatedByLength);
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid").HasMaxLength(FunctionConsts.MaxUpdatedUserRoleIdLength);
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.SystemFunction).HasColumnName("system_function");
            builder.Property(x => x.DisplaySequence).HasColumnName("display_seq_no");

        }
    }
}
