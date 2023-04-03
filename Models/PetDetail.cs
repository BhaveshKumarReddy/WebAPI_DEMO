using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class PetDetail
    {
        public PetDetail()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public string PetId { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public int? AgeInDays { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
