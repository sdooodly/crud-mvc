using System.Collections.Generic;
using System.Linq;
using crud_mvc.Models;
using crud_mvc.Data;


// The service layer sits between the Controller and the Model (data access layer)
// a common architectural pattern used with MVC


namespace crud_mvc.Services 
{
    public class PersonService // this class has the business logic???
        // Business logic makes your application unique and fulfills its specific purpose

        //eg: 
        // Validating user input like ensuring an email address is in the correct format
        // Applying specific calculations(e.g., calculating a discount, determining shipping costs).
        // Enforcing business rules(e.g., a customer cannot place an order if they are over their credit limit).
        // Interacting with external systems(e.g., sending an email, calling a web API)
        // ella kunji logic stuff?????
    {
        private readonly ApplicationDbContext _dbContext; // this can only be set in the constructor of PersonService class

        public PersonService(ApplicationDbContext dbContext) //conmstructor
        {
            _dbContext = dbContext;
        }

        public List<Person> GetAll() //gets all people
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
            _dbContext.SaveChanges(); // Important: This saves the changes to the database!!!!!!!!!!!!!!!
        }

        public void Update(Person person)
        {
            _dbContext.People.Update(person);
            _dbContext.SaveChanges();  /// savee
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