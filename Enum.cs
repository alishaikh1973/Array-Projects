using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Arrays
{
    internal class Enum
    {
        public enum Categories
        {
            Furniture=1,Electronics,Clothes,Home,Needs
        }
        public enum Departments
        {
            HR = 100, Admin = 200, Sales = 300, Marketing = 400, Dev = 500, Testing = 600
        }
        public enum Designations
        {
            Engg=10,SrEngg,Trainee,Emp,Manager,CEO

        }
        public class Product
        {
            private int id, price;
            private string name;
            private Categories category;
            public Product(int id,string name,int price,Categories category)
            {
                this.id = id;
                this.name = name;
                this.price = price;
                this.category = category;
            }
            public override string ToString()
            {
                return $"Id={id},Name={name},Price={price},Category={category}";
            }
        }
        
        

    }
}
