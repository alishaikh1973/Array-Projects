using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class ArrayObject
    {
        static void Main(string[] args)
        {
            object[] arrobj = new object[3];
            arrobj[0] = 100;
            arrobj[1] = "Hello All";
            arrobj[2] = 78.88;
            foreach (object o in arrobj)
            {
                Console.WriteLine(o);
            }
        }
    }
}
