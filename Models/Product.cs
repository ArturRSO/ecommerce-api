using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_API.Models
{
    public class Product
    {
        [Column(Order = 7)]
        [Required]
        public bool Active { get; set; }

        [Column(Order = 5)]
        [Required]
        public DateTime CreationDate { get; set; }

        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(Order = 6)]
        public DateTime LastUpdate { get; set; }

        [Column(Order = 1)]
        [Required]
        public string Name { get; set; }

        [Column(Order = 3)]
        [Required]
        public decimal Price { get; set; }

        [Column(Order = 4)]
        [Required]
        public int Quantity { get; set; }

        [Column(Order = 2)]
        [Required]
        public string ShortDescription { get; set; }
    }
}
