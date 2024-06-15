using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data
{
    public class CardDetails
    {
        public CardDetails(string name, string cardNumber, int pin)
        {
            Name = name;
            CardNumber = cardNumber;
            Pin = pin;
        }

        public string Name { get; init; }
        public string CardNumber { get; init; }    
        public int Pin {  get; init; }

    }
}
