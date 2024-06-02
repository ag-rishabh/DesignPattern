using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public class User
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string Email { get; init; }

        public string PhoneNumber { get; init; }

        public Address Address { get; init; }

        public User(int id, string name, string email, string phoneNumber, Address address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
