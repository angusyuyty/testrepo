using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.WorkFlows
{
  public  class CommandModel
    {
        public Guid Id { get; set; }
        public string CommandName { get; set; }
        public string Comment { get; set; }
    }
}
