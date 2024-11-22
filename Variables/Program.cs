namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * allowed names for variables
             * variable should be a clear name for it's purpose. 
             */
            string VarNam; // all character
            string _VarName; // can start witth _
            string Var_Name; // can contain _
            string @string; //can use keyword starting with @ (Not Recomended)
            string string1; //can contain number but can't start with number

            string StatementToPrint = "Hello, Adel Kamal";

            Console.WriteLine(StatementToPrint);
            Console.WriteLine(StatementToPrint);
            Console.WriteLine(StatementToPrint);
            Console.WriteLine(StatementToPrint);
            Console.WriteLine(StatementToPrint);
            Console.WriteLine(StatementToPrint);
            // later on we could use loops to print string more than one time
        }
    }
}
