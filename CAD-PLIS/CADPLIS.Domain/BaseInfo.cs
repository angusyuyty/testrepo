using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain
{
    public class BaseInfo
    {
		public DateTime CreatedTime { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedUserRoleId { get; set; }
		public DateTime? UpdatedTime { get; set; }
		public string UpdatedBy { get; set; }
		public string UpdatedUserRoleId { get; set; }
	}
}
