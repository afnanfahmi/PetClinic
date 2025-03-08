using Microsoft.EntityFrameworkCore;
using PetClinic.Models; // Check if this matches your project structure

namespace PetClinic.Data // Your project name should be PetClinic
{
    public class PetClinicDbContext : DbContext
    {
        public PetClinicDbContext(DbContextOptions<PetClinicDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
