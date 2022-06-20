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
            //연습문제 4
            Console.Write("태어난 년도를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());
            switch (input % 12)
            {
                case 0:
                    Console.WriteLine("원숭이띠 입니다.");
                    break;
                case 1:
                    Console.WriteLine("닭띠 입니다.");
                    break;
                case 2:
                    Console.WriteLine("개띠 입니다.");
                    break;
                case 3:
                    Console.WriteLine("돼지띠 입니다.");
                    break;
                case 4:
                    Console.WriteLine("쥐띠 입니다.");
                    break;
                case 5:
                    Console.WriteLine("소띠 입니다.");
                    break;
                case 6:
                    Console.WriteLine("범띠 입니다.");
                    break;
                case 7:
                    Console.WriteLine("토끼띠 입니다.");
                    break;
                case 8:
                    Console.WriteLine("용띠 입니다.");
                    break;
                case 9:
                    Console.WriteLine("뱀띠 입니다.");
                    break;
                case 10:
                    Console.WriteLine("말띠 입니다.");
                    break;
                case 11:
                    Console.WriteLine("양띠 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }

            //연습문제 5
            /*
            Console.Write("이번 달은 몇 월인가요? : ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
            }
            */

            //연습문제 6
            Console.Write("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());
            switch (level)
            {
                case 1:
                    Console.WriteLine("수강해야하는 전공 학점 : 12학점");
                    break;
                case 2:
                    Console.WriteLine("수강해야하는 전공 학점 : 18학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야하는 전공 학점 : 10학점");
                    break;
                case 4:
                    Console.WriteLine("수강해야하는 전공 학점 : 18학점");
                    break;
            }
        }
    }
}