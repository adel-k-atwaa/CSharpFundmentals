namespace CSharpFundmentals.BooleanDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = false;
            Console.Write("IsAlive = ");
            Console.WriteLine(isAlive);

            isAlive = true;
            Console.Write("IsAlive = ");
            Console.WriteLine(isAlive);



            bool boolean1,boolean2;
            boolean1 = boolean2 = false;

            // And Operator
            // & check the value of boolean1 and boolean2
            bool result1 = boolean1 & boolean2;
            Console.Write("And Operator & result1 = ");
            Console.WriteLine(result1);

            // && check the value of boolean1 and if false don't check the other side of the operator
            bool result2 = boolean1 && boolean2;
            Console.Write("And Operator && result2 = ");
            Console.WriteLine(result2);

            // OR Operator
            bool result3 = boolean1 || boolean2;
            Console.Write("OR Operator result3 = ");
            Console.WriteLine(result3);

            // XOR Operator
            bool result4 = boolean1 ^ boolean2;
            Console.Write("XOR Operator result4 = ");
            Console.WriteLine(result4);
        }
    }
}
