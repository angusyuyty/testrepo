using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Functions
{
    public interface IGroupAccessibleFunctionAppService:IBaseAppService
    {
        Task Insert(GroupAccessibleFunctionDto model);
        Task Update(GroupAccessibleFunctionDto model);
        Task<Paginator<GroupAccessibleFunctionDto>> GetListBySearchAsync(int pageSize, int pageIndex, string gId, string gname);
        Task<GroupAccessibleFunctionDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<List<GroupAccessibleFunctionDto>> GetFunctionByGroupId(string gId);

        Task<List<GroupAccessibleFunctionDto>> GetFunctionByGroupIds(List<string> gIds);
    }
}
