using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.ToDoLists
{
    public class ToDoListDto
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
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }

    }
}
