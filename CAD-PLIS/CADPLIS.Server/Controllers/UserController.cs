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
using System.Security.Claims;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IUserAppService userAppService, IMapper mapper, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _userAppService = userAppService;
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
        }
        [Route("GetPageUsers/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetPageUsers(int pageSize, int pageIndex, string userId, int? uId, string email)
        {
            //var x = _httpContextAccessor.HttpContext.Request.Headers;
            
            var result = await _userAppService.GetListBySearchAsync(pageSize, pageIndex, userId, uId, email);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _userAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("GetAllUser")]
        [HttpGet]
        public async Task<ApiResponse> GetAllUser()
        {
            var result = await _userAppService.GetAllUser();
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("GetUserByUserId/{userId}")]
        [HttpGet]
        public async Task<ApiResponse> GetUserByUserId(string userId)
        {
            var result = await _userAppService.GetByLoginIdAsync(userId);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [Route("Register")]
        [HttpPost]
        public async Task<ApiResponse> Register(UserDto model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = "admin";
                model.CreatedTime = DateTime.Now;
                model.CreatedUserRoleId = "Administrator";
                await _userAppService.Insert(model);
                //add logs
                await _mediator.Publish(new ActiveLogEvent { Key = model.UserId, Form = "PLIS_USER", Action = OperUiConsts.Save, ActionType = OperAction.Insert });
                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Register Error!");
        }

        [Route("UpdateUser")]
        [HttpPut]
        public async Task<ApiResponse> UpdateUser(UserDto model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = "admin";
                model.UpdatedTime = DateTime.Now;
                model.UpdatedUserRoleId = "Administrator";
                await _userAppService.Update(model);
                //add logs
                await _mediator.Publish(new ActiveLogEvent { Key = model.UserId, Form = "PLIS_USER", Action = OperUiConsts.Save, ActionType = OperAction.Update });
                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Update Error!");
        }

        [Route("DeleteUser/{id}")]
        [HttpDelete]
        public async Task<ApiResponse> DeleteUser(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, "the delete object can not be null!");
            }
            var userModel = await _userAppService.GetByIdAsync(id);
            await _userAppService.DeleteAsync(id);
            await _mediator.Publish(new ActiveLogEvent { Key = userModel.UserId, Form = "PLIS_USER", Action = OperUiConsts.Delete, ActionType = OperAction.Delete });
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }


    }
}
