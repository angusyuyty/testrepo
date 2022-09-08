using CADPLIS.Application.Contracts.CodeLists;
using CADPLIS.Common;
using CADPLIS.Domain.CodeLists;
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
    public class CodeListController : ControllerBase
    {
        private readonly ICodeListAppService _codeListAppService ;
        public CodeListController(ICodeListAppService codeListAppService)
        {
            _codeListAppService = codeListAppService;
        }

        [HttpGet]
        [Route("GetListByType/{type}")]
        public async Task<ApiResponse> GetListByType(string type)
        {
            var result = await _codeListAppService.GetListByType(type);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
    }
}
