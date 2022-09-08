using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.SystemAuditLogs
{
    public class GroupLogConsts
    {
        public static int MaxGroupIdLength { get; set; } = 100;
        public static int MaxGroupDescriptionLength { get; set; } = 200;
        public static int MaxCreatedByLength { get; set; } = 50;
        public static int MaxCreatedUserRoleIdLength { get; set; } = 100;
        public static int MaxLastUpdatedByLength { get; set; } = 50;
        public static int MaxLastUpdatedUserRoleIdLength { get; set; } = 100;
        public static int MaxUpdatedByLength { get; set; } = 50;
        public static int MaxUpdatedUserRoleIdLength { get; set; } = 100;
        public static int MaxDataTypeLength { get; set; } = 50;
        public static int MaxActionLength { get; set; } = 100;
    }
}
