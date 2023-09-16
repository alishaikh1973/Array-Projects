using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][]jarray=new int[4][];
            jarray[0] = new int[] { 1,2,3,4};
            jarray[1] = new int[] { 10, 20, 30 };
            jarray[2] = new int[] { 100, 200 };
            jarray[3] = new int[] { 1000 };
            for(int row = 0; row < jarray.Length; row++)
            {
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    Console.WriteLine(jarray[row][col]+"");

                }
                Console.WriteLine("\n");
            }
        }
    }
}
