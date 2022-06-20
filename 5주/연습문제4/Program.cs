using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제4
{
    class Program
    {
        class Question
        {
            public double answer;
            public double number;
            public int count;
        }
        static void Main(string[] args)
        {
            Question question = new Question();
            question.answer = 126;
            while (question.count < 20)
            {
                Console.Write("숫자를 입력해주세요 : ");
                var input = Console.ReadLine();
                try
                {
                    question.number = double.Parse(input);
                    if (question.number == question.answer)
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                    else if (question.number > question.answer)
                    {
                        Console.WriteLine(question.number + "보다는 작은 수 입니다.\n");
                        question.count += 1;
                    }
                    else if (question.number < question.answer)
                    {
                        Console.WriteLine(question.number + "보다는 큰 수 입니다.\n");
                        question.count += 1;
                    }
                }                
                catch (Exception)
                {
                    Console.WriteLine("에러가 발생하였습니다. 강제적으로 기회를 소모합니다.\n");
                    question.count += 1;
                }
            }
            Console.WriteLine("정답은 "+question.answer+"입니다.");
        }
    }
}
