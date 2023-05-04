using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class SumOfAllDigit
    {
        public void SumOfDigit()
        {
            Console.WriteLine("Enter the Number to Sum : ");
            int value = int.Parse(Console.ReadLine());
            int sum = 0;
            while(value != 0)
            {
                int remainder = value % 10;
                sum = sum + remainder;
                value = value / 10;
            }
            Console.WriteLine($"The sum of all digit is : {sum}");
        }
    }
}
