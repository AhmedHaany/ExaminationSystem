using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{

    internal class MCQQuestion : Question
    {

        public MCQQuestion()
        {
            Header = "MCQ Question";
        }

        public MCQQuestion(string body, double mark) : this()
        {
            Body = body;
            Mark = mark;
        }

        public override void SetAnswers()
        {
            
            for (int i = 0; i < 3 ; i++)
            {
                string str;
                Console.WriteLine($"Please Enter Choice Number {i+1}");
                str = Console.ReadLine();
                Answers.Add(new Answer(i + 1, str)); 
            }
        }

        public override void SetRightAnswer()
        {
            int id;
            Console.WriteLine("Please Enter The Right Answer ID");
            id = int.Parse(Console.ReadLine());
            RightAnswer = Answers.Find(answer => answer.AnswerId == id);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
