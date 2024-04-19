using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class NotificationSender
    {
        List<INotificationClient> clients;

        public NotificationSender()
        {
            clients = new List<INotificationClient>();
        }

        public void AddClient(INotificationClient client)
        {
            clients.Add(client);
        }

        public void RemoveClient(INotificationClient client)
        {
            clients.Remove(client);
        }

        public void Notify(String message)
        {
            foreach (INotificationClient client in clients)
            {
                client.Notify(message);
            }
        }
    }
}
