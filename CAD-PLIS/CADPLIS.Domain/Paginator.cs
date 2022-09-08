using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain
{
    public class Paginator<T>
    {
        public int pageCount { get; set; }
        public int pageSize { get; set; }
        public int pageIndex { get; set; }

        public List<T> data { get; set; }

        public Paginator(int pagesize,int pageindex)
        {
            pageSize = pagesize;
            pageIndex = pageindex;
        }
        public Paginator()
        {

        }
    }
}
