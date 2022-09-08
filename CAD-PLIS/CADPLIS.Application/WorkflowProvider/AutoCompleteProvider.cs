using System.Collections.Generic;
using OptimaJet.Workflow.Core.Runtime;

namespace CADPLIS.Application.WorkflowProvider
{
    public class AutoCompleteProvider: IDesignerAutocompleteProvider
    {
        
        public List<string> GetAutocompleteSuggestions(SuggestionCategory category, string value, string schemeCode)
        {
            if (category == SuggestionCategory.RuleParameter && value == "CheckRole")
            {
                return new List<string>(){"BigBoss","Accountant"};
            }
            
            return null;
        }
    }
}
