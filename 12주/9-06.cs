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
            using (StreamReader reader = new StreamReader(@"D:\정경호\프로그래밍언어\12주\second\test2.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
