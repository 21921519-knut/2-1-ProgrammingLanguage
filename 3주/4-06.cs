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
            int output = 1;
            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }

            Console.WriteLine(output);
        }
    }
}