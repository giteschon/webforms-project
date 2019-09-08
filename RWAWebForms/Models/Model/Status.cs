using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWAWebForms.Models.Model
{
    public class Status
    {
        public int IDStatus { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Status(int idStatus, string name)
        {
            IDStatus = idStatus;
            Name = name;
        }


        public Status()
        {

        }
    }
}