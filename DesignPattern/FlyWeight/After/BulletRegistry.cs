using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FlyWeight.After
{
    public class BulletRegistry
    {
        private readonly Dictionary<ButtelType, Bullet> _bulletRegistory = new Dictionary<ButtelType, Bullet>();

        private BulletRegistry() { }

        private static Lazy<BulletRegistry> _instance = new Lazy<BulletRegistry>(() => new BulletRegistry());

        public static BulletRegistry GetInstance() => _instance.Value;

        public Bullet GetBullet(ButtelType bulletType)
        {
            return _bulletRegistory[bulletType];
        }

        public void Add(ButtelType type, Bullet bullet)
        {
            _bulletRegistory.Add(type, bullet);
        }
    }
}
