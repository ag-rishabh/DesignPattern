using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SingletonWithLazyLoading
    {
        private static readonly Lazy<SingletonWithLazyLoading> SingleInstance = new Lazy<SingletonWithLazyLoading>(() => new SingletonWithLazyLoading());

        private SingletonWithLazyLoading() { }

        public static SingletonWithLazyLoading Instance => SingleInstance.Value;
    }
}
