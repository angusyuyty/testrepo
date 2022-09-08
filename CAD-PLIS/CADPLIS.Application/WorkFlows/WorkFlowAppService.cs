using AutoMapper;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Application.WorkflowProvider;
using CADPLIS.Domain;
using CADPLIS.Domain.Identity;
using CADPLIS.Domain.WorkFlows;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using CADPLIS.EntityFrameworkCore.WorkFlowDataAccess;
using Microsoft.AspNetCore.Identity;
using OptimaJet.Workflow.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.WorkFlows
{
    public class WorkFlowAppService : IWorkFlowAppService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IUserAppService _userAppService;
        private readonly IWorkFlowDocumentRepository _workFlowDocumentRepository;
        private readonly IMapper _mapper;
        public WorkFlowAppService(IDocumentRepository documentRepository, IUserAppService userAppService, IWorkFlowDocumentRepository workFlowDocumentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _userAppService = userAppService;
            _workFlowDocumentRepository = workFlowDocumentRepository;
            _mapper = mapper;
        }

        public async Task<Paginator<WorkFlowDocument>> GetPageWorkFlows(int pageSize, int pageIndex)
        {
            int count = 0;
            var docs = await _workFlowDocumentRepository.GetPageListAsync(pageSize, pageIndex);
            Paginator<WorkFlowDocument> paginator = new Paginator<WorkFlowDocument>();
            paginator.pageCount = 10;
            paginator.pageIndex = pageIndex;
            paginator.pageSize = pageSize;
            paginator.data = docs;
            return await Task.FromResult(paginator);
        }

        public async Task<Paginator<WorkFlowDocumentDto>> GetPageInbox(string userId, int pageSize, int pageIndex)
        {
            //var currentUser = await _userAppService.GetByLoginIdAsync(userId);
            //var identityId = currentUser.Id.ToString();
            var inbox = WorkflowInit.Runtime.PersistenceProvider
           .GetInboxByIdentityIdAsync(userId, Paging.Create(pageIndex + 1, pageSize)).Result;

            int count = WorkflowInit.Runtime.PersistenceProvider.GetInboxCountByIdentityIdAsync(userId).Result;
            var result =await GetDocumentsByInbox(inbox);
            Paginator<WorkFlowDocumentDto> paginator = new Paginator<WorkFlowDocumentDto>();
            paginator.pageIndex = pageIndex;
            paginator.pageSize = pageSize;
            paginator.pageCount = count;
            paginator.data = result;
            return paginator;
        }



        public async Task<WorkFlowDocumentDto> GetDocument(string userId, Guid? Id)
        {
            WorkFlowDocumentDto model = null;
            var currentUser = await _userAppService.GetByLoginIdAsync(userId);
            var identityId = currentUser.Id;
            if (Id.HasValue)
            {
                var d = await _workFlowDocumentRepository.FindAsync(u => u.Id == Id.Value);
                if (d != null)
                {
                    CreateWorkflowIfNotExists(Id.Value, d.SchemeCode);
                    UserDto mn = new UserDto();
                    if(!string.IsNullOrEmpty(d.ManagerId))
                        mn = await _userAppService.GetByLoginIdAsync(d.ManagerId);
                    model = new WorkFlowDocumentDto()
                    {
                        Id = d.Id,
                        AuthorId = d.AuthorId,
                        AuthorName = currentUser.UserName,
                        Comment = d.Comment,
                        ManagerId = d.ManagerId,
                        ManagerName = mn.UserName,
                        Name = d.Name,
                        Number = d.Number,
                        StateName = d.StateName,
                        State=d.State,
                        Sum = d.Sum,
                        SchemeCode=d.SchemeCode
                    };
                }
            }
            else
            {
                //Guid userId = identityId;
                //model = new DocumentViewModel()
                //{
                //    AuthorId = userId,
                //    AuthorName = currentUser.UserName,
                //    StateName = "Vacation request created"
                //};
            }
            return model;
        }

        public async Task InsertOrUpdate(DocumentViewModel documentViewModel)
        {
            DocumentDto docDto = (DocumentDto)documentViewModel;
            var doc = _documentRepository.InsertOrUpdate(docDto);

            if (WorkflowInit.Runtime.IsProcessExists(doc.Id))
                return;

            WorkflowInit.Runtime.CreateInstance(documentViewModel.SchemeCode, doc.Id);
            await Task.CompletedTask;
        }


        public async Task InsertOrUpdate(WorkFlowDocument workFlowDocument)
        {
            if (workFlowDocument.Id != default)
            {
                workFlowDocument.Id = Guid.NewGuid();
                await _workFlowDocumentRepository.ModifyAsync(workFlowDocument, true);
            }
            else
            {
                await _workFlowDocumentRepository.InsertAsync(workFlowDocument, true);
            }
            if (WorkflowInit.Runtime.IsProcessExists(workFlowDocument.Id))
                return;

            WorkflowInit.Runtime.CreateInstance(workFlowDocument.SchemeCode, workFlowDocument.Id);
            await Task.CompletedTask;
        }



        private void CreateWorkflowIfNotExists(Guid id, string schemeCode)
        {
            if (WorkflowInit.Runtime.IsProcessExists(id))
                return;

            WorkflowInit.Runtime.CreateInstance(schemeCode, id);
        }

        private async Task<List<WorkFlowDocumentDto>> GetDocumentsByInbox(List<InboxItem> inbox)
        {
            var ids = inbox.Select(x => x.ProcessId).ToList();
            var res = await _workFlowDocumentRepository.GetByIds(ids);
            var documents =_mapper.Map<List<WorkFlowDocumentDto>>(res);
            //.ToDictionary(x => x.Id, x => x);
            foreach (var inboxItem in inbox)
            {
                var item = documents.FirstOrDefault(u => u.Id == inboxItem.ProcessId);
                item.AvailableCommands = inboxItem.AvailableCommands;
                item.AddingDate = inboxItem.AddingDate;
            }

                //var docs = new List<WorkFlowDocument>();

                //foreach (var inboxItem in inbox)
                //{
                //    DocumentViewModel documentViewModel = new DocumentViewModel();
                //    if (documents.TryGetValue(inboxItem.ProcessId, out DocumentDto doc))
                //    {
                //        documentViewModel.Id = doc.Id;
                //        documentViewModel.AuthorId = doc.AuthorId;
                //        documentViewModel.AuthorName = doc.Author.Name;
                //        documentViewModel.Comment = doc.Comment;
                //        documentViewModel.ManagerId = doc.ManagerId;
                //        documentViewModel.ManagerName = doc.ManagerId.HasValue ? doc.Manager.Name : string.Empty;
                //        documentViewModel.Name = doc.Name;
                //        documentViewModel.Number = doc.Number;
                //        documentViewModel.StateName = doc.StateName;
                //        documentViewModel.Sum = doc.Sum;

                //        documentViewModel.AvailableCommands = inboxItem.AvailableCommands;
                //        documentViewModel.AddingDate = inboxItem.AddingDate.ToString();
                //        docs.Add(documentViewModel);
                //    }
                //}

                return documents;// docs;
        }


        public async Task ExecuteCommand(string userId, CommandModel commandModel)
        {
            try
            {
                var currentUser = await _userAppService.GetByLoginIdAsync(userId);
                //var currentUseId = currentUser.Id.ToString();
                var commands = WorkflowInit.Runtime.GetAvailableCommands(commandModel.Id, userId);

                var command =
                    commands.FirstOrDefault(
                        c => c.CommandName.Equals(commandModel.CommandName, StringComparison.CurrentCultureIgnoreCase));

                if (command == null)
                    return;

                if (command.Parameters.Count(p => p.ParameterName == "Comment") == 1)
                    command.Parameters.Single(p => p.ParameterName == "Comment").Value = commandModel.CommandName ?? string.Empty;
                WorkflowInit.Runtime.ExecuteCommand(command, userId, userId);
            }
            catch (Exception ex)
            {

            }

            // WorkflowInit.Runtime.ExecuteCommand(command, currentUser.Id.ToString(), currentUser.Id.ToString());
        }

        public void Delete(Guid[] ids)
        {
            _documentRepository.Delete(ids);
        }
    }
}
