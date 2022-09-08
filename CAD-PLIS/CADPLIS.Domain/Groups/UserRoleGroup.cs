using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Groups
{
    public class UserRoleGroup:BaseInfo
    {
        public int Id { get; set; } 
        public int UserRoleId { get; set; }
        public string GroupId { get; set; }

    }
}
