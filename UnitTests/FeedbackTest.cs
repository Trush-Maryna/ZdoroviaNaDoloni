using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;
using ZdoroviaNaDoloni.Classes.Enums;

namespace UnitTests
{
    public class FeedbackTest
    {
        [Fact]
        public void Add_Feedback_Successfully()
        {
            var fb_1 = new Feedback("Feedback 1", 4, DateTime.Now, new Product("Product 1", "Description 1", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, new List<Feedback>()));
            var fb_2 = new Feedback("Feedback 2", 3, DateTime.Now, new Product("Product 2", "Description 2", 100, 4, Statuses.InStock, Categories.BeautyAndCare, Discounts.Five, new List<Feedback>()));
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            var registered = new Registered("666395820", "Mar03Mar", Roles.Registered, Genders.Female);

            pharmacist.AddFeedback(fb_1);
            registered.AddFeedback(fb_2);

            Assert.Contains(fb_1, pharmacist.Feedbacks);
            Assert.Contains(fb_2, registered.Feedbacks);
        }

        [Fact]
        public void Add_Feedback_Fails_Text_Is_Empty()
        {
            var grade = 3;
            var creationDate = DateTime.Now;
            var product = new Product("Product1", "Description", 200, 5, Statuses.InStock, Categories.Various, Discounts.Null, new List<Feedback>());

            Assert.Throws<ArgumentException>(() => new Feedback("", grade, creationDate, product));
        }

        [Fact]
        public void Edit_Feedback_Successfully()
        {
            var originalfb = new Feedback("Feedback 1", 4, DateTime.Now, new Product("Product 1", "Description 1", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, new List<Feedback>()));
            var editedfb = new Feedback("Feedback 2", 3, DateTime.Now, new Product("Product 2", "Description 2", 100, 4, Statuses.InStock, Categories.BeautyAndCare, Discounts.Five, new List<Feedback>()));
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            pharmacist.Feedbacks.Add(originalfb);

            pharmacist.EditFeedback(originalfb, editedfb);

            Assert.DoesNotContain(originalfb, pharmacist.Feedbacks);
            Assert.Contains(editedfb, pharmacist.Feedbacks);
        }

        //[Fact]
        //public void Edit_Feedback_Fails_When_Not_In_List()
        //{
        //    var originalfb = new Feedback("Feedback 1", 4, DateTime.Now, new Product("Product 1", "Description 1", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, new List<Feedback>()));
        //    var editedfb = new Feedback("Feedback 2", 3, DateTime.Now, new Product("Product 2", "Description 2", 100, 4, Statuses.InStock, Categories.BeautyAndCare, Discounts.Five, new List<Feedback>()));
        //    var pharmacist = new Pharmacist("trush.marina.13@gmail.com");

        //    Assert.Throws<ArgumentException>(() => pharmacist.EditFeedback(originalfb, editedfb));
        //}

        [Fact]
        public void Remove_Feedback_Successfully()
        {
            var fb = new Feedback("Feedback 1", 4, DateTime.Now, new Product("Product 1", "Description 1", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, new List<Feedback>()));
            var pharmacist = new Pharmacist("trush.marina.13@gmail.com");
            pharmacist.Feedbacks.Add(fb);

            pharmacist.DeleteFeedback(fb);

            Assert.DoesNotContain(fb, pharmacist.Feedbacks);
        }

        //[Fact]
        //public void Remove_Feedback_Fail_When_Not_In_List()
        //{
        //    var fb = new Feedback("Feedback 1", 4, DateTime.Now, new Product("Product 1", "Description 1", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, new List<Feedback>()));
        //    var pharmacist = new Pharmacist("trush.marina.13@gmail.com");

        //    Assert.Throws<ArgumentException>(() => pharmacist.DeleteFeedback(fb));
        //}

        [Fact]
        public void Calculate_AverageGrade_When_Feedbacks_Present()
        {
            var feedbacks = new List<Feedback>
            {
                new Feedback("Feedback 1", 4, DateTime.Now, new Product("Product 1", "Description 1", 200, 5, Statuses.InStock, Categories.Medicines, Discounts.Null, new List < Feedback >())),
                new Feedback("Feedback 2", 3, DateTime.Now, new Product("Product 2", "Description 2", 100, 4, Statuses.InStock, Categories.Medicines, Discounts.Null, new List < Feedback >())),
                new Feedback("Feedback 3", 5, DateTime.Now, new Product("Product 3", "Description 3", 500, 6, Statuses.InStock, Categories.Medicines, Discounts.Null, new List < Feedback >()))
            };

            var result = Feedback.CalculateAverageGrade(feedbacks);

            Assert.True(result >= 0 && result <= 5);
        }

        //[Fact]
        //public void Calculate_AverageGrade_No_Feedbacks_Present()
        //{
        //    List<Feedback> feedbacks = new List<Feedback>();

        //    Assert.Throws<InvalidOperationException>(() => Feedback.CalculateAverageGrade(feedbacks));
        //}
    }
}
