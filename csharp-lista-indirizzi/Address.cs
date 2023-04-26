using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace address
{
    public class Address
    {
        private readonly string name;
        private readonly string surname;
        private readonly string street;
        private readonly string city;
        private readonly string province;
        private readonly int zip;

        public Address(string name, string surname, string street, string city, string province, int zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string Name
        {
            get { return name; }
        }

        public string Surname
        {
            get { return surname; }
        }

        public string Street
        {
            get { return street; }
        }

        public string City
        {
            get { return city; }
        }

        public string Province
        {
            get { return province; }
        }

        public int Zip
        {
            get { return zip; }
        }


        public override string ToString()
        {
            string addressInfo =
            $"----------------------------------------\n" +
            $"Name: {this.Name} \n" +
            $"Surname: {this.Surname} \n" +
            $"Street: {this.Street} \n" +
            $"City: {this.City} \n" +
            $"Province: {this.Province} \n" +
            $"Zip: {this.Zip} \n" +
            $"----------------------------------------";
            
            return addressInfo;
        }
    }
}