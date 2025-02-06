using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class FinalExam : Exam
    {
        public override void ShowExam() {
            int mark = 0;
            foreach (var q in Questions)
            {
                q.Show();
                Console.Write("Your Answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == q.RightAnswer) mark += q.Mark;
            }
            Console.WriteLine($"Your Total Marks: {mark}");
        }
    }
}
