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
            /*
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow :
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        break;
                }
            }
            */
            /*
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }
            */
            //내가 조종하면 이동하는 꿈틀꿈틀 달팽이
            bool state = true;
            int x = 1;
            int y = 1;
            int c = 1;
            string small = "___@";
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(small);
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        y--;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(small);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        x++;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(small);
                        c++;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(small);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        x--;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(small);
                        c++;
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
                if (c % 4 == 0)
                    small = "___@";
                else if (c % 4 == 1)
                    small = "__^@";
                else if (c % 4 == 2)
                    small = "_^_@";
                else
                    small = "^__@";
            }
        }
    }
}
