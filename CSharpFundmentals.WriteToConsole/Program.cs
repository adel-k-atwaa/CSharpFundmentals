namespace CSharpFundmentals.WriteToConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //change console title
            Console.Title = "Write To Console Test";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Black;
            //change background color
            Console.BackgroundColor = ConsoleColor.White; 
            
            //write data to console
            Console.WriteLine("Hello, World!");
            Console.Write("Adel ");
            Console.Write("Kamal");

            //change console back to default colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            // User to wait for user input before terminating the process
            Console.ReadLine(); 

        }
    }
}
