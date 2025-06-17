using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Dtos.Dtos
{
    public class Producer : BaseProducerClientInformation
    {
        public string Acronym {  get; set; }
        public int AcronymNumber { get; set; }
        public List<MagazinProduct> Products { get; set; }

    }
}
