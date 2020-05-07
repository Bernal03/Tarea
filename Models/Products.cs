using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tarea.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Suppliers Supplier { get; set; }
    }
}