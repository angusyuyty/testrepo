using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.MCApplications
{
    public class MCApplicationCountDto
    {
        public int SavedAsDraftNum { get; set; }
        public int SubmitNum { get; set; }
        public int ActionRequiredNum { get; set; }
        public int ValidNum { get; set; }
        public int ExpireIn1MonthNum { get; set; }
        public int ExpiredNum { get; set; }
        public int ApplicantsNum { get; set; }
        public int SuspendedNum { get; set; }
        public int OutstandingNum { get; set; }
        public int SubmittedNum { get; set; }
        public int PendingToConfirmNum { get; set; }
        public int ConfirmedNum { get; set; }
    }
}
