using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number 1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 3: ");
            double num3 = Convert.ToInt32(Console.ReadLine());
            //instantiate 
            Median med = new Median(num1, num2, num3);
            //call function
            med.FindMedian(num1, num2, num3);
            Console.WriteLine("The numbers you entered: " + num1 + ", " + num2 + ", " + num3);
            Console.WriteLine("Median = " + med.median);
            Console.ReadKey();
        }
    }
}
