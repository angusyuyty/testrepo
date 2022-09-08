using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.WorkFlows
{
    public interface IWorkFlowDocumentRepository
    {
        Task<WorkFlowDocument> FindAsync(Expression<Func<WorkFlowDocument, bool>> whereLambda);

        Task<List<WorkFlowDocument>> GetPageListAsync(int pageSize, int pageIndex);

         Task InsertAsync(WorkFlowDocument workFlowDocument, bool autoSave=false);

         Task ModifyAsync(WorkFlowDocument model, bool autoSave = false);
        Task<List<WorkFlowDocument>> GetByIds(List<Guid> ids);


    }
}
