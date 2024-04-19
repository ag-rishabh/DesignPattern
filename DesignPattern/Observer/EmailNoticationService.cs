using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class EmailNoticationService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("Sending Email with " + email);
        }
    }
}
