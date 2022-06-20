using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 52, 273, 32, 65, 103 };

            intarray[0] = 0;

            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[1]);
            Console.WriteLine(intarray[2]);
            Console.WriteLine(intarray[3]);

            Console.WriteLine(intarray.Length);
        }
    }
}