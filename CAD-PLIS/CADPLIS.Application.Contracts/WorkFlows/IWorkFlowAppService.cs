using CADPLIS.Domain;
using CADPLIS.Domain.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.WorkFlows
{
    public interface IWorkFlowAppService
    {
        Task<Paginator<WorkFlowDocument>> GetPageWorkFlows(int pageSize, int pageIndex);
        Task<Paginator<WorkFlowDocumentDto>> GetPageInbox(string userId, int pageSize, int pageIndex);
        Task<WorkFlowDocumentDto> GetDocument(string userId, Guid? Id);
        Task InsertOrUpdate(DocumentViewModel documentViewModel);
        Task InsertOrUpdate(WorkFlowDocument workFlowDocument);
        Task ExecuteCommand(string userId, CommandModel commandModel);

        void Delete(Guid[] ids);
    }
}
