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

        public Feedback(int idProduct)
        {
            IDProduct = idProduct;
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
                File.WriteAllText(jsonFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при збереженні фідбеку у JSON: {ex.Message}");
            }
        }

        public static List<Feedback> LoadFeedbackFromJson(string jsonFilePath)
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    List<Feedback> feedbackList = JsonConvert.DeserializeObject<List<Feedback>>(json);
                    return feedbackList;
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

        //public string AddFeedbackToJsonFile(string filePath, string userName, int idProduct)
        //{
        //    try
        //    {
        //        List<Feedback> existingFeedbacks = new List<Feedback>();
        //        if (File.Exists(filePath))
        //        {
        //            string feedbacksJson = File.ReadAllText(filePath);
        //            existingFeedbacks = JsonConvert.DeserializeObject<List<Feedback>>(feedbacksJson);
        //        }

        //        Feedback newFeedback = new Feedback(idProduct)
        //        {
        //            UserName = userName,
        //            TextFeedback = TextFeedback,
        //            CreationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
        //            Grade = Grade
        //        };

        //        existingFeedbacks.Add(newFeedback);
        //        string newJsonFeedbacks = JsonConvert.SerializeObject(existingFeedbacks, Formatting.Indented);
        //        File.WriteAllText(filePath, newJsonFeedbacks);
        //        return "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"error: {ex.Message}";
        //    }
        //}
    }
}
