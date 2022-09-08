using CADPLIS.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class GroupInfoEntityTypeConfiguration : IEntityTypeConfiguration<GroupInfo>
    {
        public void Configure(EntityTypeBuilder<GroupInfo> builder)
        {
            builder.ToTable("GroupInfo");
            builder.HasKey(x => x.Id);
            builder.HasQueryFilter(x => x.IsDeleted == false);
        }
    }
}
