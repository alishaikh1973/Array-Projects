using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class Foreachloop
    {
        private static int i;

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            int[,] arr1 = new int[4, 4];
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            string[]arr2 = new string[5];
            Console.WriteLine("Enter the names");
            for (int i = 0; i < arr2.Length; i++)

                arr2[i]= Convert.ToString(Console.ReadLine());
            foreach  (string i in arr2)
            {
                Console.WriteLine(i);

            }



        }
         
	

	
    }
}
