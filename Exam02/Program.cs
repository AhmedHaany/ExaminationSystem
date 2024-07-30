using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1,"C#");
            subject.CreateExam();
            Console.Clear();

            Console.WriteLine("Do You Want To Start The Exam(y | n)  ");

            if(char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
        }
    }
}
