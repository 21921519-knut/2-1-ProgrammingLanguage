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
            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료): ");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}