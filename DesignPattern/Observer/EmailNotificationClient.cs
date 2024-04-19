using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class EmailNotificationClient : INotificationClient
    {
        private readonly EmailNoticationService _emailNotificationService;

        public EmailNotificationClient(EmailNoticationService emailNoticationService)
        {
            _emailNotificationService = emailNoticationService;
        }

        public void Notify(string message)
        {
            _emailNotificationService.SendEmail(message);
        }
    }
}
