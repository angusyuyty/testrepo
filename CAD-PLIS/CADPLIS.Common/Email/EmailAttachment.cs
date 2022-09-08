using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.Email
{
    public class EmailAttachment
    {
        public MemoryStream stream { get; set; }

        public string FileName { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public DateTime ReadDate { get; set; }
    }
}
