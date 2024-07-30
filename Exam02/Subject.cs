using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public Exam Exam { get; set; }

        public Subject() { }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.Write("Please Enter The Type Of Exam You Want To Create (1 For Practical and 2 For Final): ");
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Exam = new PracticalExam();
                Exam.Initial();
                Exam.CreatExam();
            }
            else if (x == 2)
            {
                Exam = new FinalExam();
                Exam.Initial();
                Exam.CreatExam();
            }
        }
    }
}
