using Microsoft.ApplicationBlocks.Data;
using RWAWebForms.Models.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace RWAWebForms.Models
{
    public class RepoDatabase : IRepository
    {
        //spajanje na connection string
        private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private static DataSet ds;

        public void AddEmail(Email email)
        {
            SqlHelper.ExecuteNonQuery(cs, "AddEmail", email.Person.IDPerson, email.EmailValue);
        }

        public void AddPerson(Person person)
        {
            SqlHelper.ExecuteNonQuery(cs, "AddPerson", person.Name, person.Surname, person.Telephone, person.City.IDCity, person.Status.IDStatus, person.Password);
        }

        public Email CheckIfEmailExists(string email)
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(cs, nameof(this.CheckIfEmailExists), email);
                DataRow row = ds.Tables[0].Rows[0];

                Email e = new Email();
                e.IDEmail = (int)row[nameof(Email.IDEmail)];
                e.EmailValue = email;
                e.Person = GetPerson((int)row["PersonID"]);

                return e;
            }
            catch (Exception)
            {
                return null;

            }


        }

        public void DeletePerson(int idPerson)
        {
            SqlHelper.ExecuteNonQuery(cs, "DeletePerson", idPerson);
        }

        public void EditEmail(string old, string newEmail)
        {
            SqlHelper.ExecuteNonQuery(cs, "EditEmail", old, newEmail);
        }

        public void EditPerson(Person person)
        {
            SqlHelper.ExecuteNonQuery(cs, "EditPerson", person.IDPerson, person.Name, person.Surname, person.Telephone, person.City.IDCity, person.Status.IDStatus, person.Password);
        }

        public List<City> GetCities()
        {
            List<City> list = new List<City>();

            ds = SqlHelper.ExecuteDataset(cs, "GetCities");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new City
                {
                    IDCity = (int)row[nameof(City.IDCity)],
                    Name = row[nameof(City.Name)].ToString()
                });
            }
            return list;
        }

        public City GetCity(int idCity)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetCity", idCity);
            DataRow row = ds.Tables[0].Rows[0];

            City c = new City();
            c.IDCity = idCity;
            c.Name = row[nameof(City.Name)].ToString();

            return c;
        }

        public List<Email> GetEmailsPerPerson(int idPerson)
        {
            List<Email> list = new List<Email>();

            ds = SqlHelper.ExecuteDataset(cs, "GetEmailsPerPerson", idPerson);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new Email
                {
                    IDEmail = (int)row[nameof(Email.IDEmail)],
                    EmailValue = row["Email"].ToString(),
                    Person = GetPerson((int)row["PersonID"])
                });
            }
            return list;
        }

        public Person GetLoginData(int idPerson, string password)
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(cs, nameof(this.GetLoginData), idPerson, password);
                DataRow row = ds.Tables[0].Rows[0];

                Person p = new Person();
                p.IDPerson = idPerson;
                p.Name = row[nameof(Person.Name)].ToString();
                p.Surname = row[nameof(Person.Surname)].ToString();
                p.Telephone = row[nameof(Person.Telephone)].ToString();
                p.Password = row[nameof(Person.Password)].ToString();
                p.City = GetCity((int)row["CityID"]);
                p.City = GetCity((int)row["StatusID"]);

                return p;
            }
            catch (Exception)
            {
                return null;

            }
        }

        public Person GetPerson(int idPerson)
        {
            ds = SqlHelper.ExecuteDataset(cs, nameof(this.GetPerson), idPerson);
            DataRow row = ds.Tables[0].Rows[0];

            Person p = new Person();
            p.IDPerson = idPerson;
            p.Name = row[nameof(Person.Name)].ToString();
            p.Surname = row[nameof(Person.Surname)].ToString();
            p.Telephone = row[nameof(Person.Telephone)].ToString();
            p.Password = row[nameof(Person.Password)].ToString();
            p.City = GetCity((int)row["CityID"]);
            p.City = GetCity((int)row["StatusID"]);

            return p;
        }

        public List<Person> GetPersons()
        {
            List<Person> list = new List<Person>();

            ds = SqlHelper.ExecuteDataset(cs, "GetPersons");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new Person
                {
                    IDPerson = (int)row[nameof(Person.IDPerson)],
                    Name = row[nameof(Person.Name)].ToString(),
                    Surname = row[nameof(Person.Surname)].ToString(),
                    Telephone = row[nameof(Person.Telephone)].ToString(),
                    Status = GetStatus((int)row["StatusID"]),
                    City = GetCity((int)row["CityID"]),
                    Password = row[nameof(Person.Password)].ToString(),
                });
            }
            return list;
        }

        public Status GetStatus(int idStatus)
        {
            ds = SqlHelper.ExecuteDataset(cs, nameof(this.GetStatus), idStatus);
            DataRow row = ds.Tables[0].Rows[0];

            Status s = new Status();

            s.IDStatus = idStatus;
            s.Name = row[nameof(Status.IDStatus)].ToString();

            return s;
        }

        public List<Status> GetStatuses()
        {
            List<Status> list = new List<Status>();

            ds = SqlHelper.ExecuteDataset(cs, "GetStatuses");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new Status
                {
                    IDStatus = (int)row[nameof(Status.IDStatus)],
                    Name = row[nameof(Status.Name)].ToString()
                });
            }
            return list;
        }

        public Person GetPerson(Person person)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetPersonAfterInsert", person.Name, person.Surname, person.Password);
            DataRow row = ds.Tables[0].Rows[0];

            Person p = new Person();
            p.IDPerson = (int)row[nameof(Person.IDPerson)];
            p.Name = row[nameof(Person.Name)].ToString();
            p.Surname = row[nameof(Person.Surname)].ToString();
            p.Telephone = row[nameof(Person.Telephone)].ToString();
            p.Password = row[nameof(Person.Password)].ToString();
            p.City = GetCity((int)row["CityID"]);
            p.City = GetCity((int)row["StatusID"]);

            return p;
        }


    }
}