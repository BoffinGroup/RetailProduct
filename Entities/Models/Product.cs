using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }       

        [ForeignKey(nameof(ProductCategory))]
        public int CatetoryId { get; set; }
    }
}
