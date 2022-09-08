using CADPLIS.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.services
{
    public class LogAuditLogService : IAuditLogService
    {
        private readonly ILogger<LogAuditLogService> logger;
        public LogAuditLogService(ILogger<LogAuditLogService> _logger)
        {
            logger = _logger;
        }
        public void SaveLog(AuditInfo auditInfo)
        {
            logger.LogInformation(Newtonsoft.Json.JsonConvert.SerializeObject(auditInfo));
        }
    }
}
