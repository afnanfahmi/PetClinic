using Microsoft.AspNetCore.Mvc;
using PetClinic.Models;
using PetClinic.Data;
using System.Linq;

namespace PetClinicWeb.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly PetClinicDbContext _context;

        public InvoiceController(PetClinicDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var invoices = _context.Invoices.ToList();
            return View(invoices);
        }

        [HttpPost]
        public IActionResult Generate(int appointmentId, decimal amount)
        {
            var appointment = _context.Appointments.FirstOrDefault(a => a.Id == appointmentId);
            if (appointment == null)
            {
                return NotFound("Appointment not found.");
            }

            var invoice = new Invoice { AppointmentId = appointmentId, Amount = amount };
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
