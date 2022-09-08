using System.ComponentModel.DataAnnotations.Schema;

namespace CADPLIS.Model
{
    [Table("AuditInfo")]
    public class AuditInfo
    {
        public string Id { get; set; }
        public string Operator { get; set; }
        public string Controller { get; set; }
        public string ActionName { get; set; }
        public string Method { get; set; }
        public string RequestArguments { get; set; }
        public string IpAddress { get; set; }
        public string Browser { get; set; }
        public int ExecuteTime { get; set; }
        public string ErrorMsg { get; set; }
       
    }
}
