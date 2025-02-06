using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub01 = new Subject(10,"C#");
            sub01.CreateExam(true);
            Console.Clear();
            Console.Write("Do You Want To Start The Exam (y | n): ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub01.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
        }
    }
}
