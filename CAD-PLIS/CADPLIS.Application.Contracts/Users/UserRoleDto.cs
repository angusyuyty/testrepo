using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Users
{
    public class UserRoleDto
    {
        public int UserRoleId { get; set; }
        public string RoleId { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
        public List<string> Roles { get; set; }
        public string RoleName { get; set; }

    }
}
