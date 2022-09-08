using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
namespace CADPLIS.Common.Email
{
    public class MailKitSender : IEmailSender
    {
        private const string KitCharset = "GB18030";
        private EmailAccount emailAccount;

        public MailKitSender(IOptions<EmailAccount> options)
        {
            emailAccount = options.Value;
        }

        /// <summary>
        /// Send E-mail
        /// </summary>
        public void SendEmail(string subject, string body, string toAddress, IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attaches = null)
        {
            var toAddrs = toAddress.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var toMailAddrs = new MailAddressCollection();
            for (int i = 0; i < toAddrs.Length; i++)
            {
                toMailAddrs.Add(new MailAddress(toAddrs[i]));
            }

            SendEmail(subject, body,
                new MailAddress(emailAccount.UserName, emailAccount.DisplayName), toMailAddrs,
                bcc, cc, attaches);
        }

        /// <summary>
        /// Send E-mail
        /// </summary>
        public void SendEmail(string subject, string body, MailAddress from, MailAddressCollection to, IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attaches = null)
        {
            #region Creat Email Message
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(from.DisplayName, from.Address));
            foreach (var toitem in to)
            {
                message.To.Add(new MailboxAddress(toitem.DisplayName, toitem.Address));
            }
            message.Subject = subject;
            if (null != bcc)
            {
                foreach (var address in bcc.Where(bccValue => !String.IsNullOrWhiteSpace(bccValue)))
                {
                    message.Bcc.Add(MailboxAddress.Parse(address.Trim()));
                }
            }
            if (null != cc)
            {
                foreach (var address in cc.Where(ccValue => !String.IsNullOrWhiteSpace(ccValue)))
                {
                    message.Cc.Add(MailboxAddress.Parse(address.Trim()));
                }
            }
            #endregion

            #region Email message
            var multipart = new Multipart("mixed");
            multipart.Add(new TextPart(TextFormat.Html)
            {
                Text = body
            });
            //attaches
            if (attaches != null && attaches.Count > 0)
            {
                for (int i = 0; i < attaches.Count; i++)
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(attaches[i].stream),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64
                    };
                    var fileName = attaches[i].FileName;
                    attachment.ContentType.Parameters.Add(KitCharset, "name", fileName);
                    attachment.ContentDisposition.Parameters.Add(KitCharset, "filename", fileName);
                    foreach (var param in attachment.ContentDisposition.Parameters)
                        param.EncodingMethod = ParameterEncodingMethod.Rfc2047;
                    foreach (var param in attachment.ContentType.Parameters)
                        param.EncodingMethod = ParameterEncodingMethod.Rfc2047;
                    multipart.Add(attachment);
                }
            }
            message.Body = multipart;
            #endregion

            #region Send Email
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect(emailAccount.Host, emailAccount.Port, emailAccount.EnableSsl);
                if (!string.IsNullOrEmpty(emailAccount.UserName))
                {
                    client.Authenticate(emailAccount.UserName, emailAccount.Password);
                }
                client.Send(message);
                client.Disconnect(true);
            }
            #endregion
        }

        /// <summary>
        /// Send E-mail
        /// </summary>
        public void SendEmail(string subject, string body, MailAddress from, MailAddress to, string host, int port, string password, bool enableSSL, IEnumerable<string> bcc = null, IEnumerable<string> cc = null, List<EmailAttachment> attaches = null)
        {
            #region Creat Email Message
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(from.DisplayName, from.Address));
            message.To.Add(new MailboxAddress(to.DisplayName, to.Address));
            message.Subject = subject;
            if (null != bcc)
            {
                foreach (var address in bcc.Where(bccValue => !String.IsNullOrWhiteSpace(bccValue)))
                {
                    message.Bcc.Add(MailboxAddress.Parse(address.Trim()));
                }
            }
            if (null != cc)
            {
                foreach (var address in cc.Where(ccValue => !String.IsNullOrWhiteSpace(ccValue)))
                {
                    message.Cc.Add(MailboxAddress.Parse(address.Trim()));
                }
            }
            #endregion

            #region Email message
            var multipart = new Multipart("mixed");
            multipart.Add(new TextPart(TextFormat.Html)
            {
                Text = body
            });
            //attaches
            if (attaches != null && attaches.Count > 0)
            {
                for (int i = 0; i < attaches.Count; i++)
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(attaches[i].stream),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    };
                    var fileName = attaches[i].FileName;
                    attachment.ContentType.Parameters.Add(KitCharset, "name", fileName);
                    attachment.ContentDisposition.Parameters.Add(KitCharset, "filename", fileName);
                    foreach (var param in attachment.ContentDisposition.Parameters)
                        param.EncodingMethod = ParameterEncodingMethod.Rfc2047;
                    foreach (var param in attachment.ContentType.Parameters)
                        param.EncodingMethod = ParameterEncodingMethod.Rfc2047;
                    multipart.Add(attachment);
                }
            }
            message.Body = multipart;
            #endregion

            #region Send Email
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect(host, port, enableSSL);
                if (!string.IsNullOrEmpty(from.Address))
                {
                    client.Authenticate(from.Address, password);
                }
                client.Send(message);
                client.Disconnect(true);
            }
            #endregion
        }
    }
}
