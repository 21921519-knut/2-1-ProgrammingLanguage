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
            int output = 0;
            for (int i = 0;i <=100; i++)
            {
                output += i;
            }
            Console.WriteLine(output);
        }
    }
}