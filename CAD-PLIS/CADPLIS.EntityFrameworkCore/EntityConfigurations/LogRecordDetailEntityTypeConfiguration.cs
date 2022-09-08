using CADPLIS.Domain.Logs;
using CADPLIS.Domain.Shared.Logs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
   public class LogRecordDetailEntityTypeConfiguration:IEntityTypeConfiguration<LogRecordDetail>
    {
        public void Configure(EntityTypeBuilder<LogRecordDetail> builder)
        {
            builder.ToTable("LogRecordDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(LogRecordDetailConsts.MaxIdLength).IsRequired();
            builder.Property(x => x.CurrentValue).HasMaxLength(LogRecordDetailConsts.MaxCurrentValueLength);
            builder.Property(x => x.OriginalValue).HasMaxLength(LogRecordDetailConsts.MaxOriginalValueLength);
            builder.Property(x => x.FieldName).HasMaxLength(LogRecordDetailConsts.MaxFieldNameLength);
            builder.Property(x => x.OperationKeyID).HasMaxLength(LogRecordDetailConsts.MaxOperationKeyIDLength);
            builder.Property(x => x.LogOperator).HasMaxLength(LogRecordDetailConsts.MaxLogOperatorLength);
            builder.Property(x => x.LogContent).HasMaxLength(LogRecordDetailConsts.MaxLogContentLength);
            builder.Property(x => x.OperationAction).HasMaxLength(LogRecordDetailConsts.MaxOperationActionLength);
            builder.Property(x => x.OperationTable).HasMaxLength(LogRecordDetailConsts.MaxOperationTableLength);

        }
    }
}
