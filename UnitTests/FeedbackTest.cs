using Newtonsoft.Json;
using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class FeedbackTest
    {
        [Fact]
        public void Feedback_DefaultConstructor()
        {
            var feedback = new Feedback();
            Assert.Equal(1, feedback.IDFeedback);
        }

        [Fact]
        public void Feedback_Constructor_ShouldInitializeProperties()
        {
            int idProduct = 1;
            string textFeedback = "Шикарний продукт!";
            int grade = 5;
            DateTime creationDate = DateTime.Now;
            string userName = "Труш Марина";
            var feedback = new Feedback(idProduct, textFeedback, grade, creationDate, userName);
            Assert.Equal(idProduct, feedback.IDProduct);
            Assert.Equal(textFeedback, feedback.TextFeedback);
            Assert.Equal(grade, feedback.Grade);
            Assert.Equal(creationDate.ToString("yyyy-MM-dd HH:mm:ss"), feedback.CreationDate);
            Assert.Equal(userName, feedback.UserName);
        }

        [Fact]
        public void Grade_SetInvalidValue_ShouldThrowArgumentException()
        {
            var feedback = new Feedback();
            Assert.Throws<ArgumentException>(() => feedback.Grade = -1);
            Assert.Throws<ArgumentException>(() => feedback.Grade = 6);
        }

        [Fact]
        public void GetStarsString_ShouldReturnCorrectString()
        {
            int grade = 3;
            string expected = "★★★";
            string result = Feedback.GetStarsString(grade);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateAverageGrade_ShouldReturnCorrectAverage()
        {
            var feedbacks = new List<Feedback>
            {
                new Feedback { Grade = 4 },
                new Feedback { Grade = 5 },
                new Feedback { Grade = 3 }
            };
            double expectedAverage = 4.0;
            double? averageGrade = Feedback.CalculateAverageGrade(feedbacks);
            Assert.Equal(expectedAverage, averageGrade);
        }

        [Fact]
        public void CalculateAverageGrade_NoFeedbacks_ShouldReturnNull()
        {
            var feedbacks = new List<Feedback>();
            double? averageGrade = Feedback.CalculateAverageGrade(feedbacks);
            Assert.Null(averageGrade);
        }

        [Fact]
        public void GetJsonFilePath_ShouldReturnCorrectPath()
        {
            string jsonFilePath = "feedbacks.json";
            string result = Feedback.GetJsonFilePath(jsonFilePath);
            Assert.EndsWith(jsonFilePath, result);
        }

        [Fact]
        public void SaveFeedbackToJson_ShouldSaveFeedback()
        {
            string jsonFilePath = "feedbacks_test.json";
            var feedback = new Feedback(1, "Гарний продукт!", 5, DateTime.Now, "Труш Марина");
            Feedback.SaveFeedbackToJson(jsonFilePath, feedback);
            string json = File.ReadAllText(Feedback.GetJsonFilePath(jsonFilePath));
            var feedbackList = JsonConvert.DeserializeObject<List<Feedback>>(json);
            Assert.Contains(feedbackList, f => f.TextFeedback == "Гарний продукт!");
        }

        [Fact]
        public void GetRandomFeedbackFromJson_ShouldReturnFeedback()
        {
            string jsonFilePath = "feedbacks_test.json";
            var feedback = new Feedback(1, "Гарний продукт!", 5, DateTime.Now, "Труш Марина");
            Feedback.SaveFeedbackToJson(jsonFilePath, feedback);
            var result = Feedback.GetRandomFeedbackFromJson(Feedback.GetJsonFilePath(jsonFilePath));
            Assert.NotNull(result);
        }
    }
}
