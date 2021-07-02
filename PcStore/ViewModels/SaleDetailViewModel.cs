using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.ViewModels
{
    class SaleDetailViewModel
    {
        public int SaleDetailId { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }
    }
}
