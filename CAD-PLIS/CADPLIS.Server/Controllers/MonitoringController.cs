using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CADPLIS.Application.Contracts.Monitorings;
using CADPLIS.Server.AuditLog;
using CADPLIS.Domain;
using CADPLIS.Application.Contracts.Logs;
using CADPLIS.Common;

namespace CADPLIS.Server.Controllers
{
    [DisableAuditing]
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoringController : ControllerBase
    {
        private readonly IMonitoringAppService _monitoringAppService;
        private readonly ILogRecordDetailAppService _logRecordDetailAppService;

        public MonitoringController(IMonitoringAppService monitoringAppService, ILogRecordDetailAppService logRecordDetailAppService)
        {
            _monitoringAppService = monitoringAppService;
            _logRecordDetailAppService = logRecordDetailAppService;
        }
        [DisableAuditing]
        [HttpGet]
        [Route("GetWebApiLog/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        public async Task<ApiResponse> GetPageWebApiLog(int pageSize,int pageIndex)
        {
            var result= await _monitoringAppService.GetPageApiList(pageSize,pageIndex);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
        [Route("GetDataLogList/pageSize/{pageSize}/pageIndex/{pageIndex}")]
        [HttpGet]
        public async Task<ApiResponse> GetDataLogList(int pageSize, int pageIndex)
        {
            var result= await _logRecordDetailAppService.GetPageListAsync(pageSize, pageIndex);
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, result);
        }
    }
}
