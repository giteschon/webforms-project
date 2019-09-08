using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWAWebForms.Models.Model
{
    public class Email
    {
        public int IDEmail { get; set; }
        public string EmailValue { get; set; }
        public Person Person { get; set; }

        public Email(int idEmail, string emailValue, Person person)
        {
            IDEmail = idEmail;
            emailValue = EmailValue;
            Person = person;
        }

        public Email()
        {

        }

    }
}