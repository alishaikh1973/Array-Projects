using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    class AverageofArray
    {
        public static int Average(int[]arr) 
        {
            int cnt=0,sum=0,i=0,avg;
            for ( i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for ( i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                cnt++;

            }
            avg=sum/cnt;
            return avg;
            
        }
        public static double Average(double[] arr)
        {
            int cnt = 0;
            double sum=0, avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i]=Convert.ToDouble(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = (double)sum + arr[i];
                cnt++;

            }
            avg=(double)sum/cnt;
            return avg;

        }
        
    }
}
