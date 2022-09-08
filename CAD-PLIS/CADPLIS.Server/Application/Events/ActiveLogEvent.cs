using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Application.Events
{
    public class ActiveLogEvent : INotification
    {
        public string Key { get; set; }
        public string SubKey { get; set; }
        public string Form { get; set; } 
        public string Action { get; set; }
        public string ActionType {  get; set; }
    }
}
