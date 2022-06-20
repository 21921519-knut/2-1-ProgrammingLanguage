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
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());

            //잘못된 코드
            /*
            string input = "Potato Tomato";
            input.ToUpper();
            Console.WriteLine(input);
            */

            string input2 = "감자 고구마 토마토";
            string[] inputs = input2.Split(new char[] { ' ' });
            //또는 string[] inputs = input2.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
          
            string input3 = " test    \n";
            Console.WriteLine("::" + input3.Trim() + "::");
            Console.WriteLine("::" + input3.TrimStart() + "::");
            Console.WriteLine("::" + input3.TrimEnd() + "::");
            Console.Read();

            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));
        }
    }
}