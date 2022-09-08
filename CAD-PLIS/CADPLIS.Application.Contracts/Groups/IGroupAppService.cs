using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Groups
{
    public interface IGroupAppService
    {
        Task Insert(GroupDto model);
        Task Update(GroupDto model);
        Task<Paginator<GroupDto>> GetListBySearchAsync(int pageSize, int pageIndex, string groupId, string name);
        Task<GroupDto> GetByIdAsync(int id);
        Task<List<GroupDto>> GetAllGroup(string gId);
        Task DeleteAsync(int id);
    }
}
