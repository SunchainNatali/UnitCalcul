using System;
namespace Unit
{
    public class SimpleCalculator
    {


            public static double Sum(double a, double b)

            {
                return a + b;
            }
            public static double Minus(double a, double b)
            {
                return a - b;
            }
            public static double Multiplay(double a, double b)
            {

                return a * b;

            }
            public static double Delen(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Делить на ноль нельзя");
                }
                return a / b;
            }
            public static double KvadrKoren(double a)

            {
                if (a < 0)
                {
                    throw new ArgumentException("Корень из отрицательного не возможен");
                }
                return Math.Sqrt(a);
            }

        
    }
}
