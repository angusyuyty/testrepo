using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Functions
{
    public interface IGroupAccessibleFunctionRepository
    {
        Task InsertRangeAsync(List<GroupAccessibleFunction> model, bool autoSave = false);
        Task ModifyAsync(GroupAccessibleFunction model, bool autoSave = false);
        Task DeleteAsync(GroupAccessibleFunction model, bool autoSave = false);
        Task<GroupAccessibleFunction> FindAsync(Expression<Func<GroupAccessibleFunction, bool>> whereLambda);
        Task<List<GroupAccessibleFunction>> FindListAsync(string groupId, string functionId);
        Task<List<GroupAccessibleFunction>> GetListAsync(Expression<Func<GroupAccessibleFunction, bool>> whereLambda);
    }
}
