using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Intro_WebAPI.Models;


namespace Intro_WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        List<Person> Persons = new List<Person>();
       
        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            for (int i = 0; i < 10; i++) {
                var p = new Person()
                {
                    Id = i + 1,
                    Name = "Person " + (i + 1),
                    Dob = "Dob " + (i + 1)
                };
                Persons.Add(p);
            }
            return Persons;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            for (int i = 0; i < 10; i++)
            {
                var p = new Person()
                {
                    Id = i + 1,
                    Name = "Person " + (i + 1),
                    Dob = "Dob " + (i + 1)
                };
                Persons.Add(p);
            }
            var pr = Persons.FirstOrDefault(e => e.Id == id);
            return pr;
        }

        // POST: api/Person
        public void Post(Person value)
        {
            Persons.Add(value);
        }

        // PUT: api/Person/5
        public void Put(int id, Person value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
