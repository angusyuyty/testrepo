using CADPLIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.services
{
   public interface IAuditLogService
    {
        void SaveLog(AuditInfo auditInfo);
    }
}
