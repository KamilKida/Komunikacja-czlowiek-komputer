using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Dtos.Dtos
{
    public class MagazinProduct 
    {
        public int Id { get; set; }
        public bool IsProduct { get; set; } = false;
        public bool Checked { get; set; } = false;
        public string ProductName { get; set; }
        public decimal Gross { get; set; }
        public string GrossUnit { get; set; }
        public bool Added { get; set; } = false;
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set;}
        public decimal AmountInMagazin { get; set; }
        public string AomuntUnit { get; set; }

    }
}
