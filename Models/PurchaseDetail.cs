using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class PurchaseDetail
    {
        public int PurchaseId { get; set; }
        public string CustomerId { get; set; }
        public string PetId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? TotalAmountPaid { get; set; }

        public virtual CustomerDetail Customer { get; set; }
        public virtual PetDetail Pet { get; set; }
    }
}
