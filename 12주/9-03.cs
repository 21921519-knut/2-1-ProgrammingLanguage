using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        class TestClass : Interface1
        {

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }

            public int TestProperty
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }
        }
        static void Main(string[] args)
        {
            Interface1 interface1 = new TestClass();
        }
    }
}
