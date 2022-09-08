using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.NavMenus
{
    public static class NavMenuConsts
    {
        public static int MaxIdLength { get; set; } = 36;
        public static int MaxMenuNameLength { get; set; } = 36;
        public static int MaxParentIdLength { get; set; } = 36;
        public static int MaxIconLength { get; set; } = 36;
        public static int MaxPermissionLength { get; set; } = 36;
        public static int MaxRouteUrlLength { get; set; } = 64;
    }
}
