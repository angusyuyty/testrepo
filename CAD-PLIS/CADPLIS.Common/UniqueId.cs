using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common
{
    public static class UniqueId
    {
        private static readonly Random s_Rand = new Random();
        private static readonly DateTime s_Start = new DateTime(2001, 1, 1, 0, 0, 0);

        /// <summary>
        /// Create a 64-bit unique ID
        /// </summary>
        /// <returns></returns>
        public static string Generate()
        {
            long ret;
            lock (s_Rand)
            {
                long secondMask = 0x1FFFFFFFF;
                long randNum1 = s_Rand.Next(32767);
                long randNum2 = s_Rand.Next(32767);
                ret = (((long)DateTime.Now.Subtract(s_Start).TotalSeconds & secondMask) << 30)
                  | (randNum1 << 15)
                  | randNum2
                  ;
            }
            return ret.ToString();
        }
    }
}
