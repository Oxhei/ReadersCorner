namespace ReadersCorner.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; } // Primary key

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Add any other properties or methods as needed
    }
}
