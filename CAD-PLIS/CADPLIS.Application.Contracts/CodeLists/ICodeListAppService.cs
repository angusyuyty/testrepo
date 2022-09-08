using CADPLIS.Domain.CodeLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.CodeLists
{
    public interface ICodeListAppService
    {
        Task<List<DropDownList>> GetListByType(string type);
    }
}
