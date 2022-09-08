using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.Application.Contracts.WorkFlows;

namespace CADPLIS.EntityFrameworkCore.WorkFlowDataAccess
{
    public interface IDocumentRepository
    {
        DocumentDto InsertOrUpdate(DocumentDto doc);
        List<DocumentDto> Get(out int count, int page = 1, int pageSize = 128);
        DocumentDto Get(Guid id, bool loadChildEntities = true);
        List<DocumentDto> GetByIds(List<Guid> ids);
        void Delete(Guid[] ids);
        void ChangeState(Guid id, string nextState, string nextStateName);
        bool IsAuthorsBoss(Guid documentId, Guid identityId);
        IEnumerable<string> GetAuthorsBoss(Guid documentId);
    }
}
