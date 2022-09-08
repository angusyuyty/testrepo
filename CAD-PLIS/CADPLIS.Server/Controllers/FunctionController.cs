using AutoMapper;
using CADPLIS.Application.Contracts.Functions;
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
    public class FunctionController : ControllerBase
    {
        private readonly IFunctionAppService _functionAppService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public FunctionController(IFunctionAppService functionAppService, IMapper mapper,IMediator mediator)
        {
            _mapper = mapper;
            _functionAppService = functionAppService;
            _mediator = mediator;
        }
        [Route("GetPageList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetPageList(int pageSize, int pageIndex, string fid, string ftype, string fname)
        {
            var result = await _functionAppService.GetListBySearchAsync(pageSize, pageIndex, fid, ftype, fname);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<ApiResponse> GetById(int id)
        {
            var result = await _functionAppService.GetByIdAsync(id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("GetFunction")]
        [HttpGet]
        public async Task<ApiResponse> GetFunctionAsync(string fid, string ftype, string fname)
        {
            var result = await _functionAppService.GetFunctionAsync(fid,ftype,fname);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<ApiResponse> Insert(FunctionDto model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = "admin";
                model.CreatedTime = DateTime.Now;
                model.CreatedUserRoleId = "Administrator";
                var result = await _functionAppService.FunctionValidate(model, "add");
                if (result != null)
                {
                    return new ApiResponse(StatusCodes.Status400BadRequest, "the user already have the same function Error!");
                }
                else
                {
                    await _functionAppService.Insert(model);
                    await _mediator.Publish(new ActiveLogEvent { Key = model.FunctionId, Form = "PLIS_FUNCTION", Action = OperUiConsts.Save, ActionType = OperAction.Insert });
                }

                return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
            }
            return new ApiResponse(StatusCodes.Status400BadRequest, "Insert Error!");
        }

        [Route("Update")]
        [HttpPut]
        public async Task<ApiResponse> Update(FunctionDto model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = "admin";
                model.UpdatedTime = DateTime.Now;
                model.UpdatedUserRoleId = "Administrator";
                var result = await _functionAppService.FunctionValidate(model, "edit");
                if (result != null)
                {
                    return new ApiResponse(StatusCodes.Status400BadRequest, "the user already have the same function Error!");
                }
                else
                {
                    await _functionAppService.Update(model);
                    await _mediator.Publish(new ActiveLogEvent { Key = model.FunctionId, Form = "PLIS_FUNCTION", Action = OperUiConsts.Save, ActionType = OperAction.Update });
                }
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
            var result = await _functionAppService.GetByIdAsync(id);
            if (result.SystemFunction??Convert.ToBoolean(result.SystemFunction))
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, "the delete object is system function so can't delete!");
            }
            await _functionAppService.DeleteAsync(id);
            await _mediator.Publish(new ActiveLogEvent { Key = result.FunctionId, Form = "PLIS_FUNCTION", Action = OperUiConsts.Delete, ActionType = OperAction.Delete });
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }
    }
}
