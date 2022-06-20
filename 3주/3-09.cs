using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다");
        }
    }
}
