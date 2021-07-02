using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.ViewModels
{
    public class SaleViewModel
    {
        public int SaleId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Total { get; set; }
    }
}
