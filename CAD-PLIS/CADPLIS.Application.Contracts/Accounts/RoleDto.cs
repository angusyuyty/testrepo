using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Accounts
{
    public class RoleInfoDto
    {
        [StringLength(64, ErrorMessage = "ErrorInvalidLength", MinimumLength = 2)]
        [RegularExpression(@"[^\s]+", ErrorMessage = "SpacesNotPermitted")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public List<string> Permissions { get; set; }

        public string FormattedPermissions
        {
            get
            {
                return String.Join(", ", Permissions.ToArray());
            }
        }
        public Guid Id { get; set; }
    }
}
