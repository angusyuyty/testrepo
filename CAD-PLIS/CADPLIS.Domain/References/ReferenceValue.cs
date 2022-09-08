using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.References
{
    [Table("PLIS_REFERENCE_VALUE")]
    public class ReferenceValue
    {
        public int Id { get; set; }
        public string ReferenceType { get; set; }
        public int Value { get; set; }

    }
}
