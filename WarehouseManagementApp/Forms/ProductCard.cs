using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementApp.Dtos.BaseValues;
using WarehouseManagementApp.Dtos.Dtos;

namespace WarehouseManagementApp.Forms
{
    public partial class ProductCard : Form
    {
        private readonly MagazinProduct _product;
        private readonly string _producerAcronim;
        private readonly BaseImagesValues _baseImagesValues;
        private List<string> productsWithoutProduct;

        public ProductCard(MagazinProduct product, List<string> productsNames, string producerAcronim, BaseImagesValues baseImagesValues) : this()
        {
            _product = product;
            productsWithoutProduct = productsNames;

            _producerAcronim = producerAcronim;
            _baseImagesValues = baseImagesValues;
        }
        public ProductCard()
        {
            InitializeComponent();
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                p_Button.BackColor = BaseColors.SecondaryColor;

                btn_Save.Image = _baseImagesValues.SaveImage;
                btn_Save.Padding = _baseImagesValues.BtnAddDeletePadding;

                tB_Code.Text = $"{_producerAcronim}_{_product.Id}";
                tB_Name.Text = _product.ProductName;
                nUP_Gross.Value = _product.Gross;
                tB_GrossUnit.Text = tB_NetUnit.Text = _product.GrossUnit;
                nUD_Amount.Value = _product.AmountInMagazin;
                tB_AmountUnit.Text = _product.AomuntUnit;
                nUD_Weight.Value = _product.Weight;
                tB_WeightUnit.Text = _product.WeightUnit;
                tB_Description.Text = _product.Description;

                productsWithoutProduct.Remove(_product.ProductName);
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak podczas wyświetlania karty produktu.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.Close();
            }


        }


        private void nUP_Gross_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tB_Net.Text = (Math.Round(nUP_Gross.Value / (1 + 0.23M),2)).ToString();
            }
            catch
            {

            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var errorMessage = "";

                if (String.IsNullOrEmpty(tB_Name.Text)) errorMessage = "Nazwa towaru nie może być pusta.";
                if (String.IsNullOrEmpty(tB_AmountUnit.Text) && nUD_Amount.Value > 0) errorMessage = "Jednostka ilości nie może być pusta jeśli ilość jest większa od zero.";
                if (String.IsNullOrEmpty(tB_GrossUnit.Text) && nUP_Gross.Value > 0) errorMessage = "Jednostka ceny nie może być pusta jeśli cena jest większa od zero.";
                if (String.IsNullOrEmpty(tB_WeightUnit.Text) && nUD_Weight.Value > 0) errorMessage = "Jednostka waga nie może być pusta jeśli waga jest większa od zero.";
                if (productsWithoutProduct.Any(p => p == tB_Name.Text.Trim())) errorMessage = $"Produkt o nazwie '{tB_Name.Text.Trim()}' już istnieje na liście produktów wybranego producenta.";

                if (!String.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_product is not null)
                    {
                        _product.ProductName = tB_Name.Text;
                        _product.Gross = (Math.Round(nUP_Gross.Value,2));
                        _product.GrossUnit = tB_GrossUnit.Text;
                        _product.AmountInMagazin = nUD_Amount.Value;
                        _product.AomuntUnit = tB_AmountUnit.Text;
                        _product.Weight = nUD_Weight.Value;
                        _product.WeightUnit = tB_WeightUnit.Text;
                        _product.Description = tB_Description.Text;

                        MessageBox.Show("Zmiany zostały zapisane.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {
                
            }
        }

    }
}
     