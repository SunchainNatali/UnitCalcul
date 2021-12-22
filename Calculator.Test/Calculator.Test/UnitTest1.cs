using System;
using Xunit;
using Unit;

namespace Calculator.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 5, 5)]
        [InlineData(-3, - 5, -8)]
        [InlineData(4.99, 5.01, 10.00)]      
        public void PossibleToSumValidParams(double a,double b, double expectedResult)
        {
            double actual = SimpleCalculator.Sum(a, b);
            Assert.Equal(expectedResult, actual);
        }
       
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 7, -7)]
        [InlineData(-75, -5, -70)]
        [InlineData(75.99, 25.01, 50.97999999999999)]
       
         public void PossibleToMinusValidParams(double a, double b, double expectedResult)
        { 
           
            double actual = SimpleCalculator.Minus(a, b);
            Assert.Equal(expectedResult, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2, 0, 0)]
        [InlineData(2.99, 3.01, 8.9999)]
        [InlineData(-6, -3, 18)]
        public void PossibleToMultiplayValidParams(double a, double b, double expectedResult)
        {
            double actual = SimpleCalculator.Multiplay(a, b);
            Assert.Equal(expectedResult, actual);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(-5, -5, 1)]
        [InlineData(0.3, 0.3, 1)]
       
        public void PossibleToDelenieValidParams(double a, double b, double expectedResult)
        {
            double actual = SimpleCalculator.Delen(a, b);
            Assert.Equal(expectedResult, actual);
        }

        [Theory]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        
        public void PossibleToSquareValidParams(double a, double expectedResult)
        {
            double actual = SimpleCalculator.Square(a);
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        public void Test6()
        {
            string actualsms = "Делить на ноль нельзя";
            var expectresult = Assert.Throws<DivideByZeroException>(() => SimpleCalculator.Delen(30, 0));
            Assert.Equal(actualsms, expectresult.Message);
        }

        [Fact]
        public void Test7()
        {
            string actualsms = "Корень из отрицательного не возможен";
            var expectresult = Assert.Throws<ArgumentException>(() => SimpleCalculator.Square(-1));
            Assert.Equal(actualsms, expectresult.Message);
        }
    }
}
