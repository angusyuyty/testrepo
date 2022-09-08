using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts
{
    public class GetFunctionsDto<T>
    {
        public SelectTree<T> treeModel { get; set; } = new SelectTree<T>();
        public List<string> selectedFunctions { get; set; } = new List<string>();
    }
}
