using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.AuditInfos
{
    public static class AuditInfoConsts
    {
        public static int MaxIdLength { get; set; } = 36;
        public static int MaxOperatorLength { get; set; } = 36;
        public static int MaxControllerLength { get; set; } = 36;
        public static int MaxActionNameLength { get; set; } = 36;
        public static int MaxMethodLength { get; set; } = 18;
        public static int MaxIpAddressLength { get; set; } = 36;
        public static int MaxBrowserLength { get; set; } = 256;
        public static int MaxErrorMsgLength { get; set; } = 512;
    }
}
