using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public class Product
    {
        [Key] //Make this Primary Key (PK) in DB
        public int ProductId { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        [Required]
        [StringLength(350)]
        public string Description { get; set; }

        [Range(0.0, 1000000.0)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        public string Category { get; set; }

    }
}
