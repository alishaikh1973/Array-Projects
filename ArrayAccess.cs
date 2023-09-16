using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class ArrayAccess
    {
        static void Main(string[] args)
        {
            int[] number=new int[10];
            int[] number1= {1,2,3,4,5,6,7,8,9,10};
            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine($"number[{i}]={number[i]}");   
                Console.WriteLine($"number1[{i}]={number1[i]}");
            }
        }
    }
}
