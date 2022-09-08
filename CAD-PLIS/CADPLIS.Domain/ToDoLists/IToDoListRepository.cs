using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.ToDoLists
{
    public interface IToDoListRepository
    {
        Task InsertAsync(ToDoList model, bool autoSave = false);
        Task ModifyAsync(ToDoList model, bool autoSave = false);
        Task<List<ToDoList>> GetPageListAsync(int pageSize, int pageIndex, string currentUserId, string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate);
        Task<int> GetCountAsync(string currentUserId, string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate);
        Task<ToDoList> FindAsync(Expression<Func<ToDoList, bool>> whereLambda);
        Task DeleteAsync(ToDoList model, bool autoSave = false);
    }
}
