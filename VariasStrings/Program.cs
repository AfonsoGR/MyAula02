using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string 1 normal (ex 1)
            string message1 = "Ola mundo";
            //string 2 normal (ex 1)
            string message2 = "Ade\nus";
            //string 3 verbatim (ex 1)
            string message3 = @"\n verbatim";
            //string 4 string format (ex 2 [incomplete])
            string message4 = String.Format("Ola {0} bem vindo ao programa número {1}", 8, 6);

            //imprime as strings
            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);
            Console.ReadKey();
        }
    }
}
