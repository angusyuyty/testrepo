using AutoMapper;
using CADPLIS.Application.Contracts.Logs;
using CADPLIS.Domain;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Logs
{
    public class LogRecordDetailAppService : ILogRecordDetailAppService
    {
        private readonly IMapper _autoMapper;
        private readonly PlisDbcontext _plisDbcontext;
        public LogRecordDetailAppService(IMapper mapper, PlisDbcontext plisDbcontext)
        {
            _autoMapper = mapper;
            _plisDbcontext = plisDbcontext;
        }

        public async Task<Paginator<LogRecordDetailDto>> GetPageListAsync(int pageSize, int pageIndex)
        {
            Paginator<LogRecordDetailDto> page = new Paginator<LogRecordDetailDto>();
            var res = _plisDbcontext.LogRecordDetails;
            var datasource = await _plisDbcontext.LogRecordDetails.Select(r => new LogRecordDetailDto
            {
                LogOperator = r.LogOperator,
                CreateTime = new DateTime(r.CreateTime.Year, r.CreateTime.Month, r.CreateTime.Day, r.CreateTime.Hour, r.CreateTime.Minute, 0),
                Desc = "table" + r.OperationTable + ",FieldName:" + r.FieldName + " ,OriginalValue:" + r.OriginalValue + ",CurrentValue：" + r.CurrentValue
            }).GroupBy(g => new { g.LogOperator, g.CreateTime }).Select(g => new LogRecordDetailDto
            {
                LogOperator = g.Key.LogOperator,
                CreateTime = g.Key.CreateTime,
            })
            .Skip(pageSize * pageIndex).Take(pageSize)
            .AsNoTracking()
            .ToListAsync();
            var result = new List<LogRecordDetailDto>();
            foreach (var item in datasource.ToList())
            {
                LogRecordDetailDto model = new LogRecordDetailDto();
                model.LogOperator = item.LogOperator;
                model.CreateTime = item.CreateTime;
                var desc = "";
                var Operationtable = "";
                var action = "";
                try
                {
                    var logRecordResult = _plisDbcontext.LogRecordDetails.Where(r => r.LogOperator == item.LogOperator).ToList().Where(r => r.CreateTime.ToString("yyyy-MM-dd HH:mm") == item.CreateTime.ToString("yyyy-MM-dd HH:mm"));
                    foreach (var ditem in logRecordResult)
                    {
                        if (Operationtable != ditem.OperationTable || action != ditem.OperationAction)
                        {
                            desc += ditem.LogContent + "；";
                            Operationtable = ditem.OperationTable;
                            action = ditem.OperationAction;
                            model.LogChildrens.Add(ditem.LogContent);
                        }
                        model.ContentChildrens.Add(_autoMapper.Map<LogRecordDetailDto>(ditem));
                    }
                }
                catch (Exception e)
                {
                }

                model.Desc = desc;
                result.Add(model);
            }
            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            page.pageCount = datasource.Count();
            page.data = _autoMapper.Map<List<LogRecordDetailDto>>(result);

            return page;

        }

    }
}
