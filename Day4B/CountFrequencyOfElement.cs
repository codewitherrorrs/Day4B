using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class CountFrequencyOfElement
    {
        public void FrequencyCount()
        {
            //Array Declaration
            int[] arr = { 1, 2, 4, 5, 1, 2, 3 };
            int length = arr.Length;
            int i, j;
            i = j = 0;
            int count;

            //Outer Loop
            for (i = 0; i < length; i++)
            {
                int x = arr[i];
                count = 0;
                if (x == -1) { continue; }
                for (j=0;j<length; j++)
                {
                    if (arr[j]==x)
                    {
                        count++;
                        arr[j] = -1;
                    }
                }
                Console.WriteLine($"The Frequency of {x} is {count}");
            }
        }
    }
}
