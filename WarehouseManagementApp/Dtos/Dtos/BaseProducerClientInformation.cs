using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Dtos.Dtos
{
    public abstract class BaseProducerClientInformation
    {
        public bool Added { get; set; } = false;
        public bool Checked { get; set; } = false;
        public bool IsProduct { get; set; } = false;
        public bool IsClient {  get; set; } = false;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Description { get; set; }
        public Adress Adress { get; set; }
    }
}
