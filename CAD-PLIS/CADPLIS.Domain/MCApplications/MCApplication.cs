using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.MCApplications
{
    public class MCApplication : BaseInfo
    {
        public int Id { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationType {  get; set; }
        public string ApplicationStatus { get; set; }
        public string ApplicantUserId { get; set; }
    }
}
