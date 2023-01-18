using MailSetup.Models;

namespace MailSetup.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);   
    }
}
