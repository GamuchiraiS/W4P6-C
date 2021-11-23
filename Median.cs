using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    public class Median
    {
        //fields
        public double num1, num2, num3, median;
        public Median(double n1, double n2, double n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }
        
        public double FindMedian(double num1, double num2, double num3)
        {
            median = Math.Max(Math.Min(num1, num2), Math.Min(Math.Max(num1, num2), num3));
            return median;
        }
    }
}
