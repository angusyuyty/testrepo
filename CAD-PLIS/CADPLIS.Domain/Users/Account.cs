using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Users
{
    public class Account
    {
        public int id { get; set; }
        public int uid { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string other_name { get; set; }
        public string c_name { get; set; }
        public string title { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string contact_no_prefix { get; set; }
        public string contact_no { get; set; }
        public string mobile_no_prefix { get; set; }
        public string mobile_no { get; set; }
        public string nationality { get; set; }
        public bool hk_resident { get; set; }
        public string HKID { get; set; }
        public string HKID_proof { get; set; }
        public string identity_doc { get; set; }
        public string identity_doc_proof { get; set; }
        public string residential_address_line1 { get; set; }
        public string residential_address_line2 { get; set; }
        public string residential_address_line3 { get; set; }
        public string residential_address_country { get; set; }
        public string residential_address_proof { get; set; }
        public string postal_address_line1 { get; set; }
        public string postal_address_line2 { get; set; }
        public string postal_address_line3 { get; set; }
        public string postal_address_country { get; set; }
        public string postal_address_proof { get; set; }
        public string employment_status { get; set; }
        public string rec_state { get; set; }
        public DateTime created_date { get; set; }
        public int creator_uid { get; set; }
        public string creator_urid { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? last_updated_uid { get; set; }
        public string last_updated_urid { get; set; }
    }
}
