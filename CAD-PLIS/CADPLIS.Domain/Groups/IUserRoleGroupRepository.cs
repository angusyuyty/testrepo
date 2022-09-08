using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Groups
{
    public interface IUserRoleGroupRepository
    {
        Task DeleteAsync(UserRoleGroup userRoleGroup, bool autoSave = false);
        Task<UserRoleGroup> FindAsync(Expression<Func<UserRoleGroup, bool>> whereLambda);

        Task InsertAsync(UserRoleGroup userRoleGroup, bool autoSave = false);

        Task UpdateAsync(UserRoleGroup userRoleGroup, bool autoSave = false);

    }
}
