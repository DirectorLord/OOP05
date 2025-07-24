using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added this here so it doesnt conflict with the first one
namespace OOP05;

    #region Project 2
    //i should have started with this easy task
    public class Math
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

#endregion
    public static void Main(string[] args)
    {
            #region Project 2
            Console.WriteLine($"dd: {Math.Add(5, 5)}");
            Console.WriteLine($"ss: {Math.Subtract(5, 5)}");
            Console.WriteLine($"mm: {Math.Multiply(5, 5)}");
            try
            {
                Console.WriteLine($"dd: {Math.Divide(5, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
