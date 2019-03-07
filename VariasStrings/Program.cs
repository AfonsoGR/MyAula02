using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //comando para unicode
            Console.OutputEncoding = Encoding.UTF8; //not sure if working or not
            //formatação de strings (ex 3 - variáveis)
            double xx = 0.12345;
            int ii = 18;

            //string 1 normal (ex 1)
            string message1 = "Ola mundo";
            //string 2 normal (ex 1)
            string message2 = "Ade\nus";
            //string 3 verbatim (ex 1)
            string message3 = @"\n verbatim";
            //string 4 string format (ex 2 [incomplete])
            string message4 = String.Format("Ola {0} bem vindo ao programa número {1}", 8, 6);
            //string 5 e 6 formatação de strings (ex 3)
            string message5 = $"xx = {xx:f2}";
            string message6 = String.Format("xx em percentagem = {0:p1}",xx);
            //string 7 e 8 formataçãod e strings (ex 3)
            string message7 = $"ii hexadecimal = {ii:x}";
            string message8 = $"ii em moeda = {ii:c}";

            //imprime as strings
            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);
            Console.WriteLine(message5);
            Console.WriteLine(message6);
            Console.WriteLine(message7);
            Console.WriteLine(message8);
            Console.ReadKey();
        }
    }
}
