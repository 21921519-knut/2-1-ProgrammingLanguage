using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        abstract class Parent
        {
            public abstract void Test();
        }
        class Child : Parent
        {
            public override void Test() { }
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
