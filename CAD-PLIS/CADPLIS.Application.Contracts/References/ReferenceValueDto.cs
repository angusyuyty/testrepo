using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.References
{
    public class ReferenceValueDto
    {
        public int Id { get; set; }
        public string ReferenceType { get; set; }
        public int Value { get; set; }
    }
}
