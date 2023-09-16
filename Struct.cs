using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class Struct
    {
        private int X, Y;
        public Struct(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public string Print()
        {
            return $"X={X},Y={Y}";
        }
    }
}


