using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SingletonWithNothreadSafe
    {
        private static SingletonWithNothreadSafe instance = null;

        private SingletonWithNothreadSafe() { } 

        public static SingletonWithNothreadSafe getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonWithNothreadSafe();
            }
            return instance;
        }
    }
}
