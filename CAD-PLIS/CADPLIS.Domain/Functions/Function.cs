using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Functions
{
    [Table("PLIS_FUNCTION")]
    public class Function:BaseInfo
    {
        public int Id { get; set; }
        public string FunctionId { get; set; }
        public string FunctionType { get; set; }
        public string FunctionDescription { get; set; }
        public int? DisplaySequence { get; set; }
        public bool? SystemFunction { get; set; }

    }
}
