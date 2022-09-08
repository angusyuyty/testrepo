using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.Logs
{
    public class LogRecordDetailConsts
    {
        public static int MaxIdLength { get; set; } = 36;
        public static int MaxLogIDLength { get; set; } = 36;
        public static int MaxFieldNameLength { get; set; } = 36;
        public static int MaxOriginalValueLength { get; set; } = 500;
        public static int MaxCurrentValueLength { get; set; } = 500;
        public static int MaxLogOperatorLength { get; set; } = 36;
        public static int MaxOperationKeyIDLength { get; set; } = 36;
        public static int MaxOperationTableLength { get; set; } = 36;
        public static int MaxOperationActionLength { get; set; } = 36;
        public static int MaxLogContentLength { get; set; } = 200;
    }
}
