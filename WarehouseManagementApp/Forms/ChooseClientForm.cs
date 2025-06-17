using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
    public partial class ChooseClientForm : Form
    {
        private readonly BaseImagesValues _baseImagesValues;
        private readonly MockData _mockData;
        private readonly Order _order;

        public ChooseClientForm(BaseImagesValues baseImagesValues, MockData mockData , Order order) : this()
        {
            _baseImagesValues = baseImagesValues;
            _mockData = mockData;
            _order = order;
        }
        public ChooseClientForm()
        {
            InitializeComponent();
        }

        private void ChooseClientForm_Load(object sender, EventArgs e)
        {
            p_Main.BackColor = BaseColors.MainColor;
            p_Buttons.BackColor = BaseColors.SecondaryColor;

            btn_AddClient.Image = _baseImagesValues.AddImage;
            btn_AddClient.Padding = _baseImagesValues.BtnAddDeletePadding;

            bS_Clients.DataSource = _mockData.Clients; 
        }

        private void dGV_Clients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = (Client)dGV_Clients.CurrentRow.DataBoundItem;

                if (selectedClient is not null)
                {
                    var clientCard = new ProducerClientCard(selectedClient, _baseImagesValues, _mockData);
                    clientCard.ShowDialog();

                    dGV_Clients.Refresh();

                }

            }
            catch
            {
                
            }
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = (Client)dGV_Clients.CurrentRow.DataBoundItem;

                _order.Client = selectedClient;
                this.Close();
            }
            catch
            {

            }
        }
    }
}
