using AutoMapper;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CADPLIS.Server.Application.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using CADPLIS.Common.consts;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMapper _autoMapper;
        private readonly IRoleAppService _roleAppService;
        private readonly IMediator _mediator;
        public RoleController(IMapper autoMapper,IRoleAppService roleAppService, IMediator mediator)
        {
            _autoMapper = autoMapper;
            _roleAppService = roleAppService;
            _mediator = mediator;
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ApiResponse> Create(RoleInfoDto roleInfoDto)
        {
            if (ModelState.IsValid)
            {
                roleInfoDto.CreatedBy = "admin";
                roleInfoDto.CreatedTime = DateTime.Now;
                roleInfoDto.CreatedUserRoleId = "Administrator";
                await _roleAppService.AddAsync(roleInfoDto);

                await _mediator.Publish(new ActiveLogEvent { Key = roleInfoDto.RoleId, Form = "PLIS_ROLE",Action= OperUiConsts.Save, ActionType = OperAction.Insert });

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            else
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, OperResult.Error);
            }
        }
        [HttpPut]
        [Route("Update")]
        public async Task<ApiResponse> Update(RoleInfoDto roleInfoDto)
        {
            if (ModelState.IsValid)
            {
                await _roleAppService.UpdateAsync(roleInfoDto);

               await _mediator.Publish(new ActiveLogEvent {Key=roleInfoDto.RoleId,Form= "PLIS_ROLE", Action = OperUiConsts.Save, ActionType = OperAction.Update });

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, OperResult.Error);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ApiResponse> Delete(int id)
        {
            var model=await _roleAppService.GetByIdAsync(id);
            await _roleAppService.DeleteAsync(id);

            await _mediator.Publish(new ActiveLogEvent { Key =model.RoleId, Form = "PLIS_ROLE", Action = OperUiConsts.Delete, ActionType = OperAction.Delete });

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }
        [HttpGet]
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, string roleId,string roleName)
        {
            var result = await _roleAppService.GetPageListAsync(pageSize, pageIndex, roleId,roleName);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _roleAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [HttpGet]
        [Route("GetByRoleId/{roleId}")]
        public async Task<ApiResponse> GetByRoleId(string roleId)
        {
            var result = await _roleAppService.GetByRoleIdAsync(roleId);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }


        [Route("GetAllRole")]
        [HttpGet]
        public async Task<ApiResponse> GetAllRole()
        {
            var result = await _roleAppService.GetAllRole();
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Error, result);
        }
    }
}
