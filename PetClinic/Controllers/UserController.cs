using Microsoft.AspNetCore.Mvc;
using PetClinic.Data;
using PetClinic.Models;
using System.Linq;

namespace PetClinic.Controllers
{
    public class UserController : Controller
    {
        private readonly PetClinicDbContext _context;

        public UserController(PetClinicDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Clients.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Invalid Credentials";
            return View();
        }
    }
}
