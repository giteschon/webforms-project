using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWAWebForms.Models.Model
{
    public class City
    {
        public int IDCity { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public City(int idCity, string name)
        {
            IDCity = idCity;
            Name = name;
            
        }

        public City()
        {

        }
    }
}