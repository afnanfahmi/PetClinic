using Microsoft.AspNetCore.Mvc;
using PetClinic.Data;
using PetClinic.Models;
using System.Linq;

namespace PetClinicWeb.Controllers
{
    [Route("Appointment")]
    public class AppointmentController : Controller
    {
        private readonly PetClinicDbContext _context;

        public AppointmentController(PetClinicDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var appointments = _context.Appointments.ToList();
            return View(appointments);
        }

        [HttpPost]
        public IActionResult Book(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointment);
        }
    }
}