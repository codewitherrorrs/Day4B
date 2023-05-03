using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class StarPattern
    {
        /*
         *****
         ****
         ***
         **
         *
         */
        public void DecreasingStarPattern()
        {
            Console.WriteLine("Enter the Number of Row : ");
            int row = int.Parse(Console.ReadLine());
            int i, j;
            i = j = 0;
            for(i=0;i<row; i++)
            {
                for (j = 0; j < row - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
