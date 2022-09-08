using System;
using System.Reflection;
using System.Xml.Linq;
using OptimaJet.Workflow.Core.Builder;
using OptimaJet.Workflow.Core.Parser;
using OptimaJet.Workflow.Core.Runtime;
using System.Threading.Tasks;
using System.Collections.Generic;
using OptimaJet.Workflow.Core.Model;
using OptimaJet.Workflow.Plugins;
using CADPLIS.Application.Contracts.WorkFlowDataAccess;
using CADPLIS.EntityFrameworkCore.WorkFlowDataAccess;
using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Domain.WorkFlows;

namespace CADPLIS.Application.WorkflowProvider
{
    public static class WorkflowInit
    {
        private static volatile WorkflowRuntime _runtime;

        private static readonly object _sync = new object();

        public static IDataServiceProvider DataServiceProvider { get; private set; }

        public static WorkflowRuntime Create(IDataServiceProvider dataServiceProvider)
        {
            DataServiceProvider = dataServiceProvider;
            CreateRuntime();
            return Runtime;
        }

        private static void CreateRuntime()
        {
            if (_runtime == null)
            {
                lock (_sync)
                {
                    if (_runtime == null)
                    {
                        var loopPlugin = new LoopPlugin();
                        var filePlugin = new FilePlugin();
                        var approvalPlugin = new ApprovalPlugin();

                        #region ApprovalPlugin Settings

                        approvalPlugin.GetUserNamesByIds += GeUserNamesByIds;
                        // approvalPlugin.AutoApprovalHistory = true;
                        // approvalPlugin.NameParameterForComment = "Comment";

                        #endregion ApprovalPlugin Settings

                        var basicPlugin = new BasicPlugin();

                        #region BasicPlugin Settings

                        //Settings for SendEmail actions
                        basicPlugin.Setting_Mailserver = "smtp.126.com";
                        basicPlugin.Setting_MailserverPort = 25;
                        basicPlugin.Setting_MailserverFrom = "xiongzhongkun@126.com";
                        basicPlugin.Setting_MailserverLogin = "xiongzhongkun@126.com";
                        basicPlugin.Setting_MailserverPassword = "MSXZZJKJULXSSZGW";
                        basicPlugin.Setting_MailserverSsl = false;

                        //not implemented
                        basicPlugin.ApproversInStageAsync += ApproversInStageAsync;

                        basicPlugin.UsersInRoleAsync += UsersInRoleAsync;
                        basicPlugin.CheckPredefinedActorAsync += CheckPredefinedActorAsync;
                        basicPlugin.GetPredefinedIdentitiesAsync += GetPredefinedIdentitiesAsync;
                        basicPlugin.UpdateDocumentStateAsync += UpdateDocumentStateAsync;

                        basicPlugin.FormatSendEmail();
                        basicPlugin.WithActors(new List<string>() { "Manager", "Author" });

                        #endregion BasicPlugin Settings
                        var provider = DataServiceProvider.Get<IPersistenceProviderContainer>().Provider;

                        var externalParametersProvider = new ExternalParametersProvider();
                        externalParametersProvider.GetDocument += GetDocument;

                        var builder = new WorkflowBuilder<XElement>(provider, new XmlWorkflowParser(), provider).WithDefaultCache();
                        _runtime = new WorkflowRuntime()
                            .WithBuilder(builder)
                            .WithActionProvider(new ActionProvider(DataServiceProvider))
                            .WithRuleProvider(new RuleProvider(DataServiceProvider))
                            .WithDesignerAutocompleteProvider(new AutoCompleteProvider())
                            .WithPersistenceProvider(provider)
                            .SwitchAutoUpdateSchemeBeforeGetAvailableCommandsOn()
                            .RegisterAssemblyForCodeActions(Assembly.GetExecutingAssembly())
                            .WithPlugins(null, basicPlugin, loopPlugin, filePlugin, approvalPlugin)
                            .WithExternalParametersProvider(externalParametersProvider)
                            .CodeActionsDebugOn()
                            .AsSingleServer() //.AsMultiServer()

                            //    .WithConsoleAllLogger()
                            .Start();

                    }
                }
            }
        }

        public static async Task<IEnumerable<string>> UsersInRoleAsync(string roleName, ProcessInstance processInstance)
        {
            var provider = DataServiceProvider.Get<IEmployeeRepository>();
            return await Task.FromResult(provider.GetInRole(roleName));
        }

        public static async Task<bool> CheckPredefinedActorAsync(ProcessInstance processInstance, WorkflowRuntime runtime, string parameter, string identityId)
        {
            var doc = GetDocument(processInstance);
            if (parameter == "Author")
            {
                if (identityId == doc.AuthorId)
                    return await Task.FromResult(true);
                else
                    return await Task.FromResult(false);
            }

            if (parameter == "Manager")
            {
                if (identityId == doc.ManagerId)
                    return await Task.FromResult(true);
                else
                    return await Task.FromResult(false);
            }
            return await Task.FromResult(false);
        }

        public static async Task<IEnumerable<string>> GetPredefinedIdentitiesAsync(ProcessInstance processInstance, WorkflowRuntime runtime, string parameter)
        {
            var doc = GetDocument(processInstance);

            if (parameter == "Author")
                return await Task.FromResult(new List<string>() { doc.AuthorId.ToString() });

            if (parameter == "Manager")
                return await Task.FromResult(new List<string>() { doc.ManagerId.ToString() });

            return await Task.FromResult(new List<string>());
        }

        public static async Task<IEnumerable<string>> ApproversInStageAsync(string stageName, ProcessInstance processInstance)
        {
            throw new NotImplementedException();
        }
        public static List<string> GeUserNamesByIds(List<string> idS)
        {
            var employeeRepository = DataServiceProvider.Get<IEmployeeRepository>();
            List<string> names = new List<string>();
            foreach (var id in idS)
            {
                names.Add(employeeRepository.GetNameById(id));
                //if (Guid.TryParse(id, out Guid guid))
                //    names.Add(employeeRepository.GetNameById(guid));
                //else
                //    names.Add(id);
            }

            return names;
        }
        public static async Task UpdateDocumentStateAsync(ProcessInstance processInstance, string stateName, string localizedStateName)
        {
            var docRepository = await Task.FromResult(DataServiceProvider.Get<IDocumentRepository>());
            docRepository.ChangeState(processInstance.ProcessId, stateName, localizedStateName);
        }

        public static WorkFlowDocument GetDocument(ProcessInstance processInstance)
        {
            var docRepository = DataServiceProvider.Get<IWorkFlowDocumentRepository>();
            var doc = docRepository.FindAsync(u => u.Id.Equals(processInstance.ProcessId)).GetAwaiter().GetResult();
            return doc;
        }

        public static WorkflowRuntime Runtime => _runtime;

    }
}
