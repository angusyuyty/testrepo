using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.GeneralActionLogs
{
    public class GeneralActionLogConsts
    {
        public static int MaxKeyLength { get; set; } = 200;
        public static int MaxSubKeyLength { get; set; } = 200;
        public static int MaxFormLength { get; set; } = 200;
        public static int MaxActionLength { get; set; } = 100;
        public static int MaxActionTypeLength { get; set; } = 100;
        public static int MaxActionByLength { get; set; } = 100;
        public static int MaxActionByRoleLength { get; set; } = 100;
    }
}
