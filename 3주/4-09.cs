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
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string item in array)
                Console.WriteLine(item);
        }
    }
}