using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model
{
   public class NavMenuDto
    {
        public  string Id { get; set; }
        public  string MenuName { get; set; }
        public  string ParentId { get; set; }
        public  int OrderNo { get; set; }
        public  string Icon { get; set; }
        public  string RouteUrl { get; set; }
        public  string Permission { get; set; }
        public  bool IsDeleted { get; set; }
        public  string CreatedBy { get; set; }
        public  DateTime CreatedTime { get; set; }
        public  string UpdatedBy { get; set; }
        public  DateTime? UpdatedTime { get; set; }
        public IEnumerable<NavMenuDto> Children { get; set; }
        public bool IsEdit { get; set; }
        public List<RoleMenuRelationships> RoleMenu { get; set; }

    }
}
