using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CADPLIS.Server.Application.Events
{
    public class FindUserEmailSenderHandler : INotificationHandler<FindPasswordEvent>
    {
        public Task Handle(FindPasswordEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
