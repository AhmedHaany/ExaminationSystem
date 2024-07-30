using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        MCQQuestion question;
        public double mark = 0;
        public override void CreatExam()
        {   
            for (int i = 0; i < NumberOfQuestions; i++)
            {
              
                    Question question;
                    question = new MCQQuestion();
                    question = question.CreateQuestion(question);

                    Questions.Add(question);
                     mark += question.Mark;
            }
            TotalMarks = mark;
        }
       
    }
}
