using CADPLIS.Domain.NavMenus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class PlisNavMenuEntityTypeConfiguration : IEntityTypeConfiguration<PlisNavMenu>
    {
        public void Configure(EntityTypeBuilder<PlisNavMenu> builder)
        {
            builder.ToTable("PLIS_NAVMENU");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.MenuId).HasColumnName("menu_id").IsRequired();
            builder.Property(x => x.MenuName).HasColumnName("menu_name").IsRequired();
            builder.Property(x => x.MenuDescription).HasColumnName("menu_description");
            builder.Property(x => x.OrderNo).HasColumnName("order_no").IsRequired();
            builder.Property(x => x.Icon).HasColumnName("icon");
            builder.Property(x => x.MenuType).HasColumnName("menu_type");
            builder.Property(x => x.RouteUrl).HasColumnName("route_url");
            builder.Property(x => x.ParentId).HasColumnName("parentid");
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id");
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid");
        }
    }
}
