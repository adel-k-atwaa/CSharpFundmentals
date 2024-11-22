namespace CSharpFundmentals.StringDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello ";
            string world = "world";
            Console.WriteLine(hello + world);

            string greeting = String.Concat(hello, world);
            Console.WriteLine(greeting);

            Console.WriteLine("hello \t\t\t\tworld");
            Console.WriteLine(@"hello \t\t\t\tworld");
            Console.WriteLine(@"hello world
this is a new line

hello C#
");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"welcome {name}");
            Console.WriteLine($"length {name.Length}");
            Console.WriteLine($"ToUpper {name.ToUpper()}");
            Console.WriteLine($"ToLower {name.ToLower()}");
            Console.WriteLine($"starts with D: {name.StartsWith('D')}");
            Console.WriteLine($"starts with A: {name.StartsWith('A')}");
            Console.WriteLine($"starts with Ad: {name.StartsWith("Ad")}");
            Console.WriteLine($"starts with ad: {name.StartsWith("ad",StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"end with Ad: {name.EndsWith("Ad")}");
            Console.WriteLine($"end with el: {name.EndsWith("el")}");
            Console.WriteLine($"end with EL: {name.EndsWith("EL",StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Contains l: {name.Contains("l")}");
            Console.WriteLine($"Contains x: {name.Contains("x")}");
            Console.WriteLine($"Contains DE: {name.Contains("DE",StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"IndexOf e: {name.IndexOf("e")}");
            Console.WriteLine($"IndexOf x: {name.IndexOf("x")}");
            Console.WriteLine($"IndexOf m: {name.LastIndexOf("m")}");
            Console.WriteLine($"Replace: {greeting.Replace("world",name)}");
            


        }
    }
}
