using CADPLIS.Common;
using CADPLIS.Model;
using CADPLIS.Server.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CADPLIS.Server
{
    public class AuditLogActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<AuditLogActionFilter> _logger;
        private readonly IAuditLogService _auditLogService;

        public AuditLogActionFilter(ILogger<AuditLogActionFilter> logger, IAuditLogService auditLogService)
        {
            _logger = logger;
            _auditLogService = auditLogService;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!ShouldSaveAudit(context))
            {
                await next();
                return;
            }
            var method = context.HttpContext.Request.Method;
            var controllerName = context.ActionDescriptor.RouteValues["controller"];
            var actionName = context.ActionDescriptor.RouteValues["action"];
            var ip = context.HttpContext?.Connection.RemoteIpAddress.ToString();
            var arguments = Newtonsoft.Json.JsonConvert.SerializeObject(context.ActionArguments);
            var browserInfo = context.HttpContext.Request.Headers["User-Agent"].ToString();
            ActionExecutedContext result = null;
            Exception exception = null;
            string returnValue = null;
            var stopwatch = Stopwatch.StartNew();


            try
            {
                result = await next();
                if (result.Exception != null && !result.ExceptionHandled)
                {
                    exception = result.Exception;
                }
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                // auditInfo.ExecutionDuration = Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds);
                stopwatch.Stop();
                var executionDuration = stopwatch.Elapsed.TotalMilliseconds;
                var auditInfo = new AuditInfo()
                {
                    Id = UniqueId.Generate(),
                    Operator = "10000",
                    Controller = controllerName,
                    ActionName = actionName,
                    Method = method,
                    RequestArguments = arguments,
                    IpAddress = ip,
                    Browser = browserInfo,
                    ExecuteTime = Convert.ToInt32(executionDuration)
                };
                if (exception != null)
                {
                    auditInfo.ErrorMsg = exception.Message;
                }
                _auditLogService.SaveLog(auditInfo);
                if (result != null)
                {
                    switch (result.Result)
                    {
                        case ObjectResult objectResult:
                            returnValue = JsonConvert.SerializeObject(objectResult.Value);
                            break;

                        case JsonResult jsonResult:
                            returnValue = JsonConvert.SerializeObject(jsonResult.Value);
                            break;

                        case ContentResult contentResult:
                            returnValue = contentResult.Content;
                            break;
                    }
                }

            }
        }
        private bool ShouldSaveAudit(ActionExecutingContext context)
        {
            if (!(context.ActionDescriptor is ControllerActionDescriptor))
                return false;
            var methodInfo = (context.ActionDescriptor as ControllerActionDescriptor).MethodInfo;

            if (methodInfo == null)
            {
                return false;
            }
            if (!methodInfo.IsPublic)
            {
                return false;
            }
            if (methodInfo.GetCustomAttribute<DisableAuditingAttribute>() != null)
            {
                return false;
            }
            return true;
        }
    }
}

