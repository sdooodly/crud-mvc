using System.Collections.Generic;
using crud_mvc.Models;
using System.Linq;

namespace crud_mvc.Services
{
    public class PersonService
    {
        private static List<Person> _people = new List<Person>()
        {
            new Person { Id = 1, Name = "gaya", Email = "gayaa@example.com", PhoneNumber = "123-456-7890" },
            new Person { Id = 2, Name = "che", Email = "gu@example.com", PhoneNumber = "987-654-3210" }
        };
        private static int _nextId = 3;

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Person person)
        {
            person.Id = _nextId++;
            _people.Add(person);
        }

        public void Update(Person person)
        {
            var existingPerson = _people.FirstOrDefault(p => p.Id == person.Id);
            if (existingPerson != null)
            {
                existingPerson.Name = person.Name;
                existingPerson.Email = person.Email;
                existingPerson.PhoneNumber = person.PhoneNumber;
            }
        }

        public void Delete(int id)
        {
            _people.RemoveAll(p => p.Id == id);
        }
    }
}