
using CADPLIS.Domain.WorkFlows;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using CADPLIS.EntityFrameworkCore.WorkFlowDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Application.WorkflowProvider;

namespace CADPLIS.Application.WorkFlows
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly PlisDbcontext _sampleContext;
        private readonly IMapper _autoMapper;
        public DocumentRepository(PlisDbcontext sampleContext, IMapper mapper)
        {
            _sampleContext = sampleContext;
            _autoMapper = mapper;
        }

        public void ChangeState(Guid id, string nextState,  string nextStateName)
        {
            var document = _sampleContext.WorkFlowDocuments.Find(id);//         GetDocument(id);
            if (document == null)
                return;

            document.State = nextState;
            document.StateName = nextStateName;
            
            _sampleContext.SaveChanges();
        }
        
        public void Delete(Guid[] ids)
        {
            var objs = _sampleContext.Documents.Where(x => ids.Contains(x.Id));
            
            foreach (var id in ids)
            {
                WorkflowInit.Runtime.PersistenceProvider.DropWorkflowInboxAsync(id).GetAwaiter().GetResult();
                WorkflowInit.Runtime.PersistenceProvider.DropApprovalHistoryByProcessIdAsync(id).GetAwaiter().GetResult();
            }
            
            _sampleContext.Documents.RemoveRange(objs);

            _sampleContext.SaveChanges();
        }

        public List<DocumentDto> Get(out int count, int page = 1, int pageSize = 128)
        {
            int actual = page * pageSize;
            var query = _sampleContext.Documents.OrderByDescending(c => c.Number);
            count = query.Count();
            return query.Include(x => x.Author)
                        .Include(x => x.Manager)
                        .Skip(actual)
                        .Take(pageSize)
                        .ToList()
                        .Select(d => _autoMapper.Map<DocumentDto>(d)).ToList();
        }
        
        public List<DocumentDto> GetByIds(List<Guid> ids)
        {
            var query = _sampleContext.Documents.Where(x => ids.Contains(x.Id));
            return query.Include(x => x.Author)
                .Include(x => x.Manager)
                .ToList()
                .Select(d => _autoMapper.Map<DocumentDto>(d)).ToList();
        }

        public IEnumerable<string> GetAuthorsBoss(Guid documentId)
        {
            var document = _sampleContext.Documents.Find(documentId);
            if (document == null)
                return new List<string> { };

            return
                _sampleContext.VHeads.Where(h => h.Id == document.AuthorId)
                    .Select(h => h.HeadId)
                    .ToList()
                    .Select(c => c.ToString());
        }

        public DocumentDto InsertOrUpdate(DocumentDto doc)
        {
            Document target = null;
            if (doc.Id != Guid.Empty)
            {
                target = _sampleContext.Documents.Find(doc.Id);
                if (target == null)
                {
                    return null;
                }
            }
            else
            {
                target = new Document
                {
                    Id = Guid.NewGuid(),
                    AuthorId = doc.AuthorId,
                    StateName = doc.StateName
                };
                _sampleContext.Documents.Add(target);
            }

            target.Name = doc.Name;
            target.ManagerId = doc.ManagerId;
            target.Comment = doc.Comment;
            target.Sum = doc.Sum;

            _sampleContext.SaveChanges();

            doc.Id = target.Id;
            doc.Number = target.Number;

            return doc;
        }

        public bool IsAuthorsBoss(Guid documentId, Guid identityId)
        {
            var document = _sampleContext.Documents.Find(documentId);
            if (document == null)
                return false;
            return _sampleContext.VHeads.Count(h => h.Id == document.AuthorId && h.HeadId == identityId) > 0;
        }

        public DocumentDto Get(Guid id, bool loadChildEntities = true)
        {
            Document document = GetDocument(id, loadChildEntities);
            if (document == null) return null;
            return _autoMapper.Map<DocumentDto>(document);
        }

        private Document GetDocument(Guid id, bool loadChildEntities = true)
        {
            Document document = null;

            if (!loadChildEntities)
            {
                document = _sampleContext.Documents.Find(id);
            }
            else
            {
                document = _sampleContext.Documents
                                         .Include(x => x.Author)
                                         .Include(x => x.Manager).FirstOrDefault(x => x.Id == id);
            }

            return document;

        }

        private string GetEmployeesString(IEnumerable<string> identities)
        {
            var identitiesGuid = identities.Select(c => new Guid(c));

            var employees = _sampleContext.Employees.Where(e => identitiesGuid.Contains(e.Id)).ToList();

            var sb = new StringBuilder();
            bool isFirst = true;
            foreach (var employee in employees)
            {
                if (!isFirst)
                    sb.Append(",");
                isFirst = false;

                sb.Append(employee.Name);
            }

            return sb.ToString();
        }
    }
}
