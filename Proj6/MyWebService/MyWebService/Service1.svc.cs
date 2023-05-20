using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace MyWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]


    public class RestService : IRestService
    {
        private static List<Person> people = new List<Person>(){
            new Person() { id = 0, name = "Adam", age = 22, email = "adam@nowak.com"},
            new Person() { id = 1, name = "Jan", age = 26, email = "kowalski@onet.pl"},
            new Person() { id = 2, name = "Stefan", age = 55, email = "stef2344123@gmail.com"}
        };

        public List<Person> getAllXml(){
            return people;
        }

        public Person getByIdXml(string Id){
            int id = int.Parse(Id);
            int index = people.FindIndex(p => p.id == id);
            if (index == -1){
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            return people.ElementAt(index);
        }

        // Pod laby 23.5
        public List<Person> getByNameXml(string name)
        {
            var persons = people.Where(p => p.name == name).ToList();
            if (persons.Count == 0)
            {
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            return persons;
        }


        public HttpResponseMessage addXml(Person person){
            if (person == null){
                throw new WebFaultException<string>("400: BadRequest", HttpStatusCode.BadRequest);
            }
            int maxId = 0;
            foreach (Person temp in people){
                if (temp.id > maxId){
                    maxId = temp.id;
                }
            }
            person.id = maxId+1;
            people.Add(person);

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Content = new StringContent("Added person: " + person.id + ", " + person.name + ", " + person.age + ", " + person.email);
            return response;
        }

        public string deleteXml(string Id)
        {
            int id = int.Parse(Id);
            int index = people.FindIndex(p => p.id == id);
            if (index == -1){
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            Person person = people.ElementAt(index);
            people.RemoveAt(index);
            return "Removed person: " + person.id + ", " + person.name + ", " + person.age + ", " + person.email;
        }

        public string updateXml(string Id, Person person){
            int id = int.Parse(Id);
            int index = people.FindIndex(p => p.id == id);
            if (index == -1){
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            Person personToEdit = people.ElementAt(index);
            personToEdit.name = person.name;
            personToEdit.age = person.age;
            personToEdit.email = person.email;

            return "Updated person: " + person.id + ", " + person.name + ", " + person.age + ", " + person.email;
        }

        public int getCountXml()
        {
            return people.Count;
        }

        public List<Person> getAllJson()
        {
            return people;
        }

        public Person getByIdJson(string Id)
        {
            int id = int.Parse(Id);
            int index = people.FindIndex(p => p.id == id);
            if (index == -1)
            {
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            return people.ElementAt(index);
        }

        // pod laby 23.5
        public List<Person> getByNameJson(string name)
        {
            var persons = people.Where(p => p.name == name).ToList();
            if (persons.Count == 0)
            {
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            return persons;
        }


        public string addJson(Person person)
        {
            if (person == null)
            {
                throw new WebFaultException<string>("400: BadRequest", HttpStatusCode.BadRequest);
            }
            int maxId = 0;
            foreach (Person temp in people)
            {
                if (temp.id > maxId)
                {
                    maxId = temp.id;
                }
            }
            person.id = maxId + 1;
            people.Add(person);
            return "Added person: " + person.id + ", " + person.name + ", " + person.age + ", " + person.email;
        }

        public string deleteJson(string Id)
        {
            int id = int.Parse(Id);
            int index = people.FindIndex(p => p.id == id);
            if (index == -1)
            {
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            Person person = people.ElementAt(index);
            people.RemoveAt(index);
            return "Removed person: " + person.id + ", " + person.name + ", " + person.age + ", " + person.email;
        }

        public string updateJson(string Id, Person person)
        {
            int id = int.Parse(Id);
            int index = people.FindIndex(p => p.id == id);
            if (index == -1)
            {
                throw new WebFaultException<string>("404: Not Found", HttpStatusCode.NotFound);
            }
            Person personToEdit = people.ElementAt(index);
            personToEdit.name = person.name;
            personToEdit.age = person.age;
            personToEdit.email = person.email;

            return "Updated person: " + person.id + ", " + person.name + ", " + person.age + ", " + person.email;
        }

        public int getCountJson()
        {
            return people.Count;
        }

    }
}
