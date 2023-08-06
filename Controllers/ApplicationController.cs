using AnimalShelterProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterProject.Controllers
{
    public class ApplicationController : Controller
    {

        ShelterDbContext _ShelterDbContext= new ShelterDbContext();



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitAnimal()
        {
            return View();
        }
        public IActionResult AddSubmission()
        {
            return View();
        }
        public IActionResult ApplyForAnimal()
        {
            return View();
        }
        public IActionResult ListSubmits()
        {
            var submitList = (from submit in _ShelterDbContext.Applications
                             where (submit.isSubmit) == true
                              select submit).Include(submit => submit.Person).ToList();
            return View(submitList);
        }
        public IActionResult ListApplies() 
        {
            return View();
        }
    }
}
