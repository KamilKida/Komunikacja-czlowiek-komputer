using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementApp.Dtos;
using WarehouseManagementApp.Dtos.BaseValues;
using WarehouseManagementApp.Dtos.Dtos;
using WarehouseManagementApp.Forms;

namespace WarehouseManagementApp.Forms
{
    public partial class MainForm : Form
    {
        private BaseImagesValues _baseImagesValues;
        private MockData _mockData;

        public MainForm(BaseImagesValues baseImagesValues) : this()
        {
            _baseImagesValues = baseImagesValues;
            _mockData = new MockData();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        //Sekcja form
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var saveImage = Image.FromFile("Icons\\Save.png");

                _baseImagesValues.SaveImage = new Bitmap(saveImage, new Size(btn_LogOut.Size.Height - 10, btn_LogOut.Size.Height - 10));


                p_Main.BackColor = BaseColors.MainColor;

                var logOutImage = Image.FromFile("Icons\\LogOut.png");

                var logImageResized = new Bitmap(logOutImage, new Size(btn_LogOut.Size.Height - 10, btn_LogOut.Size.Height - 10));
                btn_LogOut.Image = logImageResized;

                btn_LogOut.Padding = new Padding(btn_LogOut.Size.Width / 5, 0, 0, 0);

                foreach (TabPage tab in tC_Main.TabPages)
                {
                    tab.BackColor = BaseColors.SecondaryColor;
                }

                var addImage = Image.FromFile("Icons\\Add.png");
                var deleteImage = Image.FromFile("Icons\\Delete.png");

                _baseImagesValues.AddImage = new Bitmap(addImage, new Size(btn_AddProducer.Size.Height - 12, btn_AddProducer.Size.Height - 12));
                _baseImagesValues.BtnAddDeletePadding = new Padding(btn_AddProducer.Size.Width / 7, 0, 0, 0);

                _baseImagesValues.DeleteImage = new Bitmap(deleteImage, new Size(btn_AddProducer.Size.Height - 12, btn_AddProducer.Size.Height - 12));

                btn_AddProducer.Image = btn_AddProduct.Image = btn_AddOrder.Image = btn_AddClient.Image = _baseImagesValues.AddImage;
                btn_AddProducer.Padding = btn_AddOrder.Padding = _baseImagesValues.BtnAddDeletePadding;

                btn_DeleteProducer.Image = btn_DeleteProduct.Image = btn_DeleteOrder.Image = btn_DeleteClient.Image = _baseImagesValues.DeleteImage;
                btn_DeleteProducer.Padding = btn_DeleteOrder.Padding = _baseImagesValues.BtnAddDeletePadding;


                btn_AddProduct.Padding = btn_AddOrder.Padding = btn_DeleteProduct.Padding = btn_DeleteOrder.Padding
                    = new Padding(_baseImagesValues.BtnAddDeletePadding.Left + 1, 0, 0, 0);


                var listImage = Image.FromFile("Icons\\ListIcon.png");
                var listImageResized = new Bitmap(listImage, new Size(btn_AddClient.Size.Height - 10, btn_AddClient.Size.Height - 10));

                _baseImagesValues.ListImage = listImageResized;

                var deliveryIcon = Image.FromFile("Icons\\DeliveryIcon.png");
                var deliveryImageResize = new Bitmap(deliveryIcon, new Size(btn_SendOrder.Size.Height - 12, btn_SendOrder.Size.Height - 12));

                btn_SendOrder.Image = deliveryImageResize;
                btn_SendOrder.Padding = new Padding(btn_SendOrder.Size.Width / 7, 0, 0, 0);

                _mockData.Producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                tV_Producers.SelectedNode = tV_Producers.Nodes[0];

                bS_Products.DataSource = _mockData.Producers[0].Products;

                if (_mockData.Orders[0].Send == true)
                {
                    btn_DeleteOrder.Enabled = false;
                    btn_SendOrder.Enabled = false;
                }

                bS_Clients.DataSource = _mockData.Clients;
                bS_Orders.DataSource = _mockData.Orders;

                foreach (var order in _mockData.Orders)
                {
                    if (order.ReapeatInDays is not null && order.Send)
                    {
                        order.SendDate = order.SendDate.AddDays((double)order.ReapeatInDays);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak podczas uruchamiania aplikacji.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Application.Exit();
            }

        }

        private void dGV_Orders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ChangeOrdersColors();
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
                    else
                    {
                        row.ReadOnly = true;
                    }
                }
            }
            catch
            {

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = (Button)sender;

                if (btn == btn_AddProducer)
                {
                    var addForm = new AddForm(_baseImagesValues, producers: _mockData.Producers);
                    addForm.ShowDialog();

                    tV_Producers.Nodes.Clear();
                    _mockData.Producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                    tV_Producers.SelectedNode = tV_Producers.Nodes[0];
                    bS_Products.DataSource = _mockData.Producers[0].Products;

                    foreach (TreeNode node in tV_Producers.Nodes)
                    {
                        var added = _mockData.Producers.FirstOrDefault(p => p.Name == node.Text).Added;
                        if (added) node.BackColor = BaseColors.AddedColor;
                    }
                }
                else if (btn == btn_AddProduct)
                {
                    var allProductList = _mockData.Producers.SelectMany(p => p.Products).OrderByDescending(pr => pr.Id).ToList();
                    var lastId = allProductList[0].Id;

                    var selectedProducer = _mockData.Producers.Where(p => p.Name == tV_Producers.SelectedNode.Text).FirstOrDefault();

                    var addForm = new AddForm(_baseImagesValues, producerToAddProducts: selectedProducer, lastId: lastId);
                    addForm.ShowDialog();

                    bS_Products.DataSource = null;
                    bS_Products.DataSource = selectedProducer.Products;


                    foreach (DataGridViewRow row in dGV_Products.Rows)
                    {
                        var product = (MagazinProduct)row.DataBoundItem;
                        if (product.Added)
                        {
                            row.DefaultCellStyle.BackColor = BaseColors.AddedColor;
                        }
                    }

                }
                else if (btn == btn_AddClient)
                {
                    var addForm = new AddForm(_baseImagesValues, clients: _mockData.Clients);
                    addForm.ShowDialog();

                    bS_Clients.DataSource = null;
                    bS_Clients.DataSource = _mockData.Clients;

                    foreach (DataGridViewRow row in dGV_Clients.Rows)
                    {
                        var client = (Client)row.DataBoundItem;
                        if (client.Added)
                        {
                            row.DefaultCellStyle.BackColor = BaseColors.AddedColor;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        //Sekcja producenci

        private void tV_Producers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                var selectedProducer = _mockData.Producers
                                        .Where(x => x.Name == e.Node.Text)
                                        .FirstOrDefault();

                if (selectedProducer is not null)
                {
                    bS_Products.DataSource = selectedProducer.Products;
                    if (selectedProducer.Added == true) e.Node.BackColor = BaseColors.SecondaryColor;
                }

                
            }
            catch
            {
                
            }
        }

        private void tV_Producers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var selectedProducer = _mockData.Producers
                                        .Where(x => x.Name == tV_Producers.SelectedNode.Text)
                                        .FirstOrDefault();

                var producerCard = new ProducerClientCard(selectedProducer, _baseImagesValues, _mockData, isProducer: true) ;
                producerCard.ShowDialog();

                tV_Producers.SelectedNode.Text = selectedProducer.Name;
            }
            catch
            {
                
            }
        }

        private void tV_Producers_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode checkedNode = (TreeNode)e.Node;

                var checkedProducer = _mockData.Producers.Where(p => p.Name == e.Node.Text).FirstOrDefault();
                checkedProducer.Checked = checkedNode.Checked;
            }
            catch
            {

            }
        }

        private void btn_DeleteProducer_Click(object sender, EventArgs e)
        {
            try
            {
                var checkedProducers = _mockData.Producers.Where(p => p.Checked).ToList();

                if (checkedProducers.Count > 0)
                {
                    var message = "Czy na pewno usunąć producentów?\n\n";
                    checkedProducers.ForEach(p => message += $"- {p.Name}\n");

                    var choice = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        tV_Producers.Nodes.Clear();
                        bS_Products.DataSource = null;
                        foreach (var producerToDelete in checkedProducers)
                        {
                            _mockData.Producers.Remove(producerToDelete);
                        }

                        _mockData.Producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                        tV_Producers.SelectedNode = tV_Producers.Nodes[0];

                        bS_Products.DataSource = _mockData.Producers[0].Products;
                    }
                }
                else
                {
                    var selectedProducer = _mockData.Producers.Where(p => p.Name == tV_Producers.SelectedNode.Text).FirstOrDefault();

                    var choice = MessageBox.Show($"Czy na pewno usunąć '{selectedProducer.Name}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (choice == DialogResult.Yes)
                    {
                        tV_Producers.Nodes.Clear();
                        bS_Products.DataSource = null;

                        _mockData.Producers.Remove(selectedProducer);
                        _mockData.Producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                        tV_Producers.SelectedNode = tV_Producers.Nodes[0];

                        bS_Products.DataSource = _mockData.Producers[0].Products;
                    }
                }

                _mockData.Producers.ForEach(p => p.Added = false);
            }
            catch
            {

            }
        }

        //Sekcja produkty

        private void dGV_Products_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedProduct = (MagazinProduct)dGV_Products.CurrentRow.DataBoundItem;

                if (selectedProduct is not null)
                {
                    var selectedProducer = _mockData.Producers
                                        .Where(x => x.Name == tV_Producers.SelectedNode.Text)
                                        .FirstOrDefault();

                    var fullProducerAcronim = "";

                    if (selectedProducer.AcronymNumber > 0) fullProducerAcronim = selectedProducer.AcronymNumber.ToString() + selectedProducer.Acronym;
                    else fullProducerAcronim = selectedProducer.Acronym;

                    var productCard = new ProductCard(selectedProduct, selectedProducer.Products.Select(p => p.ProductName).ToList(), fullProducerAcronim, _baseImagesValues);
                    productCard.ShowDialog();

                    bS_Products.DataSource = selectedProducer.Products;
                    dGV_Products.Refresh();
                }
            }
            catch
            {
                
            }
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProducer = _mockData.Producers
                                        .Where(x => x.Name == tV_Producers.SelectedNode.Text)
                                        .FirstOrDefault();

                var checkedProducts = selectedProducer.Products.Where(p => p.Checked).ToList();

                if (checkedProducts.Count > 0)
                {
                    var message = "Czy na pewno usunąć produkty?\n\n";
                    checkedProducts.ForEach(p => message += $"- {p.ProductName}\n");

                    var choice = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        bS_Products.DataSource = null;
                        foreach (var productToDelete in checkedProducts)
                        {
                            selectedProducer.Products.Remove(productToDelete);
                        }

                        bS_Products.DataSource = selectedProducer.Products;
                    }
                }
                else
                {
                    var selectedProduct = (MagazinProduct)dGV_Products.CurrentRow.DataBoundItem;

                    if (selectedProduct is not null)
                    {
                        var choice = MessageBox.Show($"Czy na pewno usunąć '{selectedProduct.ProductName}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (choice == DialogResult.Yes)
                        {
                            bS_Products.DataSource = null;

                            selectedProducer.Products.Remove(selectedProduct);

                            bS_Products.DataSource = selectedProducer.Products;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie wybrano produktu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                selectedProducer.Products.ForEach(p => p.Added = false);
            }
            catch
            {

            }
        }

        private void dGV_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedProduct = (MagazinProduct)dGV_Products.CurrentRow.DataBoundItem;


                if (selectedProduct.Added)
                {
                    dGV_Products.CurrentRow.DefaultCellStyle.BackColor = BaseColors.SecondaryColor;
                }
            }
            catch
            {

            }
        }

        //Sekcja klienci
        private void dGV_Clients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = (Client)dGV_Clients.CurrentRow.DataBoundItem;

                if (selectedClient is not null)
                {
                    var clientCard = new ProducerClientCard(selectedClient,_baseImagesValues, _mockData);
                    clientCard.ShowDialog();

                    dGV_Clients.Refresh();

                    tV_Producers.Nodes.Clear();
                    _mockData.Producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                    tV_Producers.SelectedNode = tV_Producers.Nodes[0];

                    bS_Products.DataSource = _mockData.Producers[0].Products;

                }

            }
            catch
            {
                
            }
        }


        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                var checkedClients = _mockData.Clients.Where(c => c.Checked).ToList();

                if (checkedClients.Count > 0)
                {
                    var message = "Czy na pewno usunąć klientów?\n\n";
                    checkedClients.ForEach(p => message += $"- {p.Name}\n");

                    var choice = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        bS_Clients.DataSource = null;
                        foreach (var clientToDelete in checkedClients)
                        {
                            _mockData.Clients.Remove(clientToDelete);
                        }

                        bS_Clients.DataSource = _mockData.Clients;
                    }
                }
                else
                {
                    var selectedClient = (Client)dGV_Clients.CurrentRow.DataBoundItem;

                    if (selectedClient != null)
                    {

                        var choice = MessageBox.Show($"Czy na pewno usunąć '{selectedClient.Name}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (choice == DialogResult.Yes)
                        {
                            bS_Clients.DataSource = null;

                            _mockData.Clients.Remove(selectedClient);

                            bS_Clients.DataSource = _mockData.Clients;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie wybrano klienta.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                _mockData.Clients.ForEach(c => c.Added = false);
            }
            catch
            {

            }
        }

        private void dGV_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedClient = (Client)dGV_Clients.CurrentRow.DataBoundItem;


                if (selectedClient.Added)
                {
                    dGV_Clients.CurrentRow.DefaultCellStyle.BackColor = BaseColors.SecondaryColor;
                }
            }
            catch
            {

            }
        }
        //Sekcja zamówienia

        private void dGV_Orders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedOrder = (Order)dGV_Orders.CurrentRow.DataBoundItem;
                var orderForm = new OrderForm(_baseImagesValues, selectedOrder, _mockData);
                orderForm.ShowDialog();
            }
            catch
            {
                
            }
        }

        private void dGV_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedOrder = (Order)dGV_Orders.CurrentRow.DataBoundItem;
                if (selectedOrder.Send)
                {
                    btn_SendOrder.Enabled = false;
                    btn_DeleteOrder.Enabled = false;
                }
                else
                {
                    btn_SendOrder.Enabled = true;
                    btn_DeleteOrder.Enabled = true;
                }
            }
            catch
            {

            }
        }
        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                bS_Orders.DataSource = null;
                var orderForm = new OrderForm(_baseImagesValues, new Order(), _mockData, newOrder: true);
                orderForm.ShowDialog();

                bS_Orders.DataSource = _mockData.Orders;
                dGV_Orders.Refresh();
                tV_Producers.Nodes.Clear();
                _mockData.Producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                tV_Producers.SelectedNode = tV_Producers.Nodes[0];

                bS_Products.DataSource = _mockData.Producers[0].Products;


            }
            catch
            {

            }
        }

        private void btn_DeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var checkedOrders = _mockData.Orders.Where(o => o.Checked && o.Send != true).ToList();

                if (checkedOrders.Count > 1)
                {
                    var message = "Czy na pewno usunąć wybrane zamówienia?\n\n";

                    foreach (var order in checkedOrders)
                    {
                        message += $"- Nr: {order.Id}, klient: {order.Client.Name}\n";
                    }
                    var choice = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (choice == DialogResult.Yes)
                    {
                        bS_Orders.DataSource = null;
                        foreach (var orderToDelete in checkedOrders)
                        {
                            _mockData.Orders.Remove(orderToDelete);
                        }
                        bS_Orders.DataSource = _mockData.Orders;
                    }
                }
                else
                {
                    var selectedOrder = (Order)dGV_Orders.CurrentRow.DataBoundItem;

                    var choice = MessageBox.Show($"Czy usunąć zamówienie o nr. {selectedOrder.Id}, dla klienta '{selectedOrder.Client.Name}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        bS_Orders.DataSource = null;
                        _mockData.Orders.Remove(selectedOrder);
                        bS_Orders.DataSource = _mockData.Orders;
                    }
                }
            }


            catch
            {

            }
        }

        private void btn_SendOrder_Click(object sender, EventArgs e)
        {
            try
            {

                var errorMessage = "Dla poniższych towarów brakuje ilości na magazynie. Zamówienie nie zostało wysłane\n\n";
                bool showErrorMessage = false;
                List<OrderProduct> productsWithTotalSum = new List<OrderProduct>();

                var selectedOrder = (Order)dGV_Orders.CurrentRow.DataBoundItem;
                foreach (var product in selectedOrder.Products)
                {
                    var productInList = productsWithTotalSum.Where(p => p.ProductName == product.ProductName).FirstOrDefault();

                    if(productInList is null)
                    {
                        product.TotalAmount = selectedOrder.Products.Where(x => x.ProductName == product.ProductName).Sum(p => p.OrderedAmount);

                        if(product.TotalAmount > product.MagazinProduct.AmountInMagazin)
                        {
                            errorMessage += $"- {product.ProductName}, brakuje: {product.TotalAmount - product.MagazinProduct.AmountInMagazin}\n";
                            showErrorMessage = true;
                        }
                        productsWithTotalSum.Add(product);
                    }
                }

                if (showErrorMessage)
                {
                    MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    selectedOrder.Send = true;
                    dGV_Orders.Refresh();
                    dGV_Orders.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    MessageBox.Show($"Zamówienie o nr. {selectedOrder.Id}, dla klienta: {selectedOrder.ClientName} zostało wysłane.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    productsWithTotalSum.ForEach(p => p.MagazinProduct.AmountInMagazin -= p.TotalAmount);
                    btn_DeleteOrder.Enabled = false;
                    btn_SendOrder.Enabled = false;
                }

            }
            catch
            {

            }

        }

    }
}
