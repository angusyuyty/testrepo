using OptimaJet.Workflow.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.WorkFlows
{
    public class DocumentViewModel : DocumentDto
    {

        public string AuthorName { get; set; }
        public string ManagerName { get; set; }
        public DocumentCommandModel[] Commands { get; set; }

        public Dictionary<string, string> AvailiableStates { get; set; }
        public List<DocumentApprovalHistory> HistoryModel { get; set; }
        public DocumentViewModel()
        {
            Commands = new DocumentCommandModel[0];
            AvailiableStates = new Dictionary<string, string> { };
            HistoryModel = new List<DocumentApprovalHistory>();
        }

        public string AddingDate { get; set; }
       
        public List<CommandName> AvailableCommands { get; set; }
    }

    public class DocumentCommandModel
    {
        public string key { get; set; }
        public string value { get; set; }
        public OptimaJet.Workflow.Core.Model.TransitionClassifier Classifier { get; set; }
    }
}
