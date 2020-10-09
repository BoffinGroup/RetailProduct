using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTOs
{
    public class PurchaseCreateDTO
    {
       
        public int Id { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]

        public decimal UnitCost { get; set; }
        [Required]
        public int SupplierID { get; set; }

        [Required]
        public int StockId { get; set; }
     

    }
}
