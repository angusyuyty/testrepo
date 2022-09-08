using CADPLIS.Application.Contracts.CodeLists;
using CADPLIS.Domain.CodeLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.CodeLists
{
    public class CodeListAppService : ICodeListAppService
    {
        private readonly IDropDownRepository _dropDownRepository;
        public CodeListAppService(IDropDownRepository dropDownRepository)
        {
            _dropDownRepository = dropDownRepository;
        }
        public async Task<List<DropDownList>> GetListByType(string type)
        {
            var result = await _dropDownRepository.GetListByType(type);
            return result;
        }
    }
}
