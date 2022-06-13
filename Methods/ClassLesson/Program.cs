using System;

namespace ClassLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 45;
            string name = "fd";

            Car e200 = new Car("Mercedes");
            e200.Model = "E200";

            Car s500 = new Car()
            {
                Brand = "Mercedes",
                Model = "S500"
            };

            Car car1 = new Car("BMW", "X5");

            Console.WriteLine(car1.Brand + " - " + car1.Model);


            Book book1 = new Book("Ali ve Nino", 50);
            book1.DiscountPercent = 20;
            Console.WriteLine(book1.Name);
            Console.WriteLine(book1.Price);


            Console.WriteLine(book1.GetDiscountedPrice());
            Console.WriteLine(book1.DiscountedPrice);

            Human[] humans = new Human[]
            {
                new Human(10,"Abbas","Qulamov"),
                new Human(24,"Hikmet","Abbasov"),
                new Human(44,"Nezrin","Qulamova"),
                new Human(44,"Nergiz","Abbasova"),
            };

            string search;
            do
            {
                Console.WriteLine("Axtaris deyerini daxil edin:");
                search = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(search));


            search = search.ToLower();
            
            foreach (var item in humans)
            {
                if (item.FullName.ToLower().Contains(search))
                    Console.WriteLine($"{item.Name} {item.Surname} - {item.Age}");
            }

            Cat mestan = new Cat("Mestan",10);

            Console.WriteLine(mestan.Age);

        }

    }
}
