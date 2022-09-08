using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.Functions
{
    public class GroupAccessibleFunctionConsts
    {
        public static int MaxGroupIdLength { get; set; } = 100;
        public static int MaxFunctionIdLength { get; set; } = 100;
        public static int MaxCreatedByLength { get; set; } = 50;
        public static int MaxCreatedUserRoleIdLength { get; set; } = 100;
        public static int MaxUpdatedByLength { get; set; } = 50;
        public static int MaxUpdatedUserRoleIdLength { get; set; } = 100;
    }
}
