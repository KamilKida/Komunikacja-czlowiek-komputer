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
    public partial class OrderForm : Form
    {
        private readonly BaseImagesValues _baseImagesValues;
        private Order _order;
        private List<OrderProduct> _orderProducts;
        private MockData _mockData;

        private readonly bool _newOrder;
        private Dictionary<string, int> _reapetList;


        public OrderForm(BaseImagesValues baseImagesValues, Order order, MockData mockData, bool newOrder = false) : this()
        {
            _baseImagesValues = baseImagesValues;
            _order = order;
            _mockData = mockData;
            _newOrder = newOrder;
        }
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                p_Buttons.BackColor = BaseColors.SecondaryColor;

                btn_AddProduct.Image = _baseImagesValues.AddImage;
                btn_DeleteProduct.Image = _baseImagesValues.DeleteImage;
                btn_AddProduct.Padding = btn_DeleteProduct.Padding = new Padding(_baseImagesValues.BtnAddDeletePadding.Left + 1, 0, 0, 0);

                btn_Save.Image = _baseImagesValues.SaveImage;
                btn_Save.Padding = _baseImagesValues.BtnAddDeletePadding;

                tB_OrderNumber.Text = _order.Id.ToString();

                ReapetList();
                cB_ReapeatList.Items.AddRange(_reapetList.Keys.ToArray());


                _orderProducts = _order.Products.ToList();
                bS_OrderProducts.DataSource = _orderProducts;

                if (!_newOrder)
                {
                    tB_ClientName.Size = new Size(tB_ClientName.Size.Width + btn_ClientList.Width + 1, tB_ClientName.Height);

                    Sum();

                    dTP_OrderCreation.Value = _order.CreationDate;
                    dTP_SendDate.Value = _order.SendDate;

                    tB_ClientName.Text = _order.Client.Name;

                    if(_order.Send) dTP_SendDate.Enabled = false;

                    if (_order.ReapeatInDays is not null)
                    {
                        var amountOfDaysString = _reapetList.Where(r => r.Value == _order.ReapeatInDays).FirstOrDefault();

                        cB_ReapeatList.Text = amountOfDaysString.Key.ToString();

                        cB_Repeat.Checked = true;
                        cB_Repeat.Enabled = true;
                        cB_ReapeatList.Enabled = true;
                    }
                    else
                    {
                        if (_order.Send)
                        {
                            btn_AddProduct.Enabled = false;
                            btn_DeleteProduct.Enabled = false;
                            btn_Save.Enabled = false;
                            dGV_Products.ReadOnly = true;
                        }
                        else
                        {
                            cB_Repeat.Enabled = true;
                        }
                    }
                }
                else
                {
                    btn_ClientList.Visible = true;

                    var listImage = Image.FromFile("Icons\\ListIcon.png");
                    var listImageResized = new Bitmap(listImage, new Size(btn_ClientList.Size.Height - 10, btn_ClientList.Size.Height - 10));

                    btn_ClientList.Image = listImageResized;

                    dTP_OrderCreation.Value = DateTime.Now;
                    dTP_SendDate.Value = DateTime.Now;

                    _order.CreationDate = dTP_OrderCreation.Value;

                    var iD = _mockData.Orders.OrderByDescending(o => o.Id).ToList().FirstOrDefault().Id + 1;

                    _order.Id = iD;
                    _order.Send = false;
                    tB_OrderNumber.Text = iD.ToString();

                    cB_Repeat.Enabled = true;
                    cB_ReapeatList.Enabled = true;
                }

            }
            catch
            {

            }
        }

        private void ReapetList()
        {
            try
            {
                _reapetList = new Dictionary<string, int>();
                _reapetList.Add("1 tydzień", 7);
                _reapetList.Add("2 tygodnie", 14);
                _reapetList.Add("1 miesiąc", 28);

            }
            catch
            {

            }
        }

        private void dTP_SendOrder_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dTP_SendDate.Value < _order.CreationDate)
                {
                    MessageBox.Show("Data wysyłki zamówienia nie może być mniejsza od daty utworzenia zamówienia.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dTP_SendDate.Value = _order.SendDate;
                }
            }
            catch
            {
                
            }
        }

        private void cB_Repeat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cB_Repeat.Checked)
                {
                    cB_ReapeatList.Enabled = true;
                }
                else
                {
                    cB_ReapeatList.Enabled = false;

                }

            }
            catch
            {

            }
        }



        private void dGV_Products_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    var selectedProduct = (OrderProduct)dGV_Products.Rows[e.RowIndex].DataBoundItem;
                    
                    var sumOfProductAmount = _orderProducts.Sum(p => p.OrderedAmount);

                    decimal newValue = (decimal)dGV_Products.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if ((decimal)newValue < 0M)
                    {
                        MessageBox.Show("Ilość nie może być mniejsza od zera.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedProduct.OrderedAmount = selectedProduct.OrginalAmount;
                    }
                    else
                    {
                        selectedProduct.OrderedAmount = newValue;
                        Count(selectedProduct);
                    }
                }
            }
            catch
            {

            }
        }

        private void dGV_Products_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedProduct = (OrderProduct)dGV_Products.CurrentRow.DataBoundItem;

                if (selectedProduct is not null)
                {
                    var productProducer = _mockData.Producers.Where(p => p.Products.Any(pr => pr.ProductName == selectedProduct.MagazinProduct.ProductName)).FirstOrDefault();

                    if (productProducer is not null)
                    {
                        var fullProducerAcronim = "";

                        if (productProducer.AcronymNumber > 0) fullProducerAcronim = productProducer.AcronymNumber.ToString() + productProducer.Acronym;
                        else fullProducerAcronim = productProducer.Acronym;

                        var productCard = new ProductCard(selectedProduct.MagazinProduct, productProducer.Products.Select(p => p.ProductName).ToList(), fullProducerAcronim, _baseImagesValues);
                        productCard.ShowDialog();

                        Count(selectedProduct);

                    }
                }
            }
            catch
            {

            }
        }

        private void Count(OrderProduct orderProduct)
        {
            try
            {
                orderProduct.GroosTimesAmount = orderProduct.MagazinProduct.Gross * orderProduct.OrderedAmount;
                orderProduct.Net = Math.Round((orderProduct.GroosTimesAmount / (1 + 0.23M)), 2);

                dGV_Products.Refresh();

                Sum();
            }
            catch
            {

            }
        }

        private void Sum()
        {
            try
            {
                tB_BruttoSum.Text = $"{_orderProducts.Sum(p => p.GroosTimesAmount).ToString("F2")} {_orderProducts[0].MagazinProduct.GrossUnit}";
                tB_NetSum.Text = $"{_orderProducts.Sum(p => p.Net).ToString("F2")} {_orderProducts[0].MagazinProduct.GrossUnit}";

            }
            catch
            {

            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var chosseProduct = new ChoossProductForm(_mockData.Producers, _orderProducts, _baseImagesValues, _mockData);
                chosseProduct.ShowDialog();

                bS_OrderProducts.DataSource = null;
                bS_OrderProducts.DataSource = _orderProducts;
                dGV_Products.Refresh();

                Sum();
            }
            catch
            {

            }
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var checkedProducts = _orderProducts.Where(p => p.Checked).ToList();

                if (checkedProducts.Count > 0)
                {
                    var message = "Czy na pewno usunąć produkty?\n\n";
                    checkedProducts.ForEach(p => message += $"- {p.MagazinProduct.ProductName}\n");

                    var choice = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        bS_OrderProducts.DataSource = null;
                        foreach (var productToDelete in checkedProducts)
                        {
                            _orderProducts.Remove(productToDelete);
                        }

                        bS_OrderProducts.DataSource = _orderProducts;
                    }
                }
                else
                {
                    var selectedProduct = (OrderProduct)dGV_Products.CurrentRow.DataBoundItem;

                    if (selectedProduct is not null)
                    {
                        var choice = MessageBox.Show($"Czy na pewno usunąć '{selectedProduct.MagazinProduct.ProductName}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (choice == DialogResult.Yes)
                        {
                            bS_OrderProducts.DataSource = null;

                            _orderProducts.Remove(selectedProduct);

                            bS_OrderProducts.DataSource = _orderProducts;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie wybrano produktu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tB_ClientName.Text))
                {

                    _order.SendDate = dTP_SendDate.Value;
                    _order.Products = _orderProducts.ToList();
                    if (cB_Repeat.Checked)
                    {
                        var amountOfDaysInt = _reapetList.Where(r => r.Key == cB_ReapeatList.Text).FirstOrDefault();
                        _order.ReapeatInDays = amountOfDaysInt.Value;
                    }
                    else
                    {
                        _order.ReapeatInDays = null;
                    }
                    MessageBox.Show("Zmiany zostały zapisane.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_newOrder)
                    {
                        if (!_mockData.Orders.Contains(_order))
                        {
                            _mockData.Orders.Add(_order);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano klienta.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void btn_ClientList_Click(object sender, EventArgs e)
        {
            try
            {
                var chooseClientForm = new ChooseClientForm(_baseImagesValues, _mockData, _order);
                chooseClientForm.ShowDialog();

                if(_order.Client is not null) tB_ClientName.Text = _order.Client.Name;
            }
            catch
            {

            }
        }
    }
}
