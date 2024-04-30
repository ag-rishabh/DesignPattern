using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Users
{
    public abstract class User
    {
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; private set; }

        public int Id { get; private set; }

    }
}
