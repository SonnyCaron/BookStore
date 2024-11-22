using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "La date de commande est obligatoire.")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "L'utilisateur est obligatoire.")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public required User User { get; set; } // Relation avec l'entité User

        [Required(ErrorMessage = "Le montant total est obligatoire.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Le montant total doit être une valeur positive.")]
        public decimal TotalAmount { get; set; }

        public required ICollection<OrderItem> OrderItems { get; set; } // Relation avec les items de commande
    }

}
