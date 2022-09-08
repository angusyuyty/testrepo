using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Accounts
{
    public class GroupInfoDto
    {
        public Guid? Id { get; set; }
        public string GroupName { get; set; }
        public Guid? ParentId { get; set; }

        public bool IsDeleted { get; set; }

        public List<GroupInfoDto> Chilrens { get; set; }
    }
}
