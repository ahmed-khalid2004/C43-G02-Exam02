namespace Exam
{
    public class QuestionList
    {
        public List<QuestionBase> Questions { get; set; } = new List<QuestionBase>();

        public void AddQuestion(QuestionBase q)
        {
            Questions.Add(q);
        }

        public void ShowAll()
        {
            foreach (var q in Questions)
            {
                q.Show();
            }
        }
    }
}