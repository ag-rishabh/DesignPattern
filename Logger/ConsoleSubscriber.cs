using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ConsoleSubscriber : ISubscriber
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
