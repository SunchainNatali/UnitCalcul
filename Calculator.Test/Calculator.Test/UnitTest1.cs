using System;
using Xunit;
using Unit;

namespace Calculator.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-3, - 5, -8)]
        [InlineData(4.99, 5.01, 10.00)]      
        public void Test1(double a,double b, double expectedResult)
        {
            double sum = SimpleCalculator.Sum(a, b);
            Assert.Equal(expectedResult, sum);
        }
       
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(-75, -5, -70)]
        [InlineData(75.99, 25.01, 50.97999999999999)]
       
         public void Test2(double a, double b, double expectedResult)
        { 
           
            double minus = SimpleCalculator.Minus(a, b);
            Assert.Equal(expectedResult, minus);
        }


        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2.99, 3.01, 8.9999)]
        [InlineData(-6, -3, 18)]
        public void Test3(double a, double b, double expectedResult)
        {
            double multi = SimpleCalculator.Multiplay(a, b);
            Assert.Equal(expectedResult, multi);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(-5, -5, 1)]
        [InlineData(0.3, 0.3, 1)]
       
        public void Test4(double a, double b, double expectedResult)
        {
            double delen = SimpleCalculator.Delen(a, b);
            Assert.Equal(expectedResult, delen);
        }

        [Theory]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        
        public void Test5(double a, double expectedResult)
        {
            double kvadrKor = SimpleCalculator.KvadrKoren(a);
            Assert.Equal(expectedResult, kvadrKor);
        }

        [Fact]
        public void Test6()
        {
            double a = 30;
            double b = 0;
            string actualsms = "Делить на ноль нельзя";
            var expectres = Assert.Throws<DivideByZeroException>(() => SimpleCalculator.Delen(a, b));
            Assert.Equal(actualsms, expectres.Message);
        }

        [Fact]
        public void Test7()
        {
            double a = -1;
            string actualsms = "Корень из отрицательного не возможен";
            var expectres = Assert.Throws<ArgumentException>(() => SimpleCalculator.KvadrKoren(a));
            Assert.Equal(actualsms, expectres.Message);
        }
    }
}
