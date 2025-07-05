using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Dtos.Dtos
{
    public class Order
    {
        public int Id { get; set; }
        public bool Send {  get; set; }  = true;
        public bool Checked { get; set; } = false;
        public Client Client { get; set; }
        public string ClientName => Client.Name;
        public DateTime CreationDate { get; set; }
        public DateTime SendDate { get; set; }
        public int? ReapeatInDays { get; set; }
        public List<OrderProduct> Products { get; set; } = new List<OrderProduct>();

    }
}
