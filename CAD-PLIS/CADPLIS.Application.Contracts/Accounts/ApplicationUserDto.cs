using CADPLIS.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Accounts
{
    public class ApplicationUserDto
    {

        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string OtherName { get; set; }
        public List<string> Roles { get; set; }

        public Guid? GroupId { get; set; }

        public bool IsHead { get; set; }
        public string SetupCode { get; set; }
        public string BarcodeImageUrl { get; set; }
        public string ValidateCode { get; set; }


    }
}
