using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model
{
    public class Paginator<T>
    {
        public int pageCount { get; set; }
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
        
        public List<T> data { get; set; }
    }
}
