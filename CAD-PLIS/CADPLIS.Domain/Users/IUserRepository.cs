using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Users
{
    public interface IUserRepository
    {
        Task InsertAsync(User model, bool autoSave = false);
        Task ModifyAsync(User model, bool autoSave = false);
        Task<List<User>> GetPageListAsync(int pageSize, int pageIndex, string userId, int? uId, string email);
        Task<int> GetCountAsync(string userId, int? uId, string email);
        Task<List<User>> GetAllUserAsync(Expression<Func<User, bool>> whereLambda);
        Task<User> FindAsync(Expression<Func<User, bool>> whereLambda);
        Task DeleteAsync(User model, bool autoSave = false);
    }
}
