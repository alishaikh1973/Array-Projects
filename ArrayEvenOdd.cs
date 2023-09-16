using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class ArrayEvenOdd
    {
        static void Main(string[] args)
        {
            int[]arr=new int[10];
            Console.WriteLine("Enter the Array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Elements[" + (i+1) + "]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Even numbers are:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]+ " ");
                }
                
               
                   
                
            }


        }
    }
}
