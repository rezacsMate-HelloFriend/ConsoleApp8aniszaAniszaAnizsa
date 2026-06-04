using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class Items
    {
        protected string Name { get; set; }
        private int Price { get; set; }
        public Items(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public int GetPrice()
        {
            return Price;
        }
        public double DiscountedPrice(double Discount)
        {
            return Price * Discount;
        }
    }
    public class SpecialItems : Items
    {
        public int Warranty { get; set; }
        public SpecialItems(string name, int price, int warranty) : base(name, price)
        {
            Warranty = warranty;
        }
        public int WarrantyEnd(int ActualYear)
        {
            return Warranty + ActualYear;
        }
    }
}
