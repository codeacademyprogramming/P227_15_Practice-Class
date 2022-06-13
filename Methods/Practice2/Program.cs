using System;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowNumbers(5,10);
            ShowNumbers(10,100);

            ShowNumbers();

            double result = Sum(45, 10.5);
            Console.WriteLine(result);

            int[] nums = { 1, 2, 3, 10, 43, 14 };

            AddNumbers(nums);

            Console.WriteLine("Numbers:");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


            int num = 45;
            AddNumber(ref num);

            Console.WriteLine(num);


            nums = new int[]{ -10,45,13,-4,56};
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


            MakePositive(ref nums);

            Console.WriteLine("Positive nums");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            string name = "abbas";

            MakeUpper(ref name);
            Console.WriteLine(name);
        }

        static void ShowNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ShowNumbers(int n,int m)
        {
            for (int i = n; i < m; i++)
            {
                Console.WriteLine(i);
            }
        }

        static double Sum(double num1,double num2)
        {
            double result = num1 + num2;

            return result;
        }

        static int Sum(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            return total;
        }

        static void AddNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
            }
        }

        static void AddNumber(ref int num)
        {
            num++;
        }


        static void MakePositive(ref int[] nums)
        {
            int[] positiveNums = { };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    Array.Resize(ref positiveNums, positiveNums.Length + 1);
                    positiveNums[positiveNums.Length - 1] = nums[i];
                }
            }

            nums = positiveNums;
        }

        static void MakeUpper(ref string str)
        {
            str = str.ToUpper();
        }
    }
}
