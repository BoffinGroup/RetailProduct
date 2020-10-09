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
      
        public string Name { get; set; }
        
        public  decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal MarkUp { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(Product))]
        public int SupplierID { get; set; }

        public  string BarCode{ get; set; }
        [ForeignKey(nameof(Product))]
        public string ProductID { get; set; }

    }
}
