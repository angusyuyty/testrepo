using AutoMapper;
using CADPLIS.Application.Contracts.ToDoLists;
using CADPLIS.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListAppService _toDoListAppService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ToDoListController(IToDoListAppService toDoListAppService, IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _toDoListAppService = toDoListAppService;
            _mediator = mediator;
        }
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, string category, int? applicationNo, string sender, DateTime? startNotificationDate, DateTime? endNotificationDate, DateTime? startDueDate, DateTime? endDueDate)
        {
            string currentUserId = User.Identity.Name;
            var result = await _toDoListAppService.GetListBySearchAsync(pageSize, pageIndex,currentUserId,category, applicationNo,sender,startNotificationDate,endNotificationDate,startDueDate, endDueDate);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [Route("GetCount")]
        [HttpGet]
        public async Task<ApiResponse> GetCount(string currentUserId = null, string category = null, int? applicationNo = null, string sender = null, 
            DateTime? startNotificationDate = null, DateTime? endNotificationDate = null, DateTime? startDueDate = null, DateTime? endDueDate = null)
        {
             currentUserId = User.Identity.Name;
            var count=await _toDoListAppService.GetCountAsync(currentUserId,category,applicationNo,sender,startNotificationDate,endNotificationDate,startDueDate,endDueDate);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, count); ;
        }
    }
}
