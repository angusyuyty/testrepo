using OptimaJet.Workflow.Core.Persistence;

namespace CADPLIS.EntityFrameworkCore.WorkFlowDataAccess
{
    public interface IPersistenceProviderContainer
    {
        IWorkflowProvider Provider { get; }
    }
}
