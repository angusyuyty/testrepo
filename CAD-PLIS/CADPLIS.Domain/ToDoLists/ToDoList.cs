using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.ToDoLists
{
    public class ToDoList:BaseInfo
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string NotificationType { get; set; }
        public DateTime NotificationDate { get; set; }
        public int? ApplicationNo { get; set; }
        public string WorkflowStatusFrom { get; set; }
        public string WorkflowStatusTo { get; set; }
        public string Description { get; set; }
        public string SendFrom { get; set; }
        public string SendTo { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }

    }
}
