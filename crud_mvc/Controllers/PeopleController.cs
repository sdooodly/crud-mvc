using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_mvc.Models;
using crud_mvc.Services;

namespace crud_mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PersonService _personService;

        public PeopleController(PersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            var people = _personService.GetAll();
            return View(people);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _personService.Add(person);
                return RedirectToAction("Index"); 
            }
            return View(person); 

        }
        
        public IActionResult Edit(int id)
        {
            var person = _personService.GetById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person); // Pass the person's data to the Edit view
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _personService.Update(person);
                return RedirectToAction("Index"); // Go back to the list after saving
            }
            return View(person); // If there are validation errors, show the form again with errors
        }
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}