using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose() 메서드를 호출합니다.");
            }
        }
        static void Main(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.Dispose();
        }
    }
}
