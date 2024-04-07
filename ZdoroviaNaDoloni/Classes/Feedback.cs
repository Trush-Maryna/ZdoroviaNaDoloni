namespace ZdoroviaNaDoloni.Classes
{
    public class Feedback
    {
        private static int id = 1;
        private string textFeedback;
        private int grade;

        public static int ID => id++;
        public int IDProduct { get;}
        public string TextFeedback
        {
            get => textFeedback;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1)
                    throw new ArgumentException("Text feedback cannot be empty.");
                textFeedback = value;
            }
        }
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("Grade must be between 0 and 5.");
                grade = value;
            }
        }
        public DateTime CreationDate { get; set; }

        public Feedback(string textFeedback, int grade, DateTime creationDate, Product product)
        {
            TextFeedback = textFeedback;
            Grade = grade;
            CreationDate = creationDate;
            IDProduct = product.ID;
        }

        public static double? CalculateAverageGrade(List<Feedback> feedbacks)
        {
            if (feedbacks == null || !feedbacks.Any())
                return null;

            return feedbacks.Average(f => f.Grade);
        }
    }
}
