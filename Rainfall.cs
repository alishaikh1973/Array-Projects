using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class Rainfall
    {
        static void Main(string[] args)
        {
            double[] rf = new double[7];
            for (int i = 0; i < rf.Length; i++)
            {
                Console.WriteLine("Enter the rainfall for day{i}");
                rf[i] = Convert.ToDouble(Console.ReadLine());


            }
            for (int j = 0; j < rf.Length; j++)
            {
                Console.WriteLine("Rainfall for Day{j} is {rf[j]}");

            }
        }
    }
}


