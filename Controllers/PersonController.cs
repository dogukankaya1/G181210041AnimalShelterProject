using AnimalShelterProject.Data;
using AnimalShelterProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterProject.Controllers
{
    public class PersonController : Controller
    {
        ShelterDbContext db = new ShelterDbContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult SavePersonData(Person person)
        {
            if(ModelState.IsValid) 
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            else
                return View("Error");
            
        }
    
        public IActionResult SavePerson() 
        {
            return View();
        }

    }
    
}
