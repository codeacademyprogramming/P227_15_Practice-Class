using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLesson
{
    internal class Book
    {
        public Book(string name,double price=5)
        {
            Name = name;
            Price = price;
        }
        public string Name;
        public double Price;
        public double DiscountPercent;
        public double DiscountedPrice
        {
            get
            {
                return  Price - Price * (DiscountPercent / 100);
                
            }
        }

        public double GetDiscountedPrice()
        {
            double disPrice = Price - Price * (DiscountPercent / 100);
            return disPrice;
        }

    }
}
