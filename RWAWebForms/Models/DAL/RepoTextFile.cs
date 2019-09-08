using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using RWAWebForms.Models.Model;

namespace RWAWebForms.Models
{
    public class RepoTextFile : IRepository
    {

        private const string FILE_PATH = @"C:\Users\Ivy\Documents\Algebra\4. semestar\rwa\_PROJEKT\RWAWebForms_IvanaKasalo\RWAWebForms\txt file";
        private const string NAME = @"\RWAProjekt.txt";
        private const string FILENAME = FILE_PATH + NAME;
        private const char DELIMITER = ',';

        private List<Person> people = new List<Person>();
        private List<Email> emails = new List<Email>();

        public RepoTextFile()
        {
            Read();
        }
        #region Email

        public void AddEmail(Email email)
        {
            email.IDEmail = emails.Last().IDEmail + 1;
            email.Person.IDPerson = people.Last().IDPerson;
            emails.Add(email);

            Save();
        }

        public Email CheckIfEmailExists(string email)
        {
            return emails.Find(e => e.EmailValue.Contains(email));
        }

        public void EditEmail(string old, string newEmail)
        {
            int index = emails.FindIndex(e => e.EmailValue.Contains(old));

            if (index !=-1)
            {
            emails[index].EmailValue = newEmail;

            Save();

            }
        }

        public List<Email> GetEmailsPerPerson(int idPerson)
        {
            IEnumerable<Email> result = emails.Where(e => e.Person.IDPerson == idPerson);

            return result.ToList();
        }

        #endregion

        #region Person

        public void AddPerson(Person person)
        {
            person.IDPerson = people.Last().IDPerson + 1;
            people.Add(person);

        }


        public void DeletePerson(int id)
        {


            people.RemoveAt(people.FindIndex(p => p.IDPerson == id));
            Save();


        }

        public List<Person> GetPersons()
        {
            return people;
        }

        public void EditPerson(Person person)
        {
            int index = people.FindIndex(p => p.IDPerson == person.IDPerson);
            if (index != -1)
            {
            people[index] = person;

            }
        }

        public Person GetPerson(Person person)
        {
            return people.First(p => p.Name == person.Name && p.Surname == person.Surname);
        }

        public Person GetPerson(int idPerson)
        {
            return people.First(p => p.IDPerson == idPerson);
        }

        public Person GetLoginData(int idPerson, string password)
        {
            int index=people.FindIndex(p => p.IDPerson == idPerson);
            if (people[index].Password==password)
            {
                return people[index];
            }
            return null;
            
        }

        #endregion

        #region Status

        public List<Status> GetStatuses()
        {
            return AddStatuses();
        }

        public Status GetStatus(int idStatus)
        {
            return AddStatuses().Find(s => s.IDStatus == idStatus);
        }

        private List<Status> AddStatuses()
        {
            List<Status> list = new List<Status>();
            list.Add(new Status(1, "User"));
            list.Add(new Status(2, "Admin"));

            return list;
        }

        #endregion

        #region City

        public City GetCity(int idCity)
        {
            return AddCitiies().Find(c => c.IDCity == idCity);
        }

        public List<City> GetCities()
        {
            return AddCitiies();
        }

        private List<City> AddCitiies()
        {
            List<City> list = new List<City>();

            list.Add(new City(1, "Zagreb"));
            list.Add(new City(2, "Varaždin"));
            list.Add(new City(3, "Split"));
            list.Add(new City(4, "Rijeka"));
            list.Add(new City(5, "Pula"));
            list.Add(new City(6, "Osijek"));
            list.Add(new City(6, "Dubrovnik"));

            return list;

        }

        #endregion

        private void Read()
        {
            try
            {
                using (StreamReader reader = new StreamReader(FILENAME))
                {
                    string temp = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        people.Add(GetPersonFromString(reader.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {
                //   throw;

            }

        }



        private Person GetPersonFromString(string person)
        {

            string[] line = person.Split(DELIMITER);

            Person p = new Person();
            p.IDPerson = int.Parse(line[0]);
            p.Name = line[1];
            p.Surname = line[2];
            p.Telephone = line[9];
            p.Password = line[12];


            for (int i = 3; i < 8; i += 2)
            {
                if (line[i] != "")
                {
                    Email e = new Email();
                    e.IDEmail = int.Parse(line[i]);
                    e.Person = p;
                    e.EmailValue = line[i + 1];

                    emails.Add(e);
                }


            }

            p.City = AddCitiies().Find(c => c.Name.Contains(line[10]));
            p.Status = AddStatuses().Find(s => s.Name.Contains(line[11]));


            return p;

        }


        private void Save()
        {
            try
            {
                using (StreamWriter w = new StreamWriter(FILENAME))
                {
                    w.Write("ID,NAME,SURNAME,ID_EMAIL1,EMAIL1,ID_EMAIL2,EMAIL2,ID_EMAIL3,EMAIL3,TELEPHONE,CITY,STATUS,PASSWORD\n");
                    foreach (Person p in people)
                    {
                        w.Write(p.IDPerson);
                        w.Write(DELIMITER);
                        w.Write(p.Name);
                        w.Write(DELIMITER);
                        w.Write(p.Surname);
                        w.Write(DELIMITER);

                        foreach (var e in GetEmailsPerPerson(p.IDPerson))
                        {
                            w.Write(e.IDEmail);
                            w.Write(DELIMITER);
                            w.Write(e.EmailValue);
                            w.Write(DELIMITER);
                        }
                        if (GetEmailsPerPerson(p.IDPerson).Count == 2)
                        {
                            w.Write(DELIMITER);
                            w.Write(DELIMITER);
                        }
                        if (GetEmailsPerPerson(p.IDPerson).Count == 1)
                        {
                            w.Write(DELIMITER);
                            w.Write(DELIMITER);
                            w.Write(DELIMITER);
                            w.Write(DELIMITER);
                        }
                        w.Write(p.Telephone);
                        w.Write(DELIMITER);
                        w.Write(p.City);
                        w.Write(DELIMITER);
                        w.Write(p.Status);
                        w.Write(DELIMITER);
                        w.Write(p.Password);
                        w.Write("\n");

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }






    }
}


