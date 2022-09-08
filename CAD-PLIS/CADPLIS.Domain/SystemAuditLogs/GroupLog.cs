using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.SystemAuditLogs
{
    public class GroupLog
    {
        public int Id { get; set; }
        public int GroupKey { get; set; }
        public string GroupId { get; set; }
        public string GroupDescription { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedUserRoleId { get; set; }
        public string DataType { get; set; }
        public string Action { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }


    }
}
