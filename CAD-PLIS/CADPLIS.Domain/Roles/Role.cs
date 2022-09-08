using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Roles
{
    [Table("PLIS_ROLE")]
    public class RoleInfo
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
    }
}
