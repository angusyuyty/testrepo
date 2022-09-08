using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Functions
{
    public class GroupAccessibleFunctionDto
    {
        public int Id { get; set; }

        public string GroupId { get; set; }
        public string FunctionId { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
        public List<string> Functions { get; set; }
        public string GroupName { get; set; }
        public string FunctionName { get; set; }
        public string FunctionType { get; set; }
    }
}
