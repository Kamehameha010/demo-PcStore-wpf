using System;
using System.Collections.Generic;

#nullable disable

namespace PcStore.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int SaleId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Total { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
