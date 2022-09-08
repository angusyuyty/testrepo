using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Functions
{
    public class FunctionDto
    {
        public int Id { get; set; }
        [Required]
        public string FunctionId { get; set; }
        public string FunctionType { get; set; }
        public string FunctionDescription { get; set; }
        public int? DisplaySequence { get; set; }
        public bool? SystemFunction { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedUserRoleId { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedUserRoleId { get; set; }
        public string UpdatedTimeText { get; set; }
        public string CreatedTimeText { get; set; }

    }
}
