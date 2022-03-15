using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Customer
    {
        List<Address> addresses = new List<Address>();
        public Customer()
        {
            addresses.Add(new Address(5051, "AP", "India"));
            addresses.Add(new Address(5052, "UP", "India"));
            addresses.Add(new Address(5053, "MP", "India"));
        }
        public Address GetAddress(int pincode)
        {
            foreach (var address in addresses)
            {
                if (address._pincode == pincode)
                    return address;
            }
            return null;
        }
        public Address GetAddress(string state)
        {
            foreach (var address in addresses)
            {
                if (address._state == state)
                    return address;
            }
            return null;
        }
        public Address this[int pincode]
        {
            get
            {
                foreach (var address in addresses)
                {
                    if (address._pincode == pincode)
                        return address;
                }
                return null;

            }
        }
        public Address this[string state]
        {
            get
            {
                foreach (var address in addresses)
                {
                    if (address._state == state)
                        return address;
                }
                return null;
            }
        }
    }

public class Address
    {
        public int _pincode;
        public string _state;
        public string _country;
        public Address(int pincode, string state, string country)
        {
            _pincode = pincode;
            _state = state;
            _country = country;
        }

    }
}
