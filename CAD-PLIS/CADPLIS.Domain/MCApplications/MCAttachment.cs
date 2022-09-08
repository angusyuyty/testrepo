using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.MCApplications
{
    public class MCAttachment : BaseInfo
    {
        public int id { get; set; }
        public int ApplicationNo { get; set; }
        public String AttachmentArea { get; set; }
        public String AttachmentType { get; set; }
        public String AttachmentDescription { get; set; }
        public String AttachmentFileLoc { get; set; }
        public DateTime DocEffectiveDate { get; set; }
        public DateTime LastUploadDatetime { get; set; }
    }
}
