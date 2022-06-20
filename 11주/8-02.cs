using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class SquareCalculator
    {
        public int this[int i]
        {
            get
            {
                return i * i;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
            Console.WriteLine(square[20]);
            Console.WriteLine(square[30]);
        }
    }
}
