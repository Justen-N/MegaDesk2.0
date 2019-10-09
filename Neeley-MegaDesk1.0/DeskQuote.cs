using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public decimal calculateRush(int area)
        {
            
            if (area < 1000)
            {
                switch (NumRushDays)
                {
                    case 7:
                        return 30;
                    case 5:
                        return 40;
                    case 3:
                        return 60;
                    default:
                        return 0;
                }
                
            }
            else if (area < 2000)
            {
                switch (NumRushDays)
                {
                    case 7:
                        return 35;
                    case 5:
                        return 50;
                    case 3:
                        return 70;
                    default:
                        return 0;
                }

            }
            else 
            {
                switch (NumRushDays)
                {
                    case 7:
                        return 40;
                    case 5:
                        return 60;
                    case 3:
                        return 80;
                    default:
                        return 0;
                }

            }
        }
    }
}
