using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class FrequencyofanArray
    {
        static void Main(string[] args)
        {
            int i = 0;
            int cnt = 0;
            int fr = 0;
            int[]arr=new int[5];
            Console.WriteLine("Enter the number");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Elements[" + (i+1) + "]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Frequency:");
            fr=Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            { 
            
                if (fr == arr[i])
                {
                    cnt++;
                }

            }
            Console.WriteLine("Total occurrence is Number is:" +fr,+cnt);
        }

    }
}
