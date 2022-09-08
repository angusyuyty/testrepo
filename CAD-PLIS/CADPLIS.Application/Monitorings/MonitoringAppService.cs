using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CADPLIS.Application.Contracts.Monitorings;
using CADPLIS.Domain;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CADPLIS.Application.Monitorings
{
    public class MonitoringAppService : IMonitoringAppService
    {
        private readonly PlisDbcontext _plisDbcontext;
        private readonly IMapper _mapper;
        public MonitoringAppService(PlisDbcontext plisDbcontext, IMapper mapper)
        {
            _plisDbcontext = plisDbcontext;
            _mapper = mapper;
        }
        public async Task<Paginator<AuditInfoDto>> GetPageApiList(int pageSize, int pageIndex)
        {
            var dataSource =  _plisDbcontext.AuditInfos;
            var pageData = new Paginator<AuditInfoDto>();
            pageData.pageCount = dataSource.Count();
            pageData.pageIndex = pageIndex;
            pageData.pageSize = pageSize;

            var result = await dataSource.OrderByDescending(u=>u.CreatedTime).Skip(pageSize * pageIndex).Take(pageSize).AsNoTracking().ToListAsync();
            pageData.data = _mapper.Map<List<AuditInfoDto>>(result);

            return pageData;
        }

    }
}
