using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class ToStringMethod
    {
        private int id, price;
        private string name;
        public ToStringMethod(int id,string name,int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;

        }
        public override string ToString()
        {
            return $"Id={id},Name={name},Price={price}";

            
        }
        

        
    }
}
