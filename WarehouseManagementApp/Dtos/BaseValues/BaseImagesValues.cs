using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Dtos.BaseValues
{
    public class BaseImagesValues
    {
        public Image ConfirmImage { get; set; }
        public Image CancelImage { get; set; }
        public Padding BtnCancelPadding { get; set; }
        public Padding BtnConfirmPadding { get; set; }

        public Image AddImage { get; set; }
        public Image DeleteImage { get; set; }
        public Padding BtnAddDeletePadding { get; set; }

        public Image SaveImage { get; set; }

        public Image ListImage { get; set; }
    }
}
