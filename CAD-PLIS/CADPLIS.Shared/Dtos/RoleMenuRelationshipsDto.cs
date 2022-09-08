using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model
{
    public class RoleMenuRelationshipsDto
    {
        public string Id { get; set; }
        public string MenuId { get; set; }
        public string RoleId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
