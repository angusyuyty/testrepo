using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.SystemAuditLogs
{
    public class UserLog
    {
        public int Id { get; set; }
        public int UserKey { get; set; }
        public int? UId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public bool? Is2FAEnabled { get; set; }
        public string RecState { get; set; }
        public bool? isAMEAMA { get; set; }
        public int? CorpAdmin { get; set; }
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
