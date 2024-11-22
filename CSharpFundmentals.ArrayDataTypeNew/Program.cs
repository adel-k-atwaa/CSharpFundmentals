namespace CSharpFundmentals.ArrayDataTypeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 7 };
            int[] arr2 = { 1, 2, 3, 4, 7, 10, 9, 6, 50 };
            int[] arr3 = new int[arr2.Length];
            Console.WriteLine(arr1[arr1.Length - 1]);
            Array.Copy(arr2, arr3, arr2.Length);
            Array.Sort(arr2);
            string joined = String.Join(',', arr2);
            Console.WriteLine(joined);

            int[] spleted = joined.Split(',').Select(int.Parse).ToArray();
            Console.WriteLine(arr2.Length);
            Console.WriteLine(spleted.Length);
            Console.WriteLine(arr3.Length);

            Console.WriteLine(String.Join('-',arr3));
            string test = String.Join('-', arr3.Select(x => x * 5).ToArray());
            Console.WriteLine(test);
            test = String.Join("-", arr3.Where(x => x > 5).ToArray());
            Console.WriteLine(test);
            Console.WriteLine(arr3.First());

            //Console.WriteLine(arr2.Distinct().ToArray());

        }
    }
}
