using AnimalShelterProject.Data;
using AnimalShelterProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterProject.Controllers
{
    public class PersonController : Controller
    {
        ShelterDb db = new ShelterDb();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SavePersonData(Person person)
        {
            if(ModelState.IsValid) 
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return View(person);
            }
            else
                return View("Error");
            
        }
        

    }
}
