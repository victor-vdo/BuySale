using BuySale.Domain.Contracts;
using BuySale.Domain.Utils.ModelTypes;

namespace BuySale.Domain.Services
{
    public class EmailService : IService
    {
        public EmailService(Email email)
        {
            Email = email;
        }
        public Email Email { get; set; }

        public void SendEmail(Email email)
        {
            Email.Body = email.Body;
        }
    }
}
