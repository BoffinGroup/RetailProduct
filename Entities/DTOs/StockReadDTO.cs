using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StockReadDTO
    {       
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal MarkUp { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int Quantity { get; set; }
      
        public int SupplierID { get; set; }

        public string BarCode { get; set; }      
        public string ProductID { get; set; }
    }
}
