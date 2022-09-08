using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Shared.ToDoLists
{
    public class ToDoListConsts
    {
        public static int MaxCategoryLength { get; set; } = 100;
        public static int MaxNotificationTypeLength { get; set; } = 100;
        public static int MaxWorkflowStatusFromLength { get; set; } = 200;
        public static int MaxWorkflowStatusToLength { get; set; } = 200;
        public static int MaxDescriptionLength { get; set; } = 500;
        public static int MaxSendFromLength { get; set; } = 100;
        public static int MaxSendToLength { get; set; } = 100;
        public static int MaxStatusLength { get; set; } = 100;
        public static int MaxCreatedByLength { get; set; } = 50;
        public static int MaxCreatedUserRoleIdLength { get; set; } = 100;
        public static int MaxUpdatedByLength { get; set; } = 50;
        public static int MaxUpdatedUserRoleIdLength { get; set; } = 100;

    }
}
