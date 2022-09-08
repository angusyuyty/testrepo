using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.employers
{
    public class Employer
    {
        public int id { get; set; }
        public string employer_name { get; set; }
        public string email { get; set; }
        public string correspondence_tel_no { get; set; }
    }
}
