using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishResident.Services
{
    public interface IMailSenderService
    {
        bool MailSend(string reciever, string subject, string message, string attachmentLink);

        bool SendFoundNewResidence(string reciever, string requestId);
    }
}
