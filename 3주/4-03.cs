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
            int i = 0;
            int[] intarray = { 52, 273, 32, 65, 103 };

            while (i< intarray.Length)
            {
                Console.WriteLine(i + "번쨰 출력 : " + intarray[i]);
                i++;
            }
        }
    }
}
