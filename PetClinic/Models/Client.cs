﻿using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialize with default value

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;

        // Constructor to ensure properties are initialized
        public Client()
        {
            Name = string.Empty;
            Username = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }
    }

}
