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
            File.WriteAllText(@"D:\정경호\프로그래밍언어\12주\second\test.txt", "문자열을 파일에 씁니다.");
            Console.WriteLine(File.ReadAllText(@"D:\정경호\프로그래밍언어\12주\second\test.txt"));
        }
    }
}
