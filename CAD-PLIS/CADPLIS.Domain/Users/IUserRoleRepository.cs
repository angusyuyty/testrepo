using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Users
{
    public interface IUserRoleRepository
    {
        Task InsertRangeAsync(List<UserRole> model, bool autoSave = false);
        Task ModifyAsync(UserRole model, bool autoSave = false);
        Task DeleteAsync(UserRole model, bool autoSave = false);
        Task<UserRole> FindByIdAsync(int id);
        Task<List<UserRole>> FindListAsync(string userId, string roleId=null);
        Task<UserRole> FindByUserIdAndRoleIdAsync(string userId, string roleId);
    }
}
