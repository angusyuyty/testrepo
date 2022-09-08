using CADPLIS.Business;
using CADPLIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.services
{
    public class DBAuditLogService : IAuditLogService
    {
        private readonly EFDbcontext efDbcontext;
        public DBAuditLogService(EFDbcontext _efDbcontext)
        {
            efDbcontext = _efDbcontext;
        }

        public void SaveLog(AuditInfo auditInfo)
        {
            efDbcontext.AuditInfo.Add(auditInfo);
            efDbcontext.SaveChanges();
        }
    }
}
