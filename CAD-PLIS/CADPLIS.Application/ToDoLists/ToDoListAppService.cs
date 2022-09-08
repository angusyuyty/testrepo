using AutoMapper;
using CADPLIS.Application.Contracts.ToDoLists;
using CADPLIS.Domain;
using CADPLIS.Domain.ToDoLists;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CADPLIS.Application.ToDoLists
{
    public class ToDoListAppService : IToDoListAppService
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;
        public ToDoListAppService(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }
        public async Task Insert(ToDoListDto model)
        {
            var gmodel = _mapper.Map<ToDoList>(model);
            await _toDoListRepository.InsertAsync(gmodel, true);
            model.Id = gmodel.Id;
        }

        public async Task Update(ToDoListDto model)
        {
            var dbModel = _mapper.Map<ToDoList>(model);
            await _toDoListRepository.ModifyAsync(dbModel, true);
        }
        public async Task<Paginator<ToDoListDto>> GetListBySearchAsync(int pageSize, int pageIndex,string currentUserId, string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate)
        {
            Paginator<ToDoListDto> page = new Paginator<ToDoListDto>();
            var result = await _toDoListRepository.GetPageListAsync(pageSize, pageIndex, currentUserId, category, applicationNo, sender, startNotificationDate, endNotificationDate, startDueDate, endDueDate);
            page.data = _mapper.Map<List<ToDoListDto>>(result);
            page.pageCount = await _toDoListRepository.GetCountAsync(currentUserId,category, applicationNo, sender, startNotificationDate, endNotificationDate, startDueDate, endDueDate);
            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            return page;
        }
        public async Task<ToDoListDto> GetByIdAsync(int id)
        {
            var model = await _toDoListRepository.FindAsync(u => u.Id.Equals(id));
            var result = _mapper.Map<ToDoListDto>(model);
            return result;
        }
        public async Task DeleteAsync(int id)
        {
            var model = await _toDoListRepository.FindAsync(u => u.Id.Equals(id));
            if (model != null)
            {
                await _toDoListRepository.DeleteAsync(model, true);
            }
        }
        public async Task<int> GetCountAsync(string currentUserId=null, string category=null, int? applicationNo=null, string sender=null, DateTime? startNotificationDate=null, DateTime? endNotificationDate=null, DateTime? startDueDate=null, DateTime? endDueDate=null)
        {
           var totalCount= await _toDoListRepository.GetCountAsync(currentUserId, category, applicationNo, sender, startNotificationDate, endNotificationDate, startDueDate, endDueDate);
            return totalCount;
        }

    }
}

