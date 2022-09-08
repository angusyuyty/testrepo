using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Groups
{
    public class Group:BaseInfo
    {
        public int Id { get; set; }
        public string GroupId { get; set; }
        public string GroupDescription { get; set; }

    }
}
