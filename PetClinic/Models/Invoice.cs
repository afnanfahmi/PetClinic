using PetClinic.Models;

namespace PetClinic.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
        public decimal Amount { get; set; }

        public virtual decimal CalculateBill()
        {
            return Amount;
        }
    }
}
