using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_DEMO.Models
{
    public partial class V2
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public bool? Status { get; set; }
        public int? Suppid { get; set; }
    }
}
