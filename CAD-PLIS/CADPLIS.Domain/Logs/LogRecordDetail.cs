using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Logs
{
    [Table("LogRecordDetail")]
    public class LogRecordDetail
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

    }
}
