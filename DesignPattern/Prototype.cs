using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class User
    {
       public int Id {  get; private set; }

        public string Name { get; private set; } = string.Empty;

        public string Email { get; private set; } = string.Empty;

        public string Password { get; private set; } = string.Empty;

        public User(int id, string name, string email, string password) 
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public User GetClone() //shallow copy
        {
            // using copy constructor
            //return new User(this.Id, this.name, this.email, this.password);
            return (User) this.MemberwiseClone();
        }



    }
}
