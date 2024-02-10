using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SingletonWithEagerLoading
    {
        private static SingletonWithEagerLoading instance = new SingletonWithEagerLoading();

        private SingletonWithEagerLoading() { }

        public static SingletonWithEagerLoading Instance => instance;
    }
}
