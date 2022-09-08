using CADPLIS.Domain.Functions;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.Functions
{
    public class GroupAccessibleFunctionRepository: EfBaseRepository<GroupAccessibleFunction>, IGroupAccessibleFunctionRepository
    {
        public GroupAccessibleFunctionRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }
        public async Task InsertRangeAsync(List<GroupAccessibleFunction> model, bool autoSave = false)
        {
            await AddRangeAsync(model, autoSave);
        }
        public async Task ModifyAsync(GroupAccessibleFunction model, bool autoSave = false)
        {
            await EditAsync(model, autoSave);
        }

        public async Task DeleteAsync(GroupAccessibleFunction model, bool autoSave = false)
        {
            await RemoveAsync(model, autoSave);
        }
        public async Task<GroupAccessibleFunction> FindAsync(Expression<Func<GroupAccessibleFunction, bool>> whereLambda)
        {
            return await FindModelAsync(whereLambda);
        }

        public async Task<List<GroupAccessibleFunction>> GetListAsync(Expression<Func<GroupAccessibleFunction,bool>> whereLambda)
        {
            return await FindListAsync(whereLambda);
        }


        public async Task<List<GroupAccessibleFunction>> FindListAsync(string groupId, string functionId)
        {
            var result = DbSet.AsNoTracking().WhereIf(!string.IsNullOrEmpty(groupId), u => u.GroupId == groupId)
                                             .WhereIf(!string.IsNullOrEmpty(functionId), u => u.FunctionId == functionId);
            return await result.ToListAsync();
        }
    }
}
