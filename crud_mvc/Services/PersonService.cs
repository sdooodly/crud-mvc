using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_mvc.Models;

namespace crud_mvc.Services
{
    public class PersonService
    {
        private static List<Person> _people = new List<Person>();
        private static int _nextId = 1;
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
