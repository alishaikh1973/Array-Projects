using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class StudentName
    {
        private static int i;

        static void Main(string[] args)
        {
            string[]arr = new string[5];
            Console.WriteLine("Enter the Names");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToString(Console.ReadLine());



            }
            for (int i = 0;i < arr.Length; i++)
            {
               
                Console.WriteLine();

            }
            



        }
    }
}
