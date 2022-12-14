namespace CADPLIS.Domain.WorkFlows
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    [Table("WorkflowScheme")]
    public partial class WorkflowScheme
    {
        [Key]
        [StringLength(256)]
        public string Code { get; set; }

        [Required]
        public string Scheme { get; set; }
    }
}
