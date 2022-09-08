using AutoMapper;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Common;
using CADPLIS.Common.consts;
using CADPLIS.Server.Application.Events;
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
    public class GroupController : ControllerBase
    {
        private readonly IGroupAppService _groupAppService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GroupController(IGroupAppService groupAppService, IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _groupAppService = groupAppService;
            _mediator = mediator;
        }
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, string groupId, string name)
        {
            var result = await _groupAppService.GetListBySearchAsync(pageSize, pageIndex, groupId, name);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _groupAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("GetAllList")]
        [HttpGet]
        public async Task<ApiResponse> GetAllList(string gId)
        {
            var result = await _groupAppService.GetAllGroup(gId);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<ApiResponse> Insert(GroupDto model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = "admin";
                model.CreatedTime = DateTime.Now;
                model.CreatedUserRoleId = "Administrator";
                await _groupAppService.Insert(model);
                await _mediator.Publish(new ActiveLogEvent { Key = model.GroupId, Form = "PLIS_GROUP", Action = OperUiConsts.Save, ActionType = OperAction.Insert });

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Insert Error!");
        }

        [Route("Update")]
        [HttpPut]
        public async Task<ApiResponse> Update(GroupDto model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = "admin";
                model.UpdatedTime = DateTime.Now;
                model.UpdatedUserRoleId = "Administrator";
                await _groupAppService.Update(model);
                await _mediator.Publish(new ActiveLogEvent { Key = model.GroupId, Form = "PLIS_GROUP", Action = OperUiConsts.Save,ActionType = OperAction.Update });
                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Update Error!");
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public async Task<ApiResponse> Delete(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, "the delete object can not be null!");
            }
            var gmodel =await _groupAppService.GetByIdAsync(id);
            await _groupAppService.DeleteAsync(id);
            await _mediator.Publish(new ActiveLogEvent { Key =gmodel.GroupId, Form = "PLIS_GROUP", Action = OperUiConsts.Delete, ActionType = OperAction.Delete });
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }

    }
}
