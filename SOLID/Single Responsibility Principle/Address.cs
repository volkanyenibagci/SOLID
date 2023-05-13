using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class Address
    {
        private String street;
        private String city;
        private String zip;

        public Address(string street, string city, string zip)
        {
            this.street = street;
            this.city = city;
            this.zip = zip;
        }
    }
}
