namespace PetClinic.Models
{
    public class Veterinarian : Person
    {
        public string? Specialty { get; set; }

        public virtual string GetDetails()
        {
            return $"Dr. {Name} - {Specialty} Specialist";
        }
    }
}
