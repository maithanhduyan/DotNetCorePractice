using System.ComponentModel.DataAnnotations;

namespace DatabaseConnectionPool.Models
{
    public class Product : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public int Price { get; set; }

        public int Stock { get; set; }
    }
}
