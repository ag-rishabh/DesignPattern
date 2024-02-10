using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SingletonWithThreadSafe
    {
        private static SingletonWithThreadSafe instance = null;

        private SingletonWithThreadSafe() { }

        private static readonly object InstanceLock = new object();

        public static SingletonWithThreadSafe GetInstance()
        {
            if(instance == null)
            {
                lock(InstanceLock)
                {
                    if(instance == null)
                    {
                        instance = new SingletonWithThreadSafe();
                    }
                }
            }
            return instance;
        }
    }
}
