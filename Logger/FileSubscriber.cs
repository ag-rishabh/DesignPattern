using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileSubscriber : ISubscriber
    {
        private readonly string fileNmae;
        public FileSubscriber(string fileNmae)
        {
            this.fileNmae = fileNmae;
        }

        public void Update(string message)
        {
            using(StreamWriter streamWriter = new StreamWriter(fileNmae))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
