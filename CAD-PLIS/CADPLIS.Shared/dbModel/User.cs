using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model
{
    [Table("User")]
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
    }
}
