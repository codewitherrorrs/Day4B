using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B
{
    public class StarPatternOne
    {
        public void HollowRectangle()
        {
            int rows = 7, col = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (i == 1 || j == 1 || i == rows || j == col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
