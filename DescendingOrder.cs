using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class DescendingOrder
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 45, 67, 12, 89, 5 };
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j =i+1 ; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            

            
        }
        

    }

}


    


    

