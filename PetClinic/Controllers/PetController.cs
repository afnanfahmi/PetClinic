using Microsoft.AspNetCore.Mvc;
using PetClinic.Models;
using PetClinic.Data;
using System.Linq;

namespace PetClinicWeb.Controllers
{
    public class PetController : Controller
    {
        private readonly PetClinicDbContext _context; // Define the context

        public PetController(PetClinicDbContext context) // Inject the context
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index()
        {
            var pets = _context.Pets.ToList(); // Ensure it's not null
            if (pets == null)
            {
                pets = new List<Pet>(); // Prevent null reference issue
            }
            return View(pets);
        }


        [HttpPost]
        public IActionResult Add(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
