using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementApp.Dtos;
using WarehouseManagementApp.Dtos.BaseValues;
using WarehouseManagementApp.Dtos.Dtos;

namespace WarehouseManagementApp.Forms
{
    public partial class ClientOrdersForm : Form
    {
        private readonly List<Order> _clientOrders;
        private readonly BaseImagesValues _baseImagesValues;
        private readonly MockData _mockData;

        public ClientOrdersForm(List<Order> clientOrders, BaseImagesValues baseImagesValues, MockData mockData) : this()
        {
            _clientOrders = clientOrders;
            _baseImagesValues = baseImagesValues;
            _mockData = mockData;
        }
        public ClientOrdersForm()
        {
            InitializeComponent();
        }

        private void ClientOrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                bS_Orders.DataSource = _clientOrders;
                dGV_Orders.Refresh();

                ChangeOrdersColors();
            }
            catch
            {
            }
        }

        private void dGV_Orders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedOrder = (Order)dGV_Orders.CurrentRow.DataBoundItem;
                var orderForm = new OrderForm(_baseImagesValues, selectedOrder, _mockData);
                orderForm.ShowDialog();

                dGV_Orders.Refresh();
            }
            catch
            {
                
            }
        }


        private void ChangeOrdersColors()
        {
            try
            {
                foreach (DataGridViewRow row in dGV_Orders.Rows)
                {
                    var order = (Order)row.DataBoundItem;
                    if (!order.Send)
                    {
                        row.DefaultCellStyle.ForeColor = Color.YellowGreen;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
