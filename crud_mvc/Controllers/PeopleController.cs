using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_mvc.Models;
using crud_mvc.Services;

namespace crud_mvc.Controllers
{
    public class PeopleController : Controller //inherits from Controller class, part of MVC package???
    {
        private readonly PersonService _personService; //dependency injection here. uses instance of PersonService when PeopleController is created

        public PeopleController(PersonService personService) //constructor
        {
            _personService = personService;
        }

        public IActionResult Index() // see the name of ACTION METHOD. thats how it knows which view to call
        {
            var people = _personService.GetAll();
            return View(people);
        }

        public IActionResult Create() // see the name of ACTION METHOD. thats how it knows which view to call
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _personService.Add(person);
                return RedirectToAction("Index");  //display
            }
            return View(person); 

        }
        
        public IActionResult Edit(int id) // see the name of ACTION METHOD. thats how it knows which view to call
        {
            var person = _personService.GetById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person); 
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _personService.Update(person);
                return RedirectToAction("Index"); // Go back to the list after saving
            }
            return View(person); // If there are validation errors we show the form again with errors
        }
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}