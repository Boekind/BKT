using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    [Serializable]
    public class Address
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }


        public Address()
        {

        }
        public Address(string country, string state, string zip, string city, string street, string houseNumber)
        {
            Country = country;
            State = state;
            Zip = zip;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return RealEstateManagement.GetData(this);

        }
    }
}
