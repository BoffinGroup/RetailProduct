using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DTOs
{
    public class StockCreateDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "UnitCost is required")]
        public decimal UnitCost { get; set; }
        [Required(ErrorMessage = "UnitPrice is required")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "MarkUp is required")]
        public decimal MarkUp { get; set; }

        [Required(ErrorMessage = "ExpiryDate is required")]
        public DateTime ExpiryDate { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "SupplierID is required")]
        public int SupplierID { get; set; }
        [Required(ErrorMessage = "BarCode is required")]
        public string BarCode { get; set; }
        [Required(ErrorMessage = "ProductID is required")]
        public string ProductID { get; set; }
    }
}
