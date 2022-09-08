using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Application.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Groups
{
   public class UserAndRole
    {
        public List<UserDto> Users { get; set; } = new();
        public List<RoleInfoDto> RoleInfos { get; set; } = new();
    }
}
