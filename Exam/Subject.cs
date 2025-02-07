using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Subject(int Id, string Name)
        {
            Id = 1;
            Name = "C# Programming";
        }
        public void CreateExam(bool f)
        {
            Console.Write("Do you want a Final Exam or a Practical Exam? (1 for Final, 2 for Practical): ");
            int examType = int.Parse(Console.ReadLine());

            if (examType == 1)
            {
                Exam = new FinalExam();

                Console.Write("Enter the time of Exam in minutes: ");
                Exam.Time = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of questions: ");
                int numQuestions = int.Parse(Console.ReadLine());

                Exam.NumberOfQuestions = numQuestions;

                for (int i = 0; i < numQuestions; i++)
                {
                    Console.WriteLine($"\nAdding Question {i + 1}:");
                    Console.Write("Is this a (MCQ) or (TF) ? (1 for MCQ, 2 for TF): ");
                    int questionType = int.Parse(Console.ReadLine());

                    if (questionType == 1)
                    {
                        MCQOneChoice mcq = new MCQOneChoice();
                        Console.Write("Enter Question Header: ");
                        mcq.Header = Console.ReadLine();

                        Console.Write("Enter Question Body: ");
                        mcq.Body = Console.ReadLine();

                        Console.Write("Enter Question Mark: ");
                        mcq.Mark = int.Parse(Console.ReadLine());

                        mcq.AnswerList = new Answers[4];
                        for (int j = 0; j < 4; j++)
                        {
                            mcq.AnswerList[j] = new Answers();
                            Console.Write($"Enter Answer {j + 1}: ");
                            mcq.AnswerList[j].AnswerText = Console.ReadLine();
                            mcq.AnswerList[j].AnswerId = j + 1;
                        }

                        Console.Write("Enter the number of the correct answer (1-4): ");
                        mcq.RightAnswer = int.Parse(Console.ReadLine());

                        Exam.Questions.Add(mcq);
                    }
                    else if (questionType == 2)
                    {
                        TFQuestion tf = new TFQuestion();
                        Console.Write("Enter Question Header: ");
                        tf.Header = Console.ReadLine();

                        Console.Write("Enter Question Body: ");
                        tf.Body = Console.ReadLine();

                        Console.Write("Enter Question Mark: ");
                        tf.Mark = int.Parse(Console.ReadLine());

                        tf.AnswerList = new Answers[]
                        {
                        new Answers { AnswerId = 1, AnswerText = "True" },
                        new Answers { AnswerId = 2, AnswerText = "False" }
                        };

                        Console.Write("Enter the correct answer (1 for True, 2 for False): ");
                        tf.RightAnswer = int.Parse(Console.ReadLine());

                        Exam.Questions.Add(tf);
                    }
                }

            }
            else
            {
                Exam = new PracticalExam();

                Console.Write("Enter the time of Exam in minutes: ");
                Exam.Time = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of questions: ");
                int numQuestions = int.Parse(Console.ReadLine());

                Exam.NumberOfQuestions = numQuestions;

                for (int i = 0; i < numQuestions; i++)
                {
                    Console.WriteLine($"\nAdding Question {i + 1}:");

                    MCQOneChoice mcq = new MCQOneChoice();
                    Console.Write("Enter Question Header: ");
                    mcq.Header = Console.ReadLine();

                    Console.Write("Enter Question Body: ");
                    mcq.Body = Console.ReadLine();

                    Console.Write("Enter Question Mark: ");
                    mcq.Mark = int.Parse(Console.ReadLine());

                    mcq.AnswerList = new Answers[4];
                    for (int j = 0; j < 4; j++)
                    {
                        mcq.AnswerList[j] = new Answers();
                        Console.Write($"Enter Answer {j + 1}: ");
                        mcq.AnswerList[j].AnswerText = Console.ReadLine();
                        mcq.AnswerList[j].AnswerId = j + 1;
                    }

                    Console.Write("Enter the number of the correct answer (1-4): ");
                    mcq.RightAnswer = int.Parse(Console.ReadLine());

                    Exam.Questions.Add(mcq);
                }
            }
        }
    }
}
