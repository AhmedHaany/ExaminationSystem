using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    // 3 
    // true or mcq
    // mcq
    // mcq --> Body 
    // mark 
    // List Answers // *
    internal class FinalExam : Exam 
    {
        public double mark = 0;

        public override void CreatExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int x;
                Question question ;
                Console.WriteLine("Please Enter Type Of Question (1 For MCQ | 2 For True | False )");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    question = new MCQQuestion();
                    question = question.CreateQuestion(question);
                    //Console.WriteLine(question.Header);
                    //Console.WriteLine("Please Enter Question Body");
                    //question.Body = Console.ReadLine();
                    //Console.WriteLine("Please Enter Question Mark");
                    //question.Mark = int.Parse(Console.ReadLine());
                    //question.SetAnswers();
                    //question.SetRightAnswer();
                    Questions.Add(question);
                    mark += question.Mark;

                }
                else if (x == 2)
                {
                    question = new TrueOrFalseQuestion();
                    question = question.CreateQuestion(question);
                    //Console.WriteLine(question.Header);
                    //Console.WriteLine("Please Enter Question Body");
                    //question.Body = Console.ReadLine();
                    //Console.WriteLine("Please Enter Question Mark");
                    //question.Mark = int.Parse(Console.ReadLine());
                    //question.SetAnswers();
                    //question.SetRightAnswer();
                    Questions.Add(question);
                    mark += question.Mark;
                }
            }
            TotalMarks = mark;

        }


    }
}
