using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class MCQOneChoice : QuestionBase
    {
       public override void Show()
        {
            Console.WriteLine($"{Header}: {Body}");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
            }
        }
    }
}
