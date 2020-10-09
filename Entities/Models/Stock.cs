using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public  decimal UnitCost { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]

        public decimal MarkUp { get; set; }
        [Required]

        public DateTime ExpiryDate { get; set; }
        [Required]

        public int Quantity { get; set; }

        [ForeignKey(nameof(Supplier))]
        public int SupplierID { get; set; }

        public  string BarCode{ get; set; }
        [ForeignKey(nameof(Product))]
        public string ProductID { get; set; }

    }
}
