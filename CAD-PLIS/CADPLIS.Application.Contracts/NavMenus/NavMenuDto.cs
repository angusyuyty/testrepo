using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.Domain.Shared.NavMenus;

namespace CADPLIS.Application.Contracts.NavMenus
{
    public class NavMenuDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "MenuId is Required")]
        public string MenuId { get; set; }
        [Required(ErrorMessage ="MenuName is Required")]
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
        public IEnumerable<NavMenuDto> Children { get; set; } = new List<NavMenuDto>();
        public bool IsEdit { get; set; }
    }
}
