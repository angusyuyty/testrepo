using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Groups
{
    public interface IGroupRepository
    {
        Task InsertAsync(Group model, bool autoSave = false);
        Task ModifyAsync(Group model, bool autoSave = false);
        Task<List<Group>> GetPageListAsync(int pageSize, int pageIndex, string groupId, string name);
        Task<int> GetCountAsync(string groupId, string name);
        Task<Group> FindAsync(Expression<Func<Group, bool>> whereLambda);
        Task<List<Group>> GetAllGroupAsync(string gId);
        Task DeleteAsync(Group model, bool autoSave = false);
    }
}
