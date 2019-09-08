using RWAWebForms.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWAWebForms.Models
{
    public interface IRepository
    {
        void AddPerson(Person person);
        void AddEmail(Email email);
        List<Person> GetPersons();
        void DeletePerson(int idPerson);
        void EditPerson(Person person);
        void EditEmail(string old, string newEmail);

        List<City> GetCities();
        List<Status> GetStatuses();
        List<Email> GetEmailsPerPerson(int idPerson);
        Email CheckIfEmailExists(string email);
        Person GetLoginData(int idPerson, string password);
        Person GetPerson(int idPerson);

        City GetCity(int idCity);
        Status GetStatus(int idStatus);

        Person GetPerson(Person person);

    }
}
