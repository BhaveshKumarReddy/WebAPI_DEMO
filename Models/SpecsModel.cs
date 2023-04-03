using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class SpecsModel
    {
        public SpecsModel()
        {
            SellingDetails = new HashSet<SellingDetail>();
        }

        public string BrandName { get; set; }
        public string ModelNumber { get; set; }
        public string SpecsType { get; set; }
        public decimal? LensPower { get; set; }
        public decimal? Cost { get; set; }
        public int? InStock { get; set; }

        public virtual ICollection<SellingDetail> SellingDetails { get; set; }
    }
}
