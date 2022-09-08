
using CADPLIS.Domain.AuditInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.AuditLog
{
   public interface IAuditLogService
    {
        void SaveLog(AuditInfo auditInfo);
    }
}
