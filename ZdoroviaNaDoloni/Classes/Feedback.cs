using Newtonsoft.Json;

namespace ZdoroviaNaDoloni.Classes
{
    public class Feedback
    {
        private static int id = 0;
        private int grade;

        public static int ID => id++;
        public int IDFeedback { get; }
        public int IDProduct { get; set; }
        public string TextFeedback { get; set; }
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
        public string CreationDate { get; set; } 
        public string UserName { get; set; }

        public Feedback()
        {
            if (IDFeedback == 0)
            {
                IDFeedback = ID;
            }
        }

        public Feedback(string textFeedback, int grade, DateTime creationDate, string userName)
        {
            IDFeedback = ID;
            TextFeedback = textFeedback;
            Grade = grade;
            CreationDate = creationDate.ToString("yyyy-MM-dd HH:mm:ss");
            UserName = userName;
        }

        public static double? CalculateAverageGrade(List<Feedback> feedbacks)
        {
            if (feedbacks == null || !feedbacks.Any())
                return null;

            return feedbacks.Average(f => f.Grade);
        }

        public string AddFeedbackToJsonFile(string filePath, string userName)
        {
            try
            {
                List<Feedback> existingFeedbacks = new List<Feedback>();
                if (File.Exists(filePath))
                {
                    string feedbacksJson = File.ReadAllText(filePath);
                    existingFeedbacks = JsonConvert.DeserializeObject<List<Feedback>>(feedbacksJson);
                }

                Feedback newFeedback = new Feedback
                {
                    UserName = userName,
                    TextFeedback = TextFeedback,
                    CreationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Grade = Grade
                };

                existingFeedbacks.Add(newFeedback);
                string newJsonFeedbacks = JsonConvert.SerializeObject(existingFeedbacks, Formatting.Indented);
                File.WriteAllText(filePath, newJsonFeedbacks);
                return "success";
            }
            catch (Exception ex)
            {
                return $"error: {ex.Message}";
            }
        }
    }
}
