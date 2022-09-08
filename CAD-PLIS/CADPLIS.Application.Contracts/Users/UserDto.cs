using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Users
{
    public class UserDto
    {
        public int Id { get; set; }
        public int? UId { get; set; }
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string UserType { get; set; }
        public bool? Is2FAEnabled { get; set; }
        [Required]
        public string RecState { get; set; }
        public string CorpAdmin { get; set; }

        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
        public string UpdatedTimeText { get; set; }
        public string CreatedTimeText { get; set; }
        public string SetupCode { get; set; }
        public string BarcodeImageUrl { get; set; }
        public string ValidateCode { get; set; }

    }
}
