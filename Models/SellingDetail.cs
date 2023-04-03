using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class SellingDetail
    {
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public int? ContactNumber { get; set; }
        public string ModelNumber { get; set; }
        public string BillNumber { get; set; }
        public decimal? SellingPrice { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public virtual SpecsModel ModelNumberNavigation { get; set; }
    }
}
