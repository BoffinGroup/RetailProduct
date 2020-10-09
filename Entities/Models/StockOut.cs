using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class StockOut
    {
        public int Id { get; set; }
        public DateTime DateOut { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(Stock))]
        public int StockId { get; set; }
    }
}
