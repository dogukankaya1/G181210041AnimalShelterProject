using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterProject.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitAnimal()
        {
            return View();
        }
        public IActionResult ApplyForAnimal()
        {
            return View();
        }
    }
}
