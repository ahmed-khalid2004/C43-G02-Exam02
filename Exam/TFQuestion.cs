using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class TFQuestion : QuestionBase
    {
       public override void Show()
        {
            Console.WriteLine($"{Header}: {Body} (True/False)");
        }
    }
}
