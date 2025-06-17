using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Dtos.Dtos
{
   public class OrderProduct 
    {
        public MagazinProduct MagazinProduct { get; set; }
        public string ProductName => MagazinProduct.ProductName;
        public bool Checked { get; set; }
        public decimal OrderedAmount { get; set; }
        public string OrderedAmountUnit => MagazinProduct.AomuntUnit;
        public decimal TotalAmount { get; set; }
        public decimal OrginalAmount { get; set; }
        public decimal GroosTimesAmount { get; set; }
        public decimal OrginalGroosTimesAmount {  get; set; }
        public string OrginalGroosTimesAmountUnit => MagazinProduct.GrossUnit;
        public decimal Net { get; set; }
        public decimal OrginalNet { get; set; }

    }
}
