using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class QuestionBase
    {
       public string Header {  get; set; }
       public string Body { get; set; }
       public int Mark {  get; set; }
       public Answers[] AnswerList { get; set; }
       public int RightAnswer {  get; set; }
       public abstract void Show();
    }
}
