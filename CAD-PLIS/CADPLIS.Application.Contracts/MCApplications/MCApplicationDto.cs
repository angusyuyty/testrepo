using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.MCApplications
{
    public class MCApplicationDto
    {
        public int Id { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationType { get; set; }
        public string ApplicationStatus { get; set; }
        public string ApplicantUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
    }
}
