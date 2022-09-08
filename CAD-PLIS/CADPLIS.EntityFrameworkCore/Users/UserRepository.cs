using CADPLIS.Domain.Users;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.Users
{
    public class UserRepository: EfBaseRepository<User>, IUserRepository
    {
        public UserRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }
        public async Task InsertAsync(User model, bool autoSave = false)
        {
            await AddAsync(model, autoSave);
        }
        public async Task ModifyAsync(User model, bool autoSave = false)
        {
            await EditAsync(model, autoSave);
        }
        public async Task<List<User>> GetPageListAsync(int pageSize, int pageIndex, string userId,int? uId, string email)
        {
            var query = GetListQuery(userId, uId, email);
            var result = await query.OrderByDescending(u => u.Id).PageBy(pageSize * pageIndex, pageSize)
                .ToListAsync();
            return result;
        }
        public async Task<int> GetCountAsync(string userId, int? uId, string email)
        {
            var query = GetListQuery(userId, uId, email);

            var totalCount = await query.CountAsync();

            return totalCount;
        }
        protected virtual IQueryable<User> GetListQuery(string userId, int? uId,string email)
        {
            return DbSet.AsNoTracking()
                .WhereIf(!string.IsNullOrEmpty(userId), u => u.UserId.Contains(userId))
                .WhereIf(!string.IsNullOrEmpty(email), u => u.Email.Contains(email))
                .WhereIf(uId != 0 && uId != null, u => u.UId == uId);
        }
        public async Task<List<User>> GetAllUserAsync(Expression<Func<User, bool>> whereLambda)
        {
           return await FindListAsync(whereLambda);
        }
        public async Task<User> FindAsync(Expression<Func<User, bool>> whereLambda)
        {
          return  await FindModelAsync(whereLambda);
        }
        public async Task DeleteAsync(User model, bool autoSave = false)
        {
             await RemoveAsync(model, autoSave);
        }
    }
}
