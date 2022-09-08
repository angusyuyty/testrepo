using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Users
{
    public class UserRole:BaseInfo
    {
        public int UserRoleId { get; set; }
        public string RoleId { get; set; }
        public string UserId { get; set; }


    }
}
