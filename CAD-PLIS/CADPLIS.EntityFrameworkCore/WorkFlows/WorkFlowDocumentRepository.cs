using CADPLIS.Domain.WorkFlows;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.WorkFlows
{
    public class WorkFlowDocumentRepository : EfBaseRepository<WorkFlowDocument>, IWorkFlowDocumentRepository
    {
        public WorkFlowDocumentRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }

        public async Task<WorkFlowDocument> FindAsync(Expression<Func<WorkFlowDocument, bool>> whereLambda)
        {
            return await FindModelAsync(whereLambda);
        }

        public async Task<List<WorkFlowDocument>> GetPageListAsync(int pageSize, int pageIndex)
        {
            return await DbSet.AsNoTracking().PageBy(pageSize * pageIndex, pageSize).ToListAsync();
        }

        public async Task InsertAsync(WorkFlowDocument workFlowDocument, bool autoSave)
        {
            await AddAsync(workFlowDocument, autoSave);
        }
        public async Task ModifyAsync(WorkFlowDocument model, bool autoSave = false)
        {
            await EditAsync(model, autoSave);
        }
        public async Task<List<WorkFlowDocument>> GetByIds(List<Guid> ids)
        {
           return await FindListAsync(x => ids.Contains(x.Id));
        }
    }
}
