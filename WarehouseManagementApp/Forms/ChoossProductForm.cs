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
    public partial class ChoossProductForm : Form
    {
        private readonly List<Producer> _producers;
        private readonly List<OrderProduct> _orderProducts;
        private readonly BaseImagesValues _baseImagesValues;
        private readonly MockData _mockData;

        public ChoossProductForm(List<Producer> producers, List<OrderProduct> orderProducts, BaseImagesValues baseImagesValues, MockData mockData) : this()
        {
            _producers = producers;
            _orderProducts = orderProducts;
            _baseImagesValues = baseImagesValues;
            _mockData = mockData;
        }
        public ChoossProductForm()
        {
            InitializeComponent();
        }

        private void ChoossProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                p_Buttons.BackColor = BaseColors.SecondaryColor;
                btn_AddProduct.Image = _baseImagesValues.AddImage;
                btn_AddProduct.Padding = _baseImagesValues.BtnAddDeletePadding;

                _producers.ForEach(x => tV_Producers.Nodes.Add(x.Name));
                _producers.SelectMany(p => p.Products).ToList().ForEach(pr => pr.Checked = false);
                tV_Producers.SelectedNode = tV_Producers.Nodes[0];

                bS_Products.DataSource = _producers[0].Products;

            }
            catch
            {

            }
        }

        private void tV_Producers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                var selectedProducer = _producers
                                        .Where(x => x.Name == e.Node.Text)
                                        .FirstOrDefault();

                if (selectedProducer is not null)
                {
                    bS_Products.DataSource = selectedProducer.Products;

                }

                if (selectedProducer.Added == true) e.Node.BackColor = BaseColors.SecondaryColor;
            }
            catch
            {
                
            }
        }

        private void dGV_Products_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedProduct = (MagazinProduct)dGV_Products.CurrentRow.DataBoundItem;

                if (selectedProduct is not null)
                {
                    var orderProduct = _orderProducts.Where(p => p.MagazinProduct == selectedProduct).FirstOrDefault();


                    var selectedProducer = _producers
                                        .Where(x => x.Name == tV_Producers.SelectedNode.Text)
                                        .FirstOrDefault();

                    var fullProducerAcronim = "";

                    if (selectedProducer.AcronymNumber > 0) fullProducerAcronim = selectedProducer.AcronymNumber.ToString() + selectedProducer.Acronym;
                    else fullProducerAcronim = selectedProducer.Acronym;

                    var productCard = new ProductCard(selectedProduct, selectedProducer.Products.Select(p => p.ProductName).ToList(), fullProducerAcronim, _baseImagesValues);
                    productCard.ShowDialog();

                    if (orderProduct is not null)
                    {

                        orderProduct.Checked = false;
                        orderProduct.GroosTimesAmount = orderProduct.OrginalGroosTimesAmount = selectedProduct.Gross * orderProduct.OrderedAmount;
                        orderProduct.Net = orderProduct.OrginalNet = Math.Round((orderProduct.GroosTimesAmount / (1 + 0.23M)), 2);

                    }

                    bS_Products.DataSource = selectedProducer.Products;
                    dGV_Products.Refresh();
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
                var selectedProducer = _producers
                                        .Where(x => x.Name == tV_Producers.SelectedNode.Text)
                                        .FirstOrDefault();

                var producerCard = new ProducerClientCard(selectedProducer, _baseImagesValues, _mockData, isProducer: true);
                producerCard.ShowDialog();

                tV_Producers.SelectedNode.Text = selectedProducer.Name;
            }
            catch
            {
                
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProducer = _producers
                                        .Where(x => x.Name == tV_Producers.SelectedNode.Text)
                                        .FirstOrDefault();

                var checkedProducts = selectedProducer.Products.Where(p => p.Checked).ToList();

                if (checkedProducts.Count > 0)
                {
                    var message = "Czy na pewno dodać produkty?\n\n";
                    checkedProducts.ForEach(p => message += $"- {p.ProductName}\n");

                    var choice = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        foreach(var checkedProduct in checkedProducts)
                        {
                            _orderProducts.Add(new OrderProduct()
                            {
                                Checked = false,
                                MagazinProduct = checkedProduct,
                                OrderedAmount = 0,
                                OrginalAmount = 0,
                                GroosTimesAmount = checkedProduct.Gross,
                                OrginalGroosTimesAmount = checkedProduct.Gross,
                                Net = Math.Round((checkedProduct.Gross / (1 + 0.23M)), 2),
                                OrginalNet = Math.Round((checkedProduct.Gross / (1 + 0.23M)), 2),
                            });
                        }

                        this.Close();
                    }
                }
                else
                {
                    var selectedProduct = (MagazinProduct)dGV_Products.CurrentRow.DataBoundItem;

                    if (selectedProduct is not null)
                    {
                        var choice = MessageBox.Show($"Czy na pewno dodać '{selectedProduct.ProductName}'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (choice == DialogResult.Yes)
                        {
                            _orderProducts.Add(new OrderProduct()
                            {
                                Checked = false,
                                MagazinProduct = selectedProduct,
                                OrderedAmount = 0,
                                OrginalAmount = 0,
                                GroosTimesAmount = selectedProduct.Gross,
                                OrginalGroosTimesAmount = selectedProduct.Gross,
                                Net = Math.Round((selectedProduct.Gross / (1 + 0.23M)), 2),
                                OrginalNet = Math.Round((selectedProduct.Gross / (1 + 0.23M)), 2),
                            });

                            this.Close();
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
    }
}
