using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Identity
{
    [Table("GroupInfo")]
    public class GroupInfo
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
