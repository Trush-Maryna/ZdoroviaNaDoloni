﻿using ZdoroviaNaDoloni;
using ZdoroviaNaDoloni.Classes;

namespace UnitTests
{
    public class RegisteredTest
    {
        [Fact]
        public void Name_SetValidValue()
        {
            var registered = new Registered();
            registered.Name = "Марина";
            Assert.Equal("Марина", registered.Name);
        }

        [Fact]
        public void Name_SetInvalidValue()
        {
            var registered = new Registered();
            Assert.Throws<ArgumentException>(() => registered.Name = "");
        }

        [Fact]
        public void City_SetValidValue()
        {
            var registered = new Registered();
            registered.City = "Харків";
            Assert.Equal("Харків", registered.City);
        }

        [Fact]
        public void City_SetInvalidValue_ShouldThrowException()
        {
            var registered = new Registered();
            Assert.Throws<ArgumentException>(() => registered.City = "");
        }

        [Fact]
        public void OrderProducts_ShouldThrowException()
        {
            var registered = new Registered();
            var products = new List<Product>
            {
                new Product { Name = "Фурагін", Quantity = 10 }
            };
            Assert.Throws<InvalidOperationException>(() => registered.OrderProducts(products));
        }
    }
}
