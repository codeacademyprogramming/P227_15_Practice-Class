using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLesson
{
    internal class Car
    {
        public Car()
        {
            Console.WriteLine("Masin yaridildi");
        }

        public Car(string brand) : this()
        {
            Brand = brand;
        }


        public Car(string brand,string model):this(brand)
        {
            Model = model;
        }

        public string Brand;
        public string Model;
    }
}
