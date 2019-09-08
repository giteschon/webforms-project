using RWAWebForms.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWAWebForms.Models
{
    public class Person
    {
        public int IDPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public City City { get; set; }
        public Status Status { get; set; }
        public string Password { get; set; }

        public Person(int idPerson, string name, string surname, City city, string password, Status status)
        {
            IDPerson = idPerson;
            Name = name;
            Surname = surname;
            City = city;
            Password = password;
            Status = status;
        }

        public Person()
        {

        }

        public Person(string name, string surname, City city, Status status, string password)
        {
            Name = name;
            Surname = surname;
            City = city;
            Status = status;
            Password = password;
        }


      

    }
}