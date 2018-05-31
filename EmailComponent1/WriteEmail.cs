using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailComponent1
{
    public class WriteEmail
    {
        public string Subject { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string MessageBody { get; set; }
        public string SmtpServer { get; set; }
        public NetworkCredential SmtpCredentials { get; set; }

        /// <summary>
        /// Sets all items of the mailmessage
        /// </summary>
        /// <param name="toEmail">Email Address email of recipient</param>
        /// <param name="toName">Name of recipient that will appear on the email</param>
        /// <returns></returns>
        public bool SendMail(string toEmail,string toName)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(new MailAddress(toEmail, toName));
                message.Subject = this.Subject;
                message.IsBodyHtml = true;
                message.Body = this.MessageBody;
                message.From = new MailAddress(this.FromEmail, this.FromName);//Sending Email address
                SmtpClient client = new SmtpClient(SmtpServer)
                {
                    Credentials = SmtpCredentials,//username + password for sending account
                    EnableSsl = true
                };
                client.Send(message);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
