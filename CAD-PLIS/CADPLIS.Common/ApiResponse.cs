using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CADPLIS.Common
{
    public class ApiResponse<T>
    {
        [DataMember]
        public int StatusCode { get; set; }

        public bool IsSuccessStatusCode => StatusCode >= 200 && StatusCode < 300;

        [DataMember]
        public string Message { get; set; }

        public T Result { get; set; }

        [JsonConstructor]
        public ApiResponse(int statusCode, string message = "")
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
    [Serializable]
    [DataContract]
    public class ApiResponse : ApiResponse<object>
    {
        [JsonConstructor]
        public ApiResponse(int statusCode, string message = "", object result = null) : base(statusCode, message)
        {
            StatusCode = statusCode;
            Message = message;
            Result = result;
        }

        public ApiResponse(int statusCode) : base(statusCode, "")
        {
            StatusCode = statusCode;
        }
    }
}
