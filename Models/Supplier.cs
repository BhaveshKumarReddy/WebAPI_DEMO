using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int Sid { get; set; }
        public string Sname { get; set; }
        public string City { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
