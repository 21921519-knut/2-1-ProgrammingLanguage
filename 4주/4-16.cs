using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
            */
            /*
            Console.Write("첫 번째 출력");
            Thread.Sleep(1000);
            Console.Write("두 번째 출력");
            Thread.Sleep(1000);
            Console.Write("세 번째 출력");
            */
            
            int x = 1;
            while(x<50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;
            }
            //달팽이 대각선 이동
            /*
            int x = 1;
            int y = 3;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@", y++);

                Thread.Sleep(100);
                x++;
            }
            */
        }
    }
}