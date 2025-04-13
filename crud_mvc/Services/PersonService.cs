using System.Collections.Generic;
using System.Linq;
using crud_mvc.Models;
using crud_mvc.Data; 

namespace crud_mvc.Services
{
    public class PersonService
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Person> GetAll()
        {
            return _dbContext.People.ToList();
        }

        public Person GetById(int id)
        {
            return _dbContext.People.Find(id);
        }

        public void Add(Person person)
        {
            _dbContext.People.Add(person);
            _dbContext.SaveChanges(); // Important: This saves the changes to the database
        }

        public void Update(Person person)
        {
            _dbContext.People.Update(person);
            _dbContext.SaveChanges(); 
        }

        public void Delete(int id)
        {
            var personToDelete = _dbContext.People.Find(id);
            if (personToDelete != null)
            {
                _dbContext.People.Remove(personToDelete);
                _dbContext.SaveChanges(); 
            }
        }
    }
}