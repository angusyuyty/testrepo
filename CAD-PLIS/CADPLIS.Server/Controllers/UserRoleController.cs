using AutoMapper;
using CADPLIS.Application.Contracts.Users;
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
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleAppService _userRoleAppService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UserRoleController(IUserRoleAppService userRoleAppService, IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _userRoleAppService = userRoleAppService;
            _mediator = mediator;
        }
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, string userId)
        {
            var result = await _userRoleAppService.GetListBySearchAsync(pageSize, pageIndex, userId);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _userRoleAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [HttpGet]
        [Route("GetRoleByUserId")]
        public async Task<ApiResponse> GetRoleByUserId(string userId)
        {
            var result = await _userRoleAppService.GetRoleByUserId(userId);

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result.Select(r => r.RoleId).ToList());
        }
        [Route("Insert")]
        [HttpPost]
        public async Task<ApiResponse> Insert(UserRoleDto model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = "admin";
                model.CreatedTime = DateTime.Now;
                model.CreatedUserRoleId = "Administrator";
                await _userRoleAppService.Insert(model);

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Insert Error!");
        }
        [Route("Update")]
        [HttpPut]
        public async Task<ApiResponse> Update(UserRoleDto model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = "admin";
                model.UpdatedTime = DateTime.Now;
                model.UpdatedUserRoleId = "Administrator";

                await _userRoleAppService.Update(model);
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
            var urmodel =await _userRoleAppService.GetByIdAsync(id);
            await _userRoleAppService.DeleteAsync(id);
            await _mediator.Publish(new ActiveLogEvent { Key = urmodel.UserId,SubKey = urmodel.RoleId, Form = "PLIS_USER_ROLE", Action = OperUiConsts.Delete, ActionType = OperAction.Delete });
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }

        [HttpGet]
        [Route("GetList")]
        public async Task<ApiResponse> GetList()
        {
            var result = await _userRoleAppService.GetListAsync();
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
    }
}
