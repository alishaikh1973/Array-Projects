using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class MaxMin
    {
        private static int length;

        static void Main(string[] args)
        {
            int[]arr=new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > m)
                {
                    m = arr[i];

                }
            }
            Console.WriteLine("Maximum number is:" +m);
            int n = arr[0];
            for (int i = 0; i < length; i++)
            {
                if (arr[i]< n)
                {
                    n = arr[i];
                }

            }
            Console.WriteLine("Minimum number is:" +n);
            {

            }
        }
    }
}
