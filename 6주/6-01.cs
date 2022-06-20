using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    /*
    class Program
    {
        class Test
        {
            public int Power(int x)
            {
                return x * x;
            }
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
        }
    }
    */
    /*
    class Program
    {
        class Test
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multi(52, 273));
            Console.WriteLine(test.Multi(103, 32));
        }
    }
    */

    class Program
    {
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 메소드가 호출 되었습니다.");
            }
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Print();
            test.Print();
            test.Print();
        }
    }

}
