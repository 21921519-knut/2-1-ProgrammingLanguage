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
            int[] intarray = { 1, 2, 3, 4, 5, 6 };
            for (int i = intarray.Length - 1; i >= 0; i--)
                Console.WriteLine(intarray[i]);
        }
    }
}