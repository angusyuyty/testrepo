using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts
{
    public class SelectTree<T>
    {
        public T Id { get; set; }

        public bool Selected { get; set; }

        public string DisplayValue { get; set; }
        public int? ParentId { get; set; }
        public string FId { get; set; }
        public List<SelectTree<T>> Children { get; set; } = new List<SelectTree<T>>();
    }
}
