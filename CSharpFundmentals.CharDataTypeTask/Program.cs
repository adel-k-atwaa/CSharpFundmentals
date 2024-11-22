using System.Collections.Generic;

namespace CSharpFundmentals.CharDataTypeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * print ASCII Table for letters from A to z capital and small and numbers from 0 to 9
             */
            List<char> charList = new List<char>();

            // a-z lower case
            charList.AddRange(GetCharacterRange('a', 26));
            //A-Z upper case
            charList.AddRange(GetCharacterRange('A', 26));
            // 0-9
            charList.AddRange(GetCharacterRange('0',9).ToList());

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("-\t\t Character\t\t - \t\t ASCII \t\t     -");
            Console.WriteLine("------------------------------------------------------------------------------");

            foreach (char c in charList)
            {
                Console.WriteLine($"-\t\t     {c} \t\t\t - \t\t  {(int) c}\t\t     -");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        static IEnumerable<char> GetCharacterRange(char startChar,int count)
        {
            return Enumerable.Range(startChar, count).Select(asciiCode => (char)asciiCode);
        }
    }
}
