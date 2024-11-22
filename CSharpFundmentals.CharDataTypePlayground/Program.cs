namespace CSharpFundmentals.CharDataTypePlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write Character then press enter: ");
            char userChar = (char)Console.Read();

            Console.WriteLine($"IsAsciiHexDigitUpper {Char.IsAsciiHexDigitUpper(userChar)}");
            Console.WriteLine($"IsAsciiLetter {Char.IsAsciiLetter(userChar)}");
            Console.WriteLine($"IsAsciiHexDigitLower {Char.IsAsciiHexDigitLower(userChar)}");
            Console.WriteLine($"IsAsciiHexDigitUpper {Char.IsAsciiHexDigitUpper(userChar)}");
            Console.WriteLine($"IsControl {Char.IsControl(userChar)}");
            Console.WriteLine($"IsSurrogate {Char.IsSurrogate(userChar)}");
            Console.WriteLine($"IsSymbol {Char.IsSymbol(userChar)}");
            Console.WriteLine($"IsWhiteSpace {Char.IsWhiteSpace(userChar)}");
            Console.WriteLine($"IsPunctuation {Char.IsPunctuation(userChar)}");
            Console.WriteLine($"IsNumber {Char.IsNumber(userChar)}");
            Console.WriteLine($"IsSeparator {Char.IsSeparator(userChar)}");
        }
    }
}
