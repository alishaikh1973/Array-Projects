using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class SearchElement
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter the number to be searched");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == m)
                {
                    Console.WriteLine($"{m} found at {i} index");
                }
            }

        }
    }
}
