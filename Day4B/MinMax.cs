using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class MinMax
    {
        public void MinMaxElement()
        {
            int[] arr = { 50, 12, 56, 80, 2, 1 };
            int max = arr[0];
            int min = arr[0];
            int i = 0;
            Console.Write("Present Array is : ");
            for(int j=0; j<arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            for(i=0;i<arr.Length;i++)
            {
                int val = arr[i];
                if (max < val) 
                {
                    max = val;
                }
                else if (min > val)
                {
                    min = val;
                }
            }
            
            Console.WriteLine("\nMax Value is : "+max);
            Console.WriteLine("Min Value is : "+min);
        }
    }
}
