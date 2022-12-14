using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.WorkFlows
{
    [Table("WorkFlowDocument")]
    public class WorkFlowDocument
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkFlowDocument()
        {
            State = "VacationRequestCreated";
            StateName = "Vacation request created";
        }

        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public string Comment { get; set; }

        public string AuthorId { get; set; }

        public string ManagerId { get; set; }

        public decimal Sum { get; set; }

        [Required]
        [StringLength(1024)]
        public string State { get; set; }

        [StringLength(1024)]
        public string StateName { get; set; }
        public string SchemeCode { get; set; }

    }


}
