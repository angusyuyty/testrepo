using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Functions
{
    public interface IFunctionAppService: IBaseAppService
    {
        Task Insert(FunctionDto model);
        Task Update(FunctionDto model);
        Task<FunctionDto> GetByIdAsync(int id);
        Task<List<FunctionDto>> GetFunctionAsync(string fid = null, string ftype = null, string fname = null);
        Task<Paginator<FunctionDto>> GetListBySearchAsync(int pageSize, int pageIndex, string fid, string ftype, string fname);
        Task DeleteAsync(int id);
        Task<FunctionDto> FunctionValidate(FunctionDto model, string action);

    }
}
