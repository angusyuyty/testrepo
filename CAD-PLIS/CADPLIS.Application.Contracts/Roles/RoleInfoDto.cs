using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Roles
{
    public class RoleInfoDto
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string RoleDescription { get; set; }
        public bool? isAMEAMA { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
        public string UpdatedTimeText { get; set; }
        public string CreatedTimeText { get; set; }

    }
}
