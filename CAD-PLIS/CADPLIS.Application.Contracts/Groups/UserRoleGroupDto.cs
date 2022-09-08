using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Groups
{
    public class UserRoleGroupDto
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public string GroupId { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string RoleName {  get; set; } 
        
        public List<string> GroupIds { get; set; }
    }
}
