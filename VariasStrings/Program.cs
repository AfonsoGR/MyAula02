using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Ola mundo";
            string message2 = "Ade\nus";
            string message3 = @"\n verbatim";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
        }
    }
}
