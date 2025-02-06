using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     public abstract class Exam
    {
       public int Time {  get; set; }
       public int NumberOfQuestions { get; set; }
        public abstract void ShowExam();
        public List<QuestionBase> Questions { get; set; } = new List<QuestionBase>();
    }
}
