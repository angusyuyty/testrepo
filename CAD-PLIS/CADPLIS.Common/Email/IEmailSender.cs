using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.Email
{
    /// <summary>
    /// Email Push interface
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Send E-mail
        /// </summary>
        /// <param name="subject">Title</param>
        /// <param name="body">Content</param>
        /// <param name="fromAddress">Sender address</param>
        /// <param name="fromName">Sender name</param>
        /// <param name="toAddress">Delivery address (separated by ',')</param>
        /// <param name="toName">Name of recipient (separated by ',')</param>
        /// <param name="bcc">BCC's get together</param>
        /// <param name="cc">Cc's round up</param>
        /// <param name="attaches">The attachment</param>
        void SendEmail(
            string subject, string body,
            string toAddress,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null,
            List<EmailAttachment> attaches = null);

        /// <summary>
        /// Send E-mail
        /// </summary>
        /// <param name="subject">Title</param>
        /// <param name="body">Content</param>
        /// <param name="from">Specifies the email address of the sender</param>
        /// <param name="to">Collection of recipient email addresses</param>
        /// <param name="bcc">BCC's get together</param>
        /// <param name="cc">Cc's round up</param>
        /// <param name="attaches">The attachment</param>
        void SendEmail(
            string subject, string body,
            MailAddress from, MailAddressCollection to,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attaches = null
            );

        /// <summary>
        /// Send E-mail
        /// </summary>
        /// <param name="subject">Title</param>
        /// <param name="body">Content</param>
        /// <param name="from">Specifies the email address of the sender</param>
        /// <param name="to">Collection of recipient email addresses</param>
        /// <param name="host">Address of the mail agent</param>
        /// <param name="port">Mail agent sending port</param>
        /// <param name="password">Password of the account for sending the email agent</param>
        /// <param name="enableSSL">Whether to enable SSL sending</param>
        /// <param name="bcc">BCC's get together</param>
        /// <param name="cc">Cc's round up</param>
        /// <param name="attaches">The attachment</param>
        void SendEmail(
            string subject, string body,
            MailAddress from, MailAddress to, string host,
            int port, string password, bool enableSSL,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attaches = null
            );
    }
}
