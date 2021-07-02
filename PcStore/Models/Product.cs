using System;
using System.Collections.Generic;

#nullable disable

namespace PcStore.Models
{
    public partial class Product
    {
        public Product()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Stock { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
