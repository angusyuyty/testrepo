using CADPLIS.Domain.Groups;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.Groups
{
    public class GroupRepository : EfBaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        { 

        }
        public async Task InsertAsync(Group model, bool autoSave = false)
        {
            await AddAsync(model, autoSave);
        }
        public async Task ModifyAsync(Group model, bool autoSave = false)
        {
            await EditAsync(model, autoSave);
        }
        public async Task<List<Group>> GetPageListAsync(int pageSize, int pageIndex, string groupId, string name)
        {
            var query = GetListQuery(groupId, name);
            var result = await query.OrderByDescending(u => u.Id).PageBy(pageSize * pageIndex, pageSize)
                .ToListAsync();
            return result;
        }
        public async Task<int> GetCountAsync(string groupId, string name)
        {
            var query = GetListQuery(groupId, name);

            var totalCount = await query.CountAsync();

            return totalCount;
        }
        protected virtual IQueryable<Group> GetListQuery(string groupId,  string name)
        {
            return DbSet.AsNoTracking()
                .WhereIf(!string.IsNullOrEmpty(groupId), u => u.GroupId.Contains(groupId))
                .WhereIf(!string.IsNullOrEmpty(name), u => u.GroupDescription.Contains(name));
        }
        public async Task<List<Group>> GetAllGroupAsync(string gId)
        {
            var result = DbSet.AsNoTracking().WhereIf(!string.IsNullOrEmpty(gId), u => u.GroupId == gId);
                                           
            return await result.ToListAsync();
            // return await FindListAsync(g => g.GroupId == gId);
        }
        public async Task<Group> FindAsync(Expression<Func<Group, bool>> whereLambda)
        {
            return await FindModelAsync(whereLambda);
        }
        public async Task DeleteAsync(Group model, bool autoSave = false)
        {
            await RemoveAsync(model, autoSave);
        }
    }
}
