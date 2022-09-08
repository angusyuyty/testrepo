using CADPLIS.Domain.Groups;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.UserRoleGroups
{
    public class UserRoleGroupRepository : EfBaseRepository<UserRoleGroup>, IUserRoleGroupRepository
    {
        public UserRoleGroupRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }

        public async Task DeleteAsync(UserRoleGroup userRoleGroup, bool autoSave = false)
        {
            await RemoveAsync(userRoleGroup, autoSave);
        }

        public async Task<UserRoleGroup> FindAsync(Expression<Func<UserRoleGroup, bool>> whereLambda)
        {
            var result= await FindModelAsync(whereLambda);
            return result;
        }

        public async Task InsertAsync(UserRoleGroup userRoleGroup, bool autoSave = false)
        {
            await AddAsync(userRoleGroup, autoSave);
        }

        public async Task UpdateAsync(UserRoleGroup userRoleGroup, bool autoSave = false)
        {
            await EditAsync(userRoleGroup, autoSave);
        }
    }
}
