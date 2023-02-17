using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioDotNetCoreKhipo.Models
{
    public class Products
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="Varchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
