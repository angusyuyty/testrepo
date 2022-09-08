using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Application.Events
{
    public class FindPasswordEvent : INotification
    {
        public string Email { get; set; }
    }
}
