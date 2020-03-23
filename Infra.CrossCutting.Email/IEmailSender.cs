using System.Threading.Tasks;

namespace seq.Infra.CrossCutting.Email
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
