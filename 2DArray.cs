using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class _2DArray
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5];
            for (int row= 0; row  < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write($"arr[{row},{col}]={arr[row,col]}");

                }
                Console.WriteLine("\n");

            }
            
        }
    }
}
