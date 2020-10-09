using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PurchaseReadDTO
    {
       
        public int Id { get; set; }
     
        public DateTime PurchaseDate { get; set; }
       
        public int Quantity { get; set; }
       

        public decimal UnitCost { get; set; }
      
        public int SupplierID { get; set; }

      
        public int StockId { get; set; }


    }
}
