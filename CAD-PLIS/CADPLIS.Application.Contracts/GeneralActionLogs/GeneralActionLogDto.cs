using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.GeneralActionLogs
{
    public class GeneralActionLogDto
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string SubKey { get; set; }
        public string Form { get; set; }
        public string Action { get; set; }
        public string ActionType {  get; set; }
        public string ActionBy { get; set; }
        public string ActionByRole { get; set; }
        public DateTime? ActionDatetime { get; set; }
    }
}
