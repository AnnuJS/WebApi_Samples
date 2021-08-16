using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column(TypeName ="varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        [ForeignKey("CategoryName")]
        public int CategoryId { get; set; }

        public Category CategoryName { get; set; }
    }
}
