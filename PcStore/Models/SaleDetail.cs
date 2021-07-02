using System;
using System.Collections.Generic;

#nullable disable

namespace PcStore.Models
{
    public partial class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
