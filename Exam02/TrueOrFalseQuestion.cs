using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueOrFalseQuestion : Question
    {

        public TrueOrFalseQuestion()
        {
            Header = "True Or False Question";
            
        }

        public TrueOrFalseQuestion(string body, double mark ):this()
        {
            Body = body;
            Mark = mark;
        }

        public TrueOrFalseQuestion(string header, string body, double mark, Answer rightAnswer, List<Answer> answers) : base(header, body, mark, rightAnswer, answers) 
        {

        }

        public override void SetAnswers()
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void SetRightAnswer()
        {
            int id;
            Console.WriteLine("Please Enter The Right Answer ID (1 for true , 2 for false)");
            id = int.Parse(Console.ReadLine());
            RightAnswer = Answers.Find(answer => answer.AnswerId == id);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
