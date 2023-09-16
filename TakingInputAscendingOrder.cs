using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class AscendingOrder
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int temp;
            Console.WriteLine("Enter the Numbers");
             int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elements - {0}: " ,i);
                arr[i]=Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {

                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            Console.WriteLine("Elements of array in sorted ascending order are:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}" , arr[i]);

            }


                    
        }

    }

}
    

