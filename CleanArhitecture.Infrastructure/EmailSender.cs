using CleanArhitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CleanArhitecture.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string to, string from, string subject, string body)
        {
            var emailClient = new SmtpClient("localhost");
            var message = new MailMessage
            {

                From = new MailAddress(from),
                Subject = subject,
                Body = body


            };
            message.To.Add(new MailAddress(to));
            await emailClient.SendMailAsync(message);
        }
    }
}
