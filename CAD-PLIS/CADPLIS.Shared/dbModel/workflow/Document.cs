using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model.workflow
{
    [Table("Document")]
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
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
        public int? Point { get; set; }

        public Guid AuthorId { get; set; }

        public Guid? ManagerId { get; set; }

        public decimal Sum { get; set; }

        [Required]
        [StringLength(1024)]
        public string State { get; set; }

        [StringLength(1024)]
        public string StateName { get; set; }

        public virtual Employee Author { get; set; }

        public virtual Employee Manager { get; set; }
    }
}
