using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class DuplicateArrayItem
    {
        public void DuplicateElement()
        {
            int[] arr = { 10,20,25,10,26,20,25 };
            int len = arr.Length;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements: " + count);
            Console.ReadKey();

        }
    }
}
