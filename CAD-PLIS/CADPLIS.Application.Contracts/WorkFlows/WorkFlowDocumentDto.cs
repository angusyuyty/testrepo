using CADPLIS.Application.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimaJet.Workflow.Core.Persistence;


namespace CADPLIS.Application.Contracts.WorkFlows
{
    public class WorkFlowDocumentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Comment { get; set; }
        public string AuthorId { get; set; }
        public string ManagerId { get; set; }
        public decimal Sum { get; set; }
        public string State { get; set; }
        public string StateName { get; set; }
        public UserDto Author { get; set; }
        public UserDto Manager { get; set; }
        public bool IsCheck { get; set; } = false;
        public string SchemeCode { get; set; }
        public string AuthorName { get; set; }
        public string ManagerName { get; set; }
        public DateTime? AddingDate { get; set; }
        public List<CommandName> AvailableCommands { get; set; }

    }
}
