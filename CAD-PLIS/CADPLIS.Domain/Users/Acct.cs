using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Users
{
    public class Acct
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string CName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public DateTime dob { get; set; }
        public string ContactNoPrefix { get; set; }
        public string ContactNo { get; set; }
        public string MobileNoPrefix { get; set; }
        public string MobileNo { get; set; }
    }
}
