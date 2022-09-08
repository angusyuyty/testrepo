using CADPLIS.Domain.Shared.NavMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.NavMenus
{
    public class PlisNavMenu
    {
		public int Id { get; set; }
		public string MenuId { get; set; }
		public string MenuName { get; set; }
		public string MenuDescription { get; set; }
		public int OrderNo { get; set; }
		public string Icon { get; set; }
		public int? MenuType { get; set; }
		public string RouteUrl { get; set; }
		public int? ParentId { get; set; }
		public DateTime CreatedTime { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedUserRoleId { get; set; }
		public DateTime? UpdatedTime { get; set; }
		public string UpdatedBy { get; set; }
		public string UpdatedUserRoleId { get; set; }
	}
}
