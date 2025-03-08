namespace PetClinic.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; } // Dog, Cat, etc.
        public int Age { get; set; }
        public int OwnerId { get; set; }
        public Client? Owner { get; set; }
    }
}
