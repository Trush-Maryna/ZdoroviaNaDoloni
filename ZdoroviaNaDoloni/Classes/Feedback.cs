namespace ZdoroviaNaDoloni.Classes
{
    public class Feedback
    {
        private static int id;
        private string textFeedback;
        private int grade;
        private DateTime creationDate;

        public static int ID => ID;
        public int IdProduct { get; set; }
        public string TextFeedback { get; set; }
        public int Grade { get; set; }
        public DateTime CreationDate { get; set; }

        public Feedback(string textFeedback, int grade, DateTime creationDate)
        {
            throw new NotImplementedException();
            //TextFeedback = textFeedback;
            //Grade = grade;
            //CreationDate = creationDate;
        }

        public static void CalculateAverageGrade(List<Feedback> feedbacks)
        {
            throw new NotImplementedException();
        }
    }
}
