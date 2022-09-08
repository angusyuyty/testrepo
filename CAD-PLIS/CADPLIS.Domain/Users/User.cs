using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Users
{
    public class User:BaseInfo
    {
        public int Id { get; set; }
        public int? UId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public bool? Is2FAEnabled { get; set; }
        public string RecState { get; set; }
        public string CorpAdmin { get; set; }


    }
}
