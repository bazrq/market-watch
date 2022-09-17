using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TradingSite
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? ApiStatus { get; set; }
        public string? ApiV2Status { get; set; }
    }
}
