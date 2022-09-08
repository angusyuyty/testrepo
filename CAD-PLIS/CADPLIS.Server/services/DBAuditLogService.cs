using CADPLIS.Domain.AuditInfos;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using CADPLIS.Server.AuditLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.services
{
    public class DBAuditLogService : IAuditLogService
    {
        private readonly PlisDbcontext efDbcontext;
        public DBAuditLogService(PlisDbcontext _efDbcontext)
        {
            efDbcontext = _efDbcontext;
        }

        public void SaveLog(AuditInfo auditInfo)
        {
            efDbcontext.AuditInfos.Add(auditInfo);
            efDbcontext.SaveChanges();
        }
    }
}
