using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementApp.Dtos.BaseValues;
using WarehouseManagementApp.Dtos.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehouseManagementApp.Forms
{
    public partial class AddForm : Form
    {
        private readonly BaseImagesValues _baseImagesValues;
        private readonly List<Producer> _producers;
        private readonly List<Client> _clients;
        private readonly Producer _producerToAddProducts;
        private string _filePath = string.Empty;
        private int _lastId;

        public AddForm(BaseImagesValues baseImagesValues,
            int lastId = 0,
            Producer producerToAddProducts = null,
            List<Producer> producers = null,
            List<Client> clients = null
            ) : this()
        {
            _lastId = lastId;
            _baseImagesValues = baseImagesValues;
            _producers = producers;
            _clients = clients;

            _producerToAddProducts = producerToAddProducts;
        }
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                p_Button.BackColor = BaseColors.SecondaryColor;

                var fileImage = Image.FromFile("Icons\\FileIcon.png");

                var fileImageResized = new Bitmap(fileImage, new Size(btn_File.Size.Height - 10, btn_File.Size.Height - 10));

                btn_File.Image = fileImageResized;

                btn_Save.Image = _baseImagesValues.SaveImage;
                btn_Save.Padding = new Padding(btn_Save.Size.Width / 5, 0, 0, 0);

                if (_producers is not null) this.Text = "Dodaj producenta";
                else if (_producerToAddProducts is not null) this.Text = "Dodaj produkt";
                else this.Text = "Dodaj klienta";
            }
            catch
            {
                
            }
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "Pliki JSON (*.json)|*.json",
                };

                openFileDialog.ShowDialog();

                _filePath = openFileDialog.FileName;

                tB_FilePath.Text = _filePath;
                btn_Save.Enabled = true;


            }
            catch
            {
                
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (_producers is not null)
                {
                    var producersToAdd = GetObject<List<Producer>>(_filePath);

                    if (producersToAdd is not null)
                    {
                        if (producersToAdd.Any(p => p.IsProduct) || producersToAdd.Any(p => p.IsClient))
                        {
                            MessageBox.Show("Wybrano nieodpowiedni plik JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var distinctProducers = DistinctProducers(producersToAdd);

                        if (distinctProducers.Count > 0)
                        {
                            GetAcronim(distinctProducers);

                            distinctProducers.ForEach(p => p.Added = true);

                            _producers.AddRange(distinctProducers);

                            var message = "Poniżsi producenci zostali dodani.\n\n";

                            foreach (var disProducer in distinctProducers)
                            {
                                message += $"- {disProducer.Name}";
                            }

                            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        return;
                    }
                    else
                    {

                        var producerToAdd = GetObject<Producer>(_filePath);


                        if (producerToAdd is not null)
                        {

                            if (producerToAdd.IsProduct || producerToAdd.IsClient)
                            {
                                MessageBox.Show("Wybrano nieodpowiedni plik JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            var sameNameProducer = _producers.Where(p => p.Name == producerToAdd.Name).FirstOrDefault();

                            if (sameNameProducer is not null)
                            {
                                MessageBox.Show($"Producent '{sameNameProducer.Name}' jest już obecny na liście." +
                    "\n Aby zaktualizować jego dane, należy skorzystać z karty producenta lub usunąć go i dodać ponownie.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                GetAcronimForOne(producerToAdd);
                                producerToAdd.Added = true;
                                _producers.Add(producerToAdd);
                            }

                            MessageBox.Show($"Producent '{producerToAdd.Name}' został dodany.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }


                    MessageBox.Show($"Nie udało się zdeserializować pliku JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_producerToAddProducts is not null)
                {
                    var productsToAdd = GetObject<List<MagazinProduct>>(_filePath);

                    if(productsToAdd is not null)
                    {
                        if(productsToAdd.Any(p => p.IsProduct == false))
                        {
                            MessageBox.Show("Wybrano nieodpowiedni plik JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        AddProdducts(productsToAdd, _producerToAddProducts);

                        var message = "Poniższe produkty zostały dodane.\n\n";
                        var showMessage = false;
                        foreach (var product in productsToAdd)
                        {
                            if (product.Added) 
                            { 
                                message += $"- {product.ProductName}\n"; 
                                showMessage = true; 
                            };
                        }

                        if(showMessage) MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Nie udało się zdeserializować pliku JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var clientsToAdd = GetObject<List<Client>>(_filePath);

                    
                    if (clientsToAdd is not null)
                    {
                        if (clientsToAdd.Any(p => p.IsProduct) || clientsToAdd.Any(c => !c.IsClient))
                        {
                            MessageBox.Show("Wybrano nieodpowiedni plik JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var distinctClients = DistinctClients(clientsToAdd);

                        distinctClients.ForEach(p => p.Added = true);

                        if (distinctClients.Count > 0)
                        {
                            _clients.AddRange(distinctClients);

                            var message = "Poniżsi klienci zostali dodani.\n\n";

                            foreach (var disProducer in distinctClients)
                            {
                                message += $"- {disProducer.Name}\n";
                            }

                            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        return;
                    }
                    else
                    {

                        var clientToAdd = GetObject<Client>(_filePath);

                        

                        if (clientToAdd is not null)
                        {
                            if (clientToAdd.IsProduct || !clientToAdd.IsClient)
                            {
                                MessageBox.Show("Wybrano nieodpowiedni plik JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            var sameNameClient = _clients.Where(p => p.Name == clientToAdd.Name).FirstOrDefault();

                            if (sameNameClient is not null)
                            {
                                MessageBox.Show($"Klient '{sameNameClient.Name}' jest już obecny na liście." +
                    "\n Aby zaktualizować jego dane, należy skorzystać z karty klienta lub usunąć go i dodać ponownie.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                clientToAdd.Added = true;
                                _clients.Add(clientToAdd);
                            }

                            MessageBox.Show($"Klient '{clientToAdd.Name}' został dodany.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }


                    MessageBox.Show($"Nie udało się zdeserializować pliku JSON.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
               
            }

        }

        private T? GetObject<T>(string filePath)
        {
            try
            {
                if (!System.IO.File.Exists(filePath)) return default;

                var jsonFile = System.IO.File.ReadAllText(filePath);

                var deserilizedObjects =  System.Text.Json.JsonSerializer.Deserialize<T>(jsonFile);

                return deserilizedObjects;
            }
            catch
            {
                return default;
            }
        }

        private void GetAcronim(List<Producer> addedProducers)
        {
            try
            {
                foreach (var producer in addedProducers)
                {
                    GetAcronimForOne(producer);
                }
            }
            catch
            {
                
            }
        }

        private void GetAcronimForOne(Producer producer)
        {
            try
            {
                var words = producer.Name.Split(' ');

                foreach (var word in words)
                {
                    if (word[1] == '.') continue;
                    else producer.Acronym += word[0].ToString().ToUpper();
                }

                var sameAcronimProducers = _producers.Where(p => p.Acronym == producer.Acronym)
                    .OrderByDescending(a => a.AcronymNumber)
                    .ToList();

                if (sameAcronimProducers.Count > 0) producer.AcronymNumber = sameAcronimProducers[0].AcronymNumber + 1;
            }
            catch
            {
                
            }
        }

        private List<Producer> DistinctProducers(List<Producer> deserializedProducers)
        {
            try
            {

                var warningMessage = "Wskazani producenci są już obecni na liście." +
                    "\nAby zaktualizować ich dane, należy skorzystać z karty producenta lub usunąć producenta i dodać go ponownie.\n\n";

                var showMessage = false;

                List<Producer> distinctProducers = new List<Producer>();

                foreach (var producer in deserializedProducers)
                {
                    var sameNameProducer = _producers.Where(p => p.Name == producer.Name).FirstOrDefault();

                    if (sameNameProducer is not null)
                    {
                        warningMessage += $"- {producer.Name}\n";
                        showMessage = true;
                    }
                    else distinctProducers.Add(producer);
                }

                if (showMessage == true)
                {
                    MessageBox.Show(warningMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return distinctProducers;
            }
            catch
            {
                return default;
            } 
        }

        private List<Client> DistinctClients(List<Client> deserializedClients)
        {
            try
            {

                var warningMessage = "Wskazani klienci są już obecni na liście." +
                                    "\nAby zaktualizować ich dane, należy skorzystać z karty klienta lub usunąć klienta i dodać go ponownie.\n\n";

                var showMessage = false;

                List<Client> distinctProducers = new List<Client>();

                foreach (var client in deserializedClients)
                {
                    var sameNameClient = _clients.Where(p => p.Name == client.Name).FirstOrDefault();

                    if (sameNameClient is not null)
                    {
                        warningMessage += $"- {client.Name}\n";
                        showMessage = true;
                    }
                    else distinctProducers.Add(client);
                }

                if (showMessage == true)
                {
                    MessageBox.Show(warningMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return distinctProducers;
            }
            catch
            {
                return default;
            }
        }

        public void AddProdducts(List<MagazinProduct> deserializedProduct, Producer producer)
        {
            try
            {
                var warningMessage = $"Wskazane produkty są już na liście producenta '{producer.Name}'." +
                                     $"\nAby zaktualizować ich dane, należy skorzystać z karty produktu lub usunąć produkty i dodać je ponownie.\n\n";


                var showMessage = false;

                foreach (var product in deserializedProduct)
                {
                    var sameNameProduct = producer.Products.Where(p => p.ProductName == product.ProductName).FirstOrDefault();

                    if (sameNameProduct is not null)
                    {
                        warningMessage += $"- {sameNameProduct.ProductName}\n";
                        sameNameProduct.Added = false;
                        showMessage = true;
                    }
                    else
                    {
                        product.Added = true;
                        _lastId += 1;
                        product.Id = _lastId;
                        producer.Products.Add(product);
                    }

                    
                }

                if (showMessage)
                {
                    MessageBox.Show(warningMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                
            }
        }
    } 
}