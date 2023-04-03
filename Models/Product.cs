using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public double? Price { get; set; }
        public DateTime? Dom { get; set; }
        public bool? Status { get; set; }
        public int? Suppid { get; set; }

        public virtual Supplier Supp { get; set; }
    }
}
