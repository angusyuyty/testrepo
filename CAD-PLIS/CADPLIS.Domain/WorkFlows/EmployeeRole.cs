using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CADPLIS.Domain.WorkFlows
{
    [Table("EmployeeRole")]
    public class EmployeeRole
    {
        public Guid EmployeeId { get; set; }
        public Guid RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
