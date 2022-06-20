using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        sealed class Parent
        {
            public void Test() { }
        }
        class Child : Parent
        {
            sealed public void Test() { }
        }
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.Test();
            child.Test();
        }
    }
}
