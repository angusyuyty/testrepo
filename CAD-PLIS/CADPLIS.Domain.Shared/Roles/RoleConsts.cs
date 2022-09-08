using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.Roles
{
   public class RoleConsts
    {
        public static int Maxrole_idLength { get; set; } = 100;
        public static int Maxrole_descriptionLength { get; set; } = 200;
        public static int Maxcreator_user_idLength { get; set; } = 50;
        public static int Maxcreator_uridLength { get; set; } = 100;
        public static int Maxlast_updated_user_idLength { get; set; } = 50;
        public static int Maxlast_updated_uridLength { get; set; } = 100;

    }
}
