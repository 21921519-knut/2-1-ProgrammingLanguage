using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        class Product
        {
            public string name;
            public int price;

            //public string name = "default";
            //public int price = 1000;
        }
        static void Main(string[] args)
        {
            Product product = new Product();

            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");

            Product productA = new Product() {name = "감자", price = 2000};
            Product productB = new Product() {name = "고구마", price = 3000};

            Console.WriteLine(productA.name + " : " + productA.price + "원");
            Console.WriteLine(productB.name + " : " + productB.price + "원");
        }
    }
}
