using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.Domain;
using CADPLIS.Domain.AuditInfos;

namespace CADPLIS.Application.Contracts.Monitorings
{
   public interface IMonitoringAppService
   {
       Task<Paginator<AuditInfoDto>> GetPageApiList(int pageSize,int pageIndex);
   }
}
