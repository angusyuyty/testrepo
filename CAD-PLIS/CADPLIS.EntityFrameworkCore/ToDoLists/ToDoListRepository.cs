using CADPLIS.Domain.ToDoLists;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.ToDoLists
{
    public class ToDoListRepository : EfBaseRepository<ToDoList>, IToDoListRepository
    {
        public ToDoListRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        { 

        }
        public async Task InsertAsync(ToDoList model, bool autoSave = false)
        {
            await AddAsync(model, autoSave);
        }
        public async Task ModifyAsync(ToDoList model, bool autoSave = false)
        {
            await EditAsync(model, autoSave);
        }
        public async Task<List<ToDoList>> GetPageListAsync(int pageSize, int pageIndex, string currentUserId,string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate)
        {
            var query = GetListQuery(currentUserId,category, applicationNo, sender, startNotificationDate,endNotificationDate, startDueDate,endDueDate);
            var result = await query.OrderByDescending(u => u.Id).PageBy(pageSize * pageIndex, pageSize)
                .ToListAsync();
            return result;
        }
        public async Task<int> GetCountAsync(string currentUserId,string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate)
        {
            var query = GetListQuery(currentUserId,category, applicationNo, sender, startNotificationDate, endNotificationDate, startDueDate, endDueDate);

            var totalCount = await query.CountAsync();

            return totalCount;
        }
        protected virtual IQueryable<ToDoList> GetListQuery(string currentUserId,string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate)
        {
            return DbSet.AsNoTracking()
                .WhereIf(!string.IsNullOrEmpty(currentUserId), u => u.SendTo.Contains(currentUserId))
                .WhereIf(!string.IsNullOrEmpty(category), u => u.Category.Contains(category))
                .WhereIf(applicationNo != null && applicationNo != 0, u => u.ApplicationNo == applicationNo)
                .WhereIf(!string.IsNullOrEmpty(sender), u => u.SendFrom.Contains(sender))
                 .WhereIf(startNotificationDate != null, u => u.NotificationDate>= startNotificationDate)
                 .WhereIf(endNotificationDate != null, u => u.NotificationDate >= endNotificationDate)
                 .WhereIf(startDueDate != null, u => u.DueDate >= startDueDate)
                  .WhereIf(endDueDate != null, u => u.DueDate<= endDueDate);
        }
        public async Task<ToDoList> FindAsync(Expression<Func<ToDoList, bool>> whereLambda)
        {
            return await FindModelAsync(whereLambda);
        }
        public async Task DeleteAsync(ToDoList model, bool autoSave = false)
        {
            await RemoveAsync(model, autoSave);
        }
    }
}
