using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Question
    {
        public string Header {  get; set; }
        public string Body { get; set; }
        public double Mark {  get; set; }
        protected Answer RightAnswer { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();

        public Question() { }
        public abstract void SetRightAnswer();
        //{
        //    int id;
        //    Console.WriteLine("Please Enter The Right Answer ID");
        //    id = int.Parse(Console.ReadLine());
        //    RightAnswer = Answers.Find(answer => answer.AnswerId == id);    
        //}
        public Answer GetRightAnswer()
        { 
            return RightAnswer;
        }
        public string GetAnswerByID(int  id)
        {
            Answer a = Answers.Find(answer => answer.AnswerId == id);
            return a.AnswerText;
        }
        public abstract void SetAnswers();
        protected Question(string header, string body, double mark, Answer rightAnswer, List<Answer> answers)
        {
            Header = header;
            Body = body;
            Mark = mark;
            RightAnswer = rightAnswer;
            Answers = answers;
        }
        
       public Question CreateQuestion(Question question)
        {
            Console.WriteLine(question.Header);
            Console.WriteLine("Please Enter Question Body");
            question.Body = Console.ReadLine();
            Console.WriteLine("Please Enter Question Mark");
            question.Mark = int.Parse(Console.ReadLine());
            question.SetAnswers();
            question.SetRightAnswer();

            return question;

        }
     
        public override string ToString()
        {
            string answersString = string.Join("\n", Answers.Select(a => $"{a.AnswerId}. {a.AnswerText}"));
            return $"{Header}\n{Body}\nMark: {Mark}\nChoices:\n{answersString}";
        }
    }
}
