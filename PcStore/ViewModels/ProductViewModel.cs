using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.ViewModels
{
    class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Stock { get; set; }
        public int? Price { get; set; }
    }
}
