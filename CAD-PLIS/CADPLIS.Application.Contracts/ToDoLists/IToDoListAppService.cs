using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CADPLIS.Application.Contracts.ToDoLists
{
    public interface IToDoListAppService
    {
        Task Insert(ToDoListDto model);
        Task Update(ToDoListDto model);
        Task<Paginator<ToDoListDto>> GetListBySearchAsync(int pageSize, int pageIndex, string currentUserId, string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate);
        Task<ToDoListDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<int> GetCountAsync(string currentUserId = null, string category = null, int? applicationNo = null, string sender = null, DateTime? startNotificationDate = null, DateTime? endNotificationDate = null, DateTime? startDueDate = null, DateTime? endDueDate = null);
    }
}
