using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Logs
{
    public interface ILogRecordDetailAppService:IBaseAppService
    {
        Task<Paginator<LogRecordDetailDto>> GetPageListAsync(int pageSize, int pageIndex);

    }
}
