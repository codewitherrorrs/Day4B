using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class ReverseString
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the string to reverse : ");
            string name = Console.ReadLine();
            string temp = "";
            int length = name.Length;
            int i = 0;
            for (i = length-1; i >= 0; i--)
            {
                temp = temp + name[i];
            }
            Console.WriteLine($"The Reverse of String is :  {temp}");
        }
    }
}
