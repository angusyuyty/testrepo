using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.Email
{
    public class EmailSender
    {
        private readonly IEmailSender PlisEmailSender;


        public EmailSender(IEmailSender emailSender)
        {
            PlisEmailSender = emailSender;
            // WetrialEmailSender = new MailKitSender();
        }
        /// <summary>
        /// Sends an email
        /// </summary>
        /// <param name="subject">Subject</param>
        /// <param name="body">Body</param>
        /// <param name="fromAddress">From address</param>
        /// <param name="fromName">From display name</param>
        /// <param name="toAddress">To address</param>
        /// <param name="toName">To display name</param>
        /// <param name="bcc">BCC addresses list</param>
        /// <param name="cc">CC addresses ist</param>
        public void SendEmail(string subject, string body,
            string fromAddress, string fromName, string toAddress, string toName,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attachs = null)
        {
            PlisEmailSender.SendEmail(subject, body, toAddress, bcc, cc, attachs);
        }

        /// <summary>
        /// Sends an email
        /// </summary>
        /// <param name="subject">Subject</param>
        /// <param name="body">Body</param>
        /// <param name="from">From address</param>
        /// <param name="to">To address</param>
        /// <param name="bcc">BCC addresses list</param>
        /// <param name="cc">CC addresses ist</param>
        public void SendEmail(string subject, string body,
            MailAddress from, MailAddressCollection to,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attachs = null)
        {
            PlisEmailSender.SendEmail(subject, body, from, to, bcc, cc, attachs);
        }

        public void SendEmail(string subject, string body, MailAddress from, MailAddress to, string host,
            int port, string password, bool enableSsl,
            IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attachs = null)
        {
            PlisEmailSender.SendEmail(subject, body, from, to, host, port, password, enableSsl, bcc, cc, attachs);
        }
    }
}
