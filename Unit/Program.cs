using System;


namespace Unit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Input the operation: ");
                    
            char str = Console.ReadLine().Trim()[0];
            double num1;
            double num2;
            switch(str)
            {
                case '+':
                    Console.WriteLine("Input the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine( SimpleCalculator.Sum( num1, num2));
                    break;
                case '-':
                    Console.WriteLine("Input the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(SimpleCalculator.Minus(num1, num2));
                    break;
                case '*':
                    Console.WriteLine("Input the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(SimpleCalculator.Multiplay(num1, num2));
                    break;
                case '/':
                    Console.WriteLine("Input the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(SimpleCalculator.Delen(num1, num2));
                    break;
                case '^':
                    Console.WriteLine("Input the number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(SimpleCalculator.KvadrKoren(num1));
                    break;
            }
           
        }




        
        
    }
}
