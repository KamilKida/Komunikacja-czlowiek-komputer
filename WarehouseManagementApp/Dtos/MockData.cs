using WarehouseManagementApp.Dtos.Dtos;

namespace WarehouseManagementApp.Dtos
{
    public class MockData
    {
        public List<Producer> Producers;
        public List<Client> Clients;
        public List<Order> Orders;

        public MockData()
        {
            SetMockData();
        }

        private void SetMockData()
        {
            var producer1 = new Producer()
            {
                Name = "Producent śrób",
                Acronym = "PŚ",
                AcronymNumber = 0,
                Email = "testowy@test.com",
                Tel1 = "00 001 00 01",
                Tel2 = null,
                Description = null,
                Adress = new Adress()
                {
                    City = "Warszawa",
                    Country = "Polska",
                    Street = "Jakaś 12",
                    PostalCode = "00-001"
                },
                Products = new List<MagazinProduct>()
                {
                    new MagazinProduct()
                    {
                        Id = 1,
                        ProductName = "Śróba płaska",
                        Description = null,
                        Gross = 1.05M,
                        GrossUnit = "zł",
                        Weight = 0.5M,
                        WeightUnit = "g.",
                        AmountInMagazin = 100M,
                        AomuntUnit = "szt."
                    },

                    new MagazinProduct()
                    {
                        Id = 2,
                        ProductName = "Śróba wypukła",
                        Description = "Specjalna śruba.",
                        Gross = 10.99M,
                        GrossUnit = "zł",
                        Weight = 1M,
                        WeightUnit = "kg.",
                        AmountInMagazin = 1300M,
                        AomuntUnit = "szt."
                    }

                }

            };

            var producer2 = new Producer()
            {
                Name = "Producent blach",
                Acronym = "PB",
                AcronymNumber = 0,
                Email = "testowy@test.com",
                Tel1 = "00 001 00 01",
                Tel2 = "00 001 11 11",
                Description = "Testowy opis.",
                Adress = new Adress()
                {
                    City = "Rzeszów",
                    Country = "Polska",
                    Street = "Testy 12a",
                    PostalCode = "31-555"
                },
                Products = new List<MagazinProduct>()
                {
                    new MagazinProduct()
                    {
                        Id = 3,
                        ProductName = "Blacha cienka 10mm. 30x20",
                        Description = "Cięka blacha metalowa.",
                        Gross = 150.99M,
                        GrossUnit = "zł",
                        Weight = 2M,
                        WeightUnit = "kg.",
                        AmountInMagazin = 500M,
                        AomuntUnit = "szt."
                    }

                }

            };

            Producers = new List<Producer>() { producer1, producer2 };

            var client = new Client()
            {
                Name = "Testowy klient",
                Email = "testowyEmail@cos.com",
                Tel1 = null,
                Tel2 = null,
                Description = "Opis testowy",
                Adress = new Adress()
                {
                    City = "Warszawa",
                    Country = "Polska",
                    Street = "Jakaś 12",
                    PostalCode = "00-001"
                }
                
            };
            Clients = new List<Client>() { client };

            var order = new Order()
            {
                Id = 1,
                Client = client,
                Send = true,
                CreationDate = DateTime.Now,
                SendDate = DateTime.Now.AddDays(20),
                ReapeatInDays = null,
                Products = new List<OrderProduct>()
                {
                    new OrderProduct()
                    {
                        MagazinProduct = producer1.Products[0],
                        OrderedAmount = 10M,
                        GroosTimesAmount = producer1.Products[0].Gross,
                        OrginalAmount = 10M,
                        Net = 8.54M


                    }
                }
            };

            Orders = new List<Order>() { order };

        }
    }
}
