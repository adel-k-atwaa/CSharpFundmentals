namespace CharDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read Function Resturn the ASCII Code of the entered character
            Console.Write("Write any character them press enter: ");
            int charASCII = Console.Read();
            Console.WriteLine(charASCII);

            //Convert ASCII to character
            char @char = (char)charASCII;
            Console.WriteLine(@char);

            bool isDigit = Char.IsDigit(@char);
            bool isLetter = Char.IsLetter(@char);
            bool isLetterOrDigit = Char.IsLetterOrDigit(@char);

            Console.WriteLine($"is digit character: {isDigit}");
            Console.WriteLine($"is letter character: {isLetter}");
            Console.WriteLine($"is letter or digit character: {isLetterOrDigit}");

        }
    }
}
