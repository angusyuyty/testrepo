using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.File
{
    public class FileServerConnection
    {
        private string uncName;
        private string username;
        private string password;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uncName">UNCpath</param>
        /// <param name="username">unc username</param>
        /// <param name="password">unc password</param>
        public FileServerConnection(string uncName, string username, string password)
        {
            this.uncName = uncName;
            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// connect file server
        /// </summary>
        public void Connect()
        {
            var netResource = new NetResource
            {
                Scope = ResourceScope.GlobalNetwork,
                ResourceType = ResourceType.Disk,
                DisplayType = ResourceDisplayType.Share,
                RemoteName = this.uncName.TrimEnd('\\')

            };
            var result = WNetAddConnection2(netResource, password, username, 1);
            if (result != 0)
                throw new Win32Exception(result);
        }

        /// <summary>
        /// dispose connect
        /// </summary>
        public void Disconnect()
        {
            WNetCancelConnection2(this.uncName, 1, false);
        }
        //flags:0, temporary link; 1, create permanent link
        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource,
                                                        string password,
                                                        string username,
                                                        int flags);
        ///flags is zero or CONNECT_UPDATE_PROFILE. If it is zero, and a permanent connection is established, the connection will still be reconnected the next time Windows is restarted
        /// If force is true, it means disconnection (even if there is an open file or job on the connected resource)
        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags, bool force);
    }
}
