namespace CSharpFundmentals.LoopsTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers you want to add?");
            int length = int.Parse(Console.ReadLine());

            int[] nummbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"write the number {i +1} : ");
                nummbers[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Reverse(nummbers);
            Console.WriteLine("after reversal: ");
            foreach (int nummber in nummbers)
                Console.WriteLine($"number is: {nummber}");


            Console.WriteLine($"avairage is: {nummbers.Average()}");



        }
    }
}
