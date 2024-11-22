namespace CSharpFundmentals.ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int x = 25;
            int y = 10;
            
            // var is Implicit data type
            var z =(double) x / y;
            //or
            double x1 = 25;
            int y1 = 10;
            //or
            int x2 = 25;
            double y2 = 10;

            Console.WriteLine($"x + y = {x + y}"); // addition
            Console.WriteLine($"x - y = {x - y}"); // substraction
            Console.WriteLine($"x * y = {x * y}"); // multiblication
            Console.WriteLine($"(int) x / (int) y = {x / y} (wrong)"); // division
            Console.WriteLine($"(double) x1 / (int) y1 = {x1 / y1} (correct)"); // division
            Console.WriteLine($"(int) x1 / (double) y1 = {x2 / y2} (correct)"); // division
            Console.WriteLine($"(double) z =(double) x / y; z =  {z} (correct)"); // division
            Console.WriteLine($"x % y = {x % y}"); // reminder
        }
    }
}
