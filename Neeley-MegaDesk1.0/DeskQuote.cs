using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Neeley_MegaDesk1._0
{
    class DeskQuote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Desk desk { get; set; }
        public int NumRushDays { get; set; }
        public DateTime DateOrdered { get; set; }
        public decimal TotalPrice { get; set; }
        const decimal BASE_SURFACE_PRICE = 1;
        public int[,] _RushShippingPrices { get; set; }
        public DeskQuote()
        {
            desk = new Desk();
            DateOrdered = DateTime.Now;
            TotalPrice = 200;
        }

        public decimal calculatePrice()
        {
            var surfaceArea = desk.CalculateSurfaceArea();
            if (surfaceArea > 1000)
            {
                TotalPrice += (surfaceArea -1000) * BASE_SURFACE_PRICE;
            }
            TotalPrice += 50 * desk.NumDrawers;
            switch(desk.Material)
            {
                case SurfaceMaterial.Laminate:
                    TotalPrice += 100;
                    break;
                case SurfaceMaterial.Oak:
                    TotalPrice += 200;
                    break;
                case SurfaceMaterial.Pine:
                    TotalPrice += 50;
                    break;
                case SurfaceMaterial.Veneer:
                    TotalPrice += 125;
                    break;
                case SurfaceMaterial.Rosewood:
                    TotalPrice += 300;
                    break;
            };
            TotalPrice += calculateRush(surfaceArea);
            return TotalPrice;
        }
        private void getRushPrices()
        {
            _RushShippingPrices = new int[3,3];

            var priceFile = @"rushOrderPrices.txt";
            try
            {
                int i=0,j=0;
                string[] prices = File.ReadAllLines(priceFile);
                foreach(string price in prices)
                {
                    _RushShippingPrices[i,j]= int.Parse(price);

                    if (j==2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        public decimal calculateRush(int area)
        {
            
            if (area < 1000)
            {
                switch (NumRushDays)
                {
                    case 7:
                        return _RushShippingPrices[0,2];
                    case 5:
                        return _RushShippingPrices[0,1];
                    case 3:
                        return _RushShippingPrices[0,0];
                    default:
                        return 0;
                }
                
            }
            else if (area < 2000)
            {
                switch (NumRushDays)
                {
                    case 7:
                        return _RushShippingPrices[1,2];
                    case 5:
                        return _RushShippingPrices[1,1];
                    case 3:
                        return _RushShippingPrices[1,0];
                    default:
                        return 0;
                }

            }
            else 
            {
                switch (NumRushDays)
                {
                    case 7:
                        return _RushShippingPrices[2,2];
                    case 5:
                        return _RushShippingPrices[2,1];
                    case 3:
                        return _RushShippingPrices[2,0];
                    default:
                        return 0;
                }

            }
        }

        public List<DeskQuote> DeserializeQuotes(Stream stream)
            {
            var jsonSeralizer = new JsonSerializer();
            List<DeskQuote> quotes;
            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, false, 1, true))
            using (JsonTextReader reader = new JsonTextReader(streamReader))
            {
                quotes = jsonSeralizer.Deserialize<List<DeskQuote>>(reader);
            }

            return quotes;

            }
        public void SerializeQoute(DeskQuote quote)
            {
                List<DeskQuote> quotesList;

            var jsonSeralizer = new JsonSerializer();
            jsonSeralizer.Formatting = Formatting.Indented;
                
              try
            {
                FileStream stream = File.Open("quotes.json",FileMode.OpenOrCreate);
                if (stream.Length > 0)
                    {
                        quotesList = DeserializeQuotes(stream);

                    }
                else
                    {
                        quotesList = new List<DeskQuote>();
                    }
                quotesList.Add(quote);

                using (StreamWriter sw = new StreamWriter(stream))
                using (JsonTextWriter writer = new JsonTextWriter(sw))
                {
                    jsonSeralizer.Serialize(writer, quotesList);
                }

            }
            catch
            {
            }

            }
    }
}
