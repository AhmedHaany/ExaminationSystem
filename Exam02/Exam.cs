using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        public double TotalMarks {get; set;}
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
      public List<Question> Questions { get; set; } = new List<Question>();

        public Exam() { }

        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }
        public void Initial()
        {
            Console.WriteLine("Please Enter Time Of Exam:");
            TimeOfExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number Of Questions:");
            NumberOfQuestions = int.Parse(Console.ReadLine());
        }
        public void ShowExam()
        {
            double Grade = TotalMarks;
            List<int> ans = new List<int>();
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}: {Questions[i]}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Please Enter The Answer");
                int x = int.Parse(Console.ReadLine());

                ans.Add(x);

                if (x != Questions[i].GetRightAnswer().AnswerId)
                {
                    Grade -= Questions[i].Mark;
                }

            }

            Console.Clear();

            Console.WriteLine("Your Answers");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}) {Questions[i].Body}: {Questions[i].GetAnswerByID(ans[i])}");
            }

            Console.WriteLine($"Your Exam Grade is {Grade} from {TotalMarks}");
        }

        public abstract void CreatExam();
    }
}
