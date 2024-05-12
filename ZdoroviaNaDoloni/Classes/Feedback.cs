using Newtonsoft.Json;

namespace ZdoroviaNaDoloni.Classes
{
    public class Feedback
    {
        private static int id = 0;
        private int grade;

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
            IDFeedback = ++id;
        }

        public Feedback(int idProduct)
        {
            IDProduct = idProduct;
            IDFeedback = ++id;
        }

        public Feedback(int idProduct, string textFeedback, int grade, DateTime creationDate, string userName)
        {
            IDProduct = idProduct;
            IDFeedback = ++id;
            TextFeedback = textFeedback;
            Grade = grade;
            CreationDate = creationDate.ToString("yyyy-MM-dd HH:mm:ss");
            UserName = userName;
        }

        public static string GetStarsString(int grade)
        {
            return new string('★', grade);
        }

        public static double? CalculateAverageGrade(List<Feedback> feedbacks)
        {
            if (feedbacks == null || !feedbacks.Any())
                return null;

            return feedbacks.Average(f => f.Grade);
        }

        public static string GetJsonFilePath(string jsonFilePath)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            return Path.Combine(projectDirectory, jsonFilePath);
        }

        public static void SaveFeedbackToJson(string jsonFilePath, Feedback feedback)
        {
            try
            {
                string jsonPath = GetJsonFilePath(jsonFilePath);
                List<Feedback> feedbackList = new List<Feedback>();

                if (File.Exists(jsonPath))
                {
                    string json = File.ReadAllText(jsonPath);
                    feedbackList = JsonConvert.DeserializeObject<List<Feedback>>(json);
                }

                feedbackList.Add(feedback);

                string updatedJson = JsonConvert.SerializeObject(feedbackList, Formatting.Indented);
                File.WriteAllText(jsonPath, updatedJson);
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при збереженні фідбеку у JSON: {ex.Message}");
            }
        }

        public static Feedback GetRandomFeedbackFromJson(string jsonFilePath)
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonPath = GetJsonFilePath(jsonFilePath);
                    string json = File.ReadAllText(jsonPath);
                    List<Feedback> feedbackList = JsonConvert.DeserializeObject<List<Feedback>>(json);

                    if (feedbackList == null || feedbackList.Count == 0)
                    {
                        throw new Exception("Список фідбеків порожній.");
                    }

                    Random random = new Random();
                    int randomIndex = random.Next(0, feedbackList.Count);
                    return feedbackList[randomIndex];
                }
                else
                {
                    throw new FileNotFoundException("JSON файл не знайдено.", jsonFilePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при завантаженні фідбеку з JSON: {ex.Message}");
            }
        }
    }
}
