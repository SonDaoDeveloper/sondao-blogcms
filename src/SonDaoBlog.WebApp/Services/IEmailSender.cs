using SonDaoBlog.WebApp.Models;

namespace SonDaoBlog.WebApp.Services
{
    public interface IEmailSender
    {
        Task SendEmail(EmailData emailData);
    }
}
