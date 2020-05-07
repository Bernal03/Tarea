using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tarea.Models
{
    public class Suppliers
    {
        public int Id { get; set; }
        public int SupplierCode { get; set; }
        public string SupplierNAme { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}