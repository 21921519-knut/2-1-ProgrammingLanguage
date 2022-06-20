using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        class Student
        {
            public string id;
            public string name;
            public int grade;
            public string major;
            public DateTime birthday;
        }
        static void Main(string[] args)
        {
            /*
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });
            */

            List<Student> list = new List<Student>()
            {
                new Student(){ name = "윤인성", grade = 1 },
                new Student(){ name = "연하진", grade = 2 },
                new Student(){ name = "윤아린", grade = 3 },
                new Student(){ name = "윤명월", grade = 4 },
                new Student(){ name = "구지연", grade = 1 },
                new Student(){ name = "김연화", grade = 2 }
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
