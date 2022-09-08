using CADPLIS.Application.Contracts.GeneralActionLogs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CADPLIS.Server.Application.Events
{
    public class ActiveLogHandler : INotificationHandler<ActiveLogEvent>
    {
        private readonly IGeneralActionLogAppService _generalActionLogAppService;
        public ActiveLogHandler(IGeneralActionLogAppService generalActionLogAppService)
        {
            _generalActionLogAppService = generalActionLogAppService;
        }


        public async Task Handle(ActiveLogEvent notification, CancellationToken cancellationToken)
        {
            var model = new GeneralActionLogDto
            {
                Key = notification.Key,
                SubKey = notification.SubKey,
                Form = notification.Form,
                Action=notification.Action,
                ActionType=notification.ActionType,
                ActionBy="admin",
                ActionByRole="administrator",
                ActionDatetime=DateTime.Now
            };
           await _generalActionLogAppService.Insert(model);
        }
    }
}
