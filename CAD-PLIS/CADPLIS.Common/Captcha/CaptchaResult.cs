using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.Captcha
{
    public class CaptchaResult
    {
        public string CaptchaCode { get; set; }

        public MemoryStream CaptchaMemoryStream { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
