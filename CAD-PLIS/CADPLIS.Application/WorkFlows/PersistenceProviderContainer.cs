
using CADPLIS.EntityFrameworkCore.WorkFlowDataAccess;
using Microsoft.Extensions.Configuration;
using OptimaJet.Workflow.Core.Persistence;
using OptimaJet.Workflow.DbPersistence;


namespace CADPLIS.Application.WorkFlows
{
    public class PersistenceProviderContainer : IPersistenceProviderContainer
    {
        public PersistenceProviderContainer(IConfiguration config)
        {
            Provider = new MSSQLProvider(config.GetConnectionString("DefaultConnection"));
        }

        public IWorkflowProvider Provider { get; private set; }
    }
}
