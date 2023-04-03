using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class CustomerDetail
    {
        public CustomerDetail()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public string City { get; set; }

        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
