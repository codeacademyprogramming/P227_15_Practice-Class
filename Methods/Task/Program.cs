using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee(40){Name = "Abbas"},
                new Employee(58){Name = "Abdulla"},
                new Employee(30){Name = "Nergiz"}
            };

            Student[] students =
            {
                new Student(15){Name = "Fateh"},
                new Student(14){Name = "Duygu"}
            };

            //optionInput:
            //Console.WriteLine("1. Isciler uzerinde axtaris");
            //Console.WriteLine("2. Telebeler uzerinde axtaris");

            //string option = Console.ReadLine();

            //if(option == "1")
            //{
            //    Console.WriteLine("Isticiler uzre axtaris");
            //}
            //else if(option == "2")
            //{
            //    Console.WriteLine("Telebeler uzerinde axtaris");
            //}
            //else
            //{
            //    goto optionInput;
            //}

            string option;
            do
            {
                Console.WriteLine("1. Isciler uzerinde axtaris");
                Console.WriteLine("2. Telebeler uzerinde axtaris");

                option = Console.ReadLine();

            } while (option!="1" && option!="2");


            string search;
            do
            {

                Console.WriteLine("Axtaris deyerini daxil edin:");
                search = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(search));

            if (option == "1")
            {
                foreach (var item in employees)
                {
                    if(item.Name.Contains(search))
                        Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in students)
                {
                    if (item.Name.Contains(search))
                        Console.WriteLine(item.Name);
                }
            }
        }
    }
}
