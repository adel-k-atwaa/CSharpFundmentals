namespace CSharpFundmentals.StringDataTypeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Original String: ");
            string originalString = Console.ReadLine();

            Console.Write("Enter The Part your want to replace: ");
            string replacePart = Console.ReadLine();
            
            Console.Write("Enter The new part: ");
            string newPart = Console.ReadLine();

            string finalString = originalString.Replace(replacePart, newPart);
            Console.WriteLine($"string after manipulation:  {finalString}");
        }
    }
}
