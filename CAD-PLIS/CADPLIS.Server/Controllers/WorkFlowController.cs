using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Application.WorkflowProvider;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.Domain.Identity;
using CADPLIS.Domain.WorkFlows;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class WorkFlowController : ControllerBase
    {
        private readonly IWorkFlowAppService _workFlowAppService;
        public WorkFlowController(IWorkFlowAppService workFlowAppService)
        {
            _workFlowAppService = workFlowAppService;
        }
        [HttpGet]
        [Route("GetWorkFlows/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        public async Task<ApiResponse> GetWorkFlows(int pageSize, int pageIndex)
        {
            var result = await _workFlowAppService.GetPageWorkFlows(pageSize, pageIndex);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);

        }
        [HttpGet]
        [Route("GetPageInbox/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        public async Task<ApiResponse> GetPageInbox(int pageSize, int pageIndex)
        {
            var result = await _workFlowAppService.GetPageInbox(User.Identity.Name, pageSize, pageIndex);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }

        [HttpGet]
        [Route("GetDocument/{id}")]
        public async Task<ApiResponse> GetDocument(Guid? id)
        {
            var result= await _workFlowAppService.GetDocument(User.Identity.Name, id);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [HttpPost]
        [Route("InsertOrUpdate")]
        public async Task<ApiResponse> InsertOrUpdate(WorkFlowDocument documentViewModel)
        {
            await _workFlowAppService.InsertOrUpdate(documentViewModel);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }

        [HttpPost]
        [Route("ExecuteCommand")]
        public async Task<ApiResponse> ExecuteCommand(CommandModel commandModel)
        {
            await _workFlowAppService.ExecuteCommand(User.Identity.Name, commandModel);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
        }
        [HttpPost]
        [Route("DeleteRows")]
        public async Task<ApiResponse> DeleteRows(Guid[] ids)
        {
            if (ids.Length==0)
            {
                return new ApiResponse(StatusCodes.Status400BadRequest, "the delete object can not be null!");
            }

            foreach (var id in ids)
            {
              await  WorkflowInit.Runtime.PersistenceProvider.DeleteProcessAsync(id);
            }

            _workFlowAppService.Delete(ids);

            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success);


        }

    }
}
