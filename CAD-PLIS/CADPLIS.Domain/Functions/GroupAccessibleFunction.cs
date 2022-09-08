using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Functions
{
   public class GroupAccessibleFunction:BaseInfo
    {
        public int Id { get; set; }
        public string GroupId { get; set; }
        public string FunctionId { get; set; }

    }
}
