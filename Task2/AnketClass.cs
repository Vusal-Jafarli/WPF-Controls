using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AnketObject
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Middle_Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }

        public AnketObject()
        {

        }

        public AnketObject(string name, string surname, string? middle_name, string country, string city, string number, string birthday, string gender)
        {
            Name = name;
            Surname = surname;
            Middle_Name = middle_name;
            Country = country;
            City = city;
            Number = number;
            Birthday = birthday;
            Gender = gender;
        }
    }
}

