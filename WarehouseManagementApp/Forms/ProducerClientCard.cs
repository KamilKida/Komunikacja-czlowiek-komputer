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
    public partial class ProducerClientCard : Form
    {
        private readonly BaseProducerClientInformation _producerClient;
        private readonly BaseImagesValues _baseImagesValues;
        private readonly MockData _mockData;
        private readonly bool _isProducer;
        private List<string> _namesWithoutObjectName;

        public ProducerClientCard(BaseProducerClientInformation producerClient, BaseImagesValues baseImagesValues, MockData mockData, bool isProducer = false) : this()
        {
            _producerClient = producerClient;

            _baseImagesValues = baseImagesValues;
            _mockData = mockData;

            _isProducer = isProducer;
        }
        public ProducerClientCard()
        {
            InitializeComponent();
        }

        private void ProducerCard_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                p_Button.BackColor = BaseColors.SecondaryColor;

                btn_Save.Image = _baseImagesValues.SaveImage;
                btn_Save.Padding = _baseImagesValues.BtnAddDeletePadding;

                if (_producerClient is Producer producer)
                {
                    this.Text = "Karta producenta";
                    if (producer.AcronymNumber != 0) tB_Acronim.Text = $"{producer.AcronymNumber}{producer.Acronym}";
                    else tB_Acronim.Text = producer.Acronym;
                }
                else
                {
                    this.Text = "Karta klienta";
                    tB_Acronim.Hide();
                    tB_Acronim.Anchor = AnchorStyles.None;
                    tB_Name.Location = new Point(tB_Acronim.Location.X, tB_Name.Location.Y);
                    tB_Name.Size = new Size(tB_Name.Width + tB_Acronim.Width + 6, tB_Name.Height);

                    btn_ClientOrders.Image = _baseImagesValues.ListImage;

                    btn_ClientOrders.Visible = true;
                }

                tB_Name.Text = _producerClient.Name;
                tB_Country.Text = _producerClient.Adress.Country;
                tB_City.Text = _producerClient.Adress.City;
                tB_Street.Text = _producerClient.Adress.Street;
                tB_PostalCodde.Text = _producerClient.Adress.PostalCode;
                tB_Email.Text = _producerClient.Email;
                tB_Phone1.Text = _producerClient.Tel1;
                tB_Phone2.Text = _producerClient.Tel2;
                tB_Description.Text = _producerClient.Description;

                if (!_isProducer) _namesWithoutObjectName = _mockData.Clients.Select(x => x.Name).ToList();
                else _namesWithoutObjectName = _mockData.Producers.Select(x => x.Name).ToList();


                _namesWithoutObjectName.Remove(_producerClient.Name);

            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak podczas wyświetlania karty producenta.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.Close();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var errorMessage = "";

                if (String.IsNullOrEmpty(tB_Name.Text)) errorMessage = "Pole nazwy nie może być puste.";
                if (String.IsNullOrEmpty(tB_Email.Text)) errorMessage = "Pole e-maila nie może być puste.";
                if (String.IsNullOrEmpty(tB_Phone1.Text) && String.IsNullOrEmpty(tB_Phone2.Text)) errorMessage = "Co najmniej jedno pole numeru telefonu musi być wypełnione.";

                if (String.IsNullOrEmpty(tB_Country.Text)) errorMessage = "Pole kraju nie może być puste.";
                if (String.IsNullOrEmpty(tB_City.Text)) errorMessage = "Pole miasta nie może być puste.";
                if (String.IsNullOrEmpty(tB_Street.Text)) errorMessage = "Pole ulicy nie może być puste.";
                if (String.IsNullOrEmpty(tB_PostalCodde.Text)) errorMessage = "Pole kodu pocztowego nie może być puste.";

                if (_namesWithoutObjectName.Any(pc => pc == tB_Name.Text.Trim()))
                {
                    if (_producerClient is Producer producer)
                    {
                        errorMessage = $"Producent '{tB_Name.Text.Trim()}' występuje już na liście producentów.";
                    }
                    else
                    {
                        errorMessage = $"Klient '{tB_Name.Text.Trim()}' występuje już na liście klientów.”";
                    }
                }

                if (!String.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_producerClient is not null)
                    {
                        _producerClient.Name = tB_Name.Text;

                        _producerClient.Adress.Country = tB_Country.Text;
                        _producerClient.Adress.City = tB_City.Text;
                        _producerClient.Adress.Street = tB_Street.Text;
                        _producerClient.Adress.PostalCode = tB_PostalCodde.Text;

                        _producerClient.Email = tB_Email.Text;
                        _producerClient.Tel1 = tB_Phone1.Text;
                        _producerClient.Tel2 = tB_Phone2.Text;
                        _producerClient.Description = tB_Description.Text;


                        MessageBox.Show("Zmiany zostały zapisane.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {
                
            }
        }

        private void btn_ClientOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var clientOrdersForm = new ClientOrdersForm(_mockData.Orders.Where(o => o.Client == _producerClient).ToList(), _baseImagesValues, _mockData);
                clientOrdersForm.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
