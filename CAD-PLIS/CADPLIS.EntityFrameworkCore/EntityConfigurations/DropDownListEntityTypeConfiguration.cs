using CADPLIS.Domain.CodeLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class DropDownListEntityTypeConfiguration : IEntityTypeConfiguration<DropDownList>
    {
        public void Configure(EntityTypeBuilder<DropDownList> builder)
        {
            builder.ToTable("PLIS_DROPDOWNLIST");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Type).HasColumnName("drop_down_type");
            builder.Property(x => x.Value).HasColumnName("drop_down_value");
            builder.Property(x => x.Description).HasColumnName("drop_down_description");
        }
    }
}
