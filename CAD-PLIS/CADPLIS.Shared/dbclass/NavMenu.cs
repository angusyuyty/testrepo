using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model
{
    [Table("NavMenu")]
    public class NavMenu:ISoftDeleted,IOperInfo
    {
        public virtual string Id { get; set; }
        public virtual string MenuName { get; set; }
        public virtual string ParentId { get; set; }
        public virtual int OrderNo { get; set; }
        public virtual string Icon { get; set; }
        public virtual string RouteUrl { get; set; }
        public virtual string Permission { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedTime { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual DateTime? UpdatedTime { get; set; }
    }
}
