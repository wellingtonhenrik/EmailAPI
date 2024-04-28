using System.Net;
using System.Net.Mail;
using EmailAPI.Domain.Extension;
using EmailAPI.Domain.Interface;
using EmailAPI.Domain.ValueObject;
using Microsoft.Extensions.Options;

namespace EmailAPI.Domain.Service;

public class EmailService : IEmailService
{
    private readonly EmailSetings _emailSetings;

    public EmailService(IOptions<EmailSetings> emailService)
    {
        _emailSetings = emailService.Value;
    }

    public void SendMail(EmailVO vo)
    {
        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress(_emailSetings.From);
        mailMessage.To.Add(vo.MailTo);
        mailMessage.Subject = vo.Subject;
        mailMessage.Body = vo.Body;

        SmtpClient smtpClient = new SmtpClient();
        smtpClient.Host = _emailSetings.Host;
        smtpClient.Port = _emailSetings.Port;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(_emailSetings.From, _emailSetings.Senha);
        smtpClient.EnableSsl = true;
        smtpClient.Send(mailMessage);
    }
}