namespace CSharpFundmentals.NumericDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //memory / min value / max value
            //int num1 = 0;
            //int num2 = 50;
            //int num4 = -50;

            //// u -> unsigned
            //uint uint1 = 0;
            //uint uint2 = 50;
            ////uint uint3 = -50;

            //short short1 = 0;
            //short short2 = 50;
            //short short3 = -50;

            //ushort ushort1 = 0;
            //ushort ushort2 = 50;
            //ushort ushort3 = -50;


            Console.WriteLine($"side of bool: {sizeof(bool)} bit");
            Console.WriteLine($"min value of byte: 0");
            Console.WriteLine($"max value of byte: 1");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine($"side of byte: {sizeof(byte)} byte");
            Console.WriteLine($"min value of byte: {byte.MinValue}");
            Console.WriteLine($"max value of byte: {byte.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine($"side of short: {sizeof(short)} byte");
            Console.WriteLine($"min value of short: {short.MinValue}");
            Console.WriteLine($"max value of short: {short.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine($"side of ushort: {sizeof(ushort)} byte");
            Console.WriteLine($"min value of ushort: {ushort.MinValue}");
            Console.WriteLine($"max value of ushort: {ushort.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine($"side of int: {sizeof(int)} byte");
            Console.WriteLine($"min value of int: {int.MinValue}");
            Console.WriteLine($"max value of int: {int.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

           Console.WriteLine($"side of uint: {sizeof(uint)}  byte");
            Console.WriteLine($"min value of uint: {uint.MinValue}");
            Console.WriteLine($"max value of uint: {uint.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");


            Console.WriteLine($"side of float: {sizeof(float)} byte");
            Console.WriteLine($"min value of float: {float.MinValue}");
            Console.WriteLine($"max value of float: {float.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine($"side of long: {sizeof(long)} byte");
            Console.WriteLine($"min value of long: {long.MinValue}");
            Console.WriteLine($"max value of long: {long.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");

            Console.WriteLine($"side of double: {sizeof(double)} byte");
            Console.WriteLine($"min value of double: {double.MinValue}");
            Console.WriteLine($"max value of double: {double.MaxValue}");
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");



            double doubleVal = 5.5545454654646546546542168454643216d;

            float floatVal = 5.5545454654646546546542168454643216f;

            long longVal = 555L;

            Console.WriteLine($"double: {doubleVal}");
            Console.WriteLine($"float: {floatVal}");
            
        }
    }
}
