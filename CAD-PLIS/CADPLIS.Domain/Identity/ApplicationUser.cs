using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Identity
{
    public partial class ApplicationUser: IdentityUser<Guid>
    {
        public Guid? GroupId { get; set; }

        public bool IsHead { get; set; }
    }
}
