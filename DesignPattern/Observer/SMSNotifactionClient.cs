using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class SMSNotifactionClient : INotificationClient
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending SMS with message {message}");
        }
    }
}
