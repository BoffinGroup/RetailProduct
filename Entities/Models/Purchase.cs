using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }

        public decimal UnitCost { get; set; }
        public int SupplierID { get; set; }

        [ForeignKey(nameof(Stock))]
        public int StockId { get; set; }
        public  Stock Stock { get; set; }


    }
}
