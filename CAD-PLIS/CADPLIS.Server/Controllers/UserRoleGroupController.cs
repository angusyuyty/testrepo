using AutoMapper;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CADPLIS.Server.Application.Events;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleGroupController : ControllerBase
    {
        private readonly IUserRoleGroupAppService _userRoleGroupAppService;
        private readonly IUserAppService _userAppService;
        private readonly IRoleAppService _roleAppService;
        private readonly IMediator _mediator;
        public UserRoleGroupController(IUserRoleGroupAppService userRoleGroupAppService, IUserAppService userAppService, IRoleAppService roleAppService, IMediator mediator)
        {
            _userRoleGroupAppService = userRoleGroupAppService;
            _userAppService = userAppService;
            _roleAppService = roleAppService;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, int id, string userId, string roleId)
        {
            var result = await _userRoleGroupAppService.GetPageListAsync(pageSize, pageIndex, id, userId, roleId);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [HttpGet]
        [Route("GetList")]
        public async Task<ApiResponse> GetList(string userId, string roleId)
        {
            var result = await _userRoleGroupAppService.GetListAsync(userId, roleId);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }


        //[HttpPost]
        //[Route("Create")]
        //public async Task<ApiResponse> Create(UserRoleGroupDto userRoleGroupDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        userRoleGroupDto.CreatedBy = "admin";
        //        userRoleGroupDto.CreatedTime = DateTime.Now;
        //        userRoleGroupDto.CreatedUserRoleId = "Administrator";
        //        await _userRoleGroupAppService.AddAsync(userRoleGroupDto);

              
        //        return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        //    }
        //    else
        //    {
        //        return new ApiResponse(StatusCodes.Status400BadRequest, OperResult.Error);
        //    }
        //}
        [HttpPut]
        [Route("Update")]
        public async Task<ApiResponse> Update(UserRoleGroupDto userRoleGroupDto)
        {
            if (ModelState.IsValid)
            {
                userRoleGroupDto.UpdatedBy = "admin";
                userRoleGroupDto.UpdatedTime = DateTime.Now;
                userRoleGroupDto.UpdatedUserRoleId = "Administrator";
                await _userRoleGroupAppService.UpdateAsync(userRoleGroupDto);
                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            else
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, OperResult.Error);
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ApiResponse> Delete(int id)
        {
            await _userRoleGroupAppService.DeleteAsync(id);

            await _mediator.Publish(new ActiveLogEvent { Key = id.ToString(), Form = "PLIS_USER_ROLE_GROUP", Action = OperAction.Delete });

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }
        [HttpGet]
        [Route("GetSearchData")]
        public async Task<ApiResponse> GetSearchData()
        {
            UserAndRole userAndRole = new UserAndRole();
            var users = await _userAppService.GetAllUser();
            var roles = await _roleAppService.GetAllRole();
            userAndRole.Users = users.Select(u => new UserDto { Id = u.Id, UserId = u.UserId, UserName = u.UserName }).ToList();
            userAndRole.RoleInfos = roles.Select(u => new RoleInfoDto {Id=u.Id,RoleId=u.RoleId,RoleDescription=u.RoleDescription }).ToList();
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, userAndRole);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _userRoleGroupAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
    }
}
