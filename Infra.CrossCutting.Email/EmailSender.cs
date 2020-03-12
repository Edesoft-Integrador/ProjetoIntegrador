using Microsoft.Extensions.Options;
using MimeKit;
using System;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using MailKit.Security;

namespace seq.Infra.CrossCutting.Email
{
    public class EmailSender : IEmailSender
    {
        public EmailSettings _emailSettings { get; }

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                Execute(email, subject, message).Wait();
                return Task.FromResult(0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                string toEmail = string.IsNullOrEmpty(email) ? _emailSettings.ToEmail : email;
                MimeMessage mail = new MimeMessage();

                mail.From.Add(new MailboxAddress("Sequoia - Barra Funda", _emailSettings.UsernameEmail));

                mail.To.Add(new MailboxAddress(toEmail));
                mail.Cc.Add(new MailboxAddress(_emailSettings.CcEmail));
                mail.Subject = subject;
                mail.Body = new TextPart("plain")

                {
                    Text = message,
                };
                mail.Priority = MessagePriority.Urgent;

                using (SmtpClient smtp = new SmtpClient())
                {
                    await smtp.ConnectAsync(_emailSettings.PrimaryDomain, _emailSettings.PrimaryPort, SecureSocketOptions.Auto);
                    smtp.CheckCertificateRevocation = true;
                    smtp.SslProtocols = System.Security.Authentication.SslProtocols.Tls;
                    await smtp.AuthenticateAsync(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);

                    smtp.Send(mail);

                    smtp.Disconnect(true);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
