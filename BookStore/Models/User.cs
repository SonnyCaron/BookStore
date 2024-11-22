using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class User
    {
        [Key]
        public int UsertId { get; set; }
        [StringLength(100)]
        public required string FirstName { get; set; }
        [StringLength(100)]
        public required string LastName { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Le numéro de téléphone doit être au format international, par exemple : +1234567890.")]
        public required string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        [MinLength(6, ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$", ErrorMessage = "Le mot de passe doit contenir au moins une lettre et un chiffre.")]
        public required string Password { get; set; }

    }
}
