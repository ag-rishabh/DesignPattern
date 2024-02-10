using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DesignPattern
{
    public interface IUser
    {
        string Name { get; }
        string Email { get; }
        string Password { get; }
        string Address { get; }
    }

    public class Employee : IUser
    {
        private string _email = String.Empty;
        private string _password = String.Empty;
        private string _address = String.Empty;
        private string _name = String.Empty;

        public string Name { get { return _name; } }

        public string Email { get { return _email; } }

        public string Password {  get { return _password; } }

        public string Address {  get { return _address; } }

        private Employee() { }

        public class Employeebuilder
        {
            private readonly Employee _employee;

            public Employeebuilder() 
            {
                _employee = new Employee();
            }

            public Employeebuilder SetName(string name)
            {
               _employee._name = name;
                return this;
            }

            public Employeebuilder SetEmail(string email)
            { 
                _employee._email = email;
                return this;
            }

            public Employeebuilder SetPassword(string password)
            {
                 _employee._password = password;
                return this;
            }

            public Employeebuilder SetAddress(string address)
            {
                _employee._address = address;
                return this;
            }

            public Employee Build()
            {
                return _employee;
            }
        }
    }
}
