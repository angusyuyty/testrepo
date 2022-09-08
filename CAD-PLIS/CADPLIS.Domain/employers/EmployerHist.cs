using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.employers
{
    public class EmployerHist
    {
        public int id { get; set; }
        public int uid { get; set; }
        public int employer_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string rec_state { get; set; }
        public DateTime created_date { get; set; }
        public int creator_user_id { get; set; }
        public string creator_urid { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int last_updated_user_id { get; set; }
        public string last_updated_urid { get; set; }
    }
}
