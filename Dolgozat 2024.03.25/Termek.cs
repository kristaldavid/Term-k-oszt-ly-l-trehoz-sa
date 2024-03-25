using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_2024._03._25
{
    public class Termek
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Termek(string name, int price, int stockQuantity, DateTime purchaseDate)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
            PurchaseDate = purchaseDate;
        }

        public void ChangeStockQuantity(int value)
        {
            StockQuantity -= value;
        }

        public override string? ToString()
        { 
            return Name  + ", " + Price + ", " + StockQuantity + ", " + PurchaseDate;
        }
    }
}
