using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Users
{
    public interface IUserAppService:IBaseAppService
    {
        Task Insert(UserDto model);
        Task Update(UserDto model);
        Task<Paginator<UserDto>> GetListBySearchAsync(int pageSize, int pageIndex, string userId, int? uId, string email);
        Task<UserDto> GetByIdAsync(int id);
        Task<UserDto> GetByLoginIdAsync(string userId);
        Task<List<UserDto>> GetAllUser();
        Task DeleteAsync(int id);
    }
}
