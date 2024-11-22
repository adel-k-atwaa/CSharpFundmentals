namespace CSharpFundmentals.LoopsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 5 numbers");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);

            Console.WriteLine("Numbers after sorting are (for): ");
            for (int i = 0; i <numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);

            }

            Console.WriteLine("Numbers after sorting are (foreach): ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
