using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using RWAWebForms.Models.Model;

namespace RWAWebForms.Models.BL
{
    public class PersonBusiness : IManager
    {
        //business layer logic
        private IRepository repo;

        public PersonBusiness(IRepository repository)
        {
            this.repo = repository;
            Statics.manager = this;
            //  CreateRoles();
        }

        private void CreateRoles()
        {
            foreach (var r in GetStatuses())
            {
                Roles.CreateRole(r.Name);
            }

        }

        public void AddEmail(Email email)
        {
            repo.AddEmail(email);
        }

        public void AddPerson(Person person)
        {
            repo.AddPerson(person);
        }

        public Email CheckIfEmailExists(string email)
        {
            return repo.CheckIfEmailExists(email);
        }

        public void DeletePerson(int idPerson)
        {
            repo.DeletePerson(idPerson);
        }

        public void EditEmail(string old, string newEmail)
        {
            repo.EditEmail(old, newEmail);
        }

        public void EditPerson(Person person)
        {
            repo.EditPerson(person);
        }

        public List<City> GetCities()
        {
            return repo.GetCities();
        }

        public City GetCity(int idCity)
        {
            return repo.GetCity(idCity);
        }

        public List<Email> GetEmailsPerPerson(int idPerson)
        {
            return repo.GetEmailsPerPerson(idPerson);
        }

        public Person GetLoginData(int idPerson, string password)
        {
            return repo.GetLoginData(idPerson, password);
        }

        public Person GetPerson(int idPerson)
        {
            return repo.GetPerson(idPerson);
        }

        public Person GetPerson(Person person)
        {
            return repo.GetPerson(person);
        }

        public List<Person> GetPersons()
        {
            return repo.GetPersons();
        }

        public Status GetStatus(int idStatus)
        {
            return repo.GetStatus(idStatus);
        }

        public List<Status> GetStatuses()
        {
            return repo.GetStatuses();
        }

        public void LoadCities(DropDownList ddlCity)
        {
            foreach (City city in repo.GetCities())
            {
                ddlCity.Items.Add(new ListItem(city.Name, city.IDCity.ToString()));
            }

        }

        public void LoadStatus(DropDownList ddlStatus)
        {
            foreach (Status status in repo.GetStatuses())
            {
                ddlStatus.Items.Add(new ListItem(status.Name, status.IDStatus.ToString()));
            }
        }

        public void LoadEmailsPerPerson(DropDownList ddlEmail, int idPerson)
        {

            foreach (Email email in repo.GetEmailsPerPerson(idPerson))
            {
                ddlEmail.Items.Add(new ListItem(email.EmailValue, email.IDEmail.ToString()));
            }
        }

        private DataTable CreateDataTable() {
            DataTable dt = new DataTable();

            //for (int i = 0; i < GetPersons().Count; i++)
            //{
            //    dt.Rows.Add(GetPersons().ToArray())
            //}

            return dt;
        }

    }
}