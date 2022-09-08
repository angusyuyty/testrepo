using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Logs
{
    public class LogRecordDetailDto
    {
        public string Id { get; set; }
        public string FieldName { get; set; }
        public string OriginalValue { get; set; }
        public string CurrentValue { get; set; }
        public DateTime CreateTime { get; set; }
        public string OperationKeyID { get; set; }
        public string LogOperator { get; set; }
        public string OperationTable { get; set; }
        public string OperationAction { get; set; }
        public string LogContent { get; set; }
        public string Desc { get; set; }
        public List<LogRecordDetailDto> ContentChildrens { get; set; } = new List<LogRecordDetailDto>();
        public List<string> LogChildrens { get; set; } = new List<string>();
    }
}
