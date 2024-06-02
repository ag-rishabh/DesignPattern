namespace FoodDeliveryApp.Data
{
    public class Address
    {
        public string AddressLine1 { get; init; }

        public string AddressLine2 { get; init; }

        public string AddressLine3 { get; init; }

        public string City { get; init; }

        public string state { get; init; }

        public string Zip { get; init; }

        public string Country { get; init; }

        public Address(string addressLine1, string addressLine2, string addressLine3, string city, string state, string zip, string country)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            this.state = state;
            Zip = zip;
            Country = country;
        }
    }
}