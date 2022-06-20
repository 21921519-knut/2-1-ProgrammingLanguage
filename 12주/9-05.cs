using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"D:\정경호\프로그래밍언어\12주\second\test2.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }

            Console.WriteLine(File.ReadAllText(@"D:\정경호\프로그래밍언어\12주\second\test2.txt"));
        }
    }
}
