namespace CSharpFundmentals.DebuggerBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
             string number = Console.ReadLine() ?? "";
            int parsedNumber = int.Parse(number);
            int reminder = parsedNumber % 2;

            if (parsedNumber == 0)
            {
                Console.WriteLine("Zero is neither even nor odd.");
            }
            else if (reminder == 1)
            {
                Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine($"{number} is even.");

            }
        }
    }
}
