using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.SystemAuditLogs
{
    public class UserLogConsts
    {
        public static int MaxUserIdLength { get; set; } = 50;
        public static int MaxUserNameLength { get; set; } = 50;
        public static int MaxPasswordLength { get; set; } = 100;
        public static int Maxcreator_user_idLength { get; set; } = 50;
        public static int MaxEmailLength { get; set; } = 100;
        public static int MaxUserTypeLength { get; set; } = 20;
        public static int MaxRecStateLength { get; set; } = 1;
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
