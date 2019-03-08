using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            string alturaS, raioS;
            double alturaF, raioF, volume, areasup;
            //pedir altura
            Console.WriteLine("Introduza a altura:\n");
            alturaS = Console.ReadLine();
            //converter altura em float
            alturaF = Convert.ToSingle(alturaS);
            //pedir raio
            Console.WriteLine("Introduza o raio:\n");
            raioS = Console.ReadLine();
            //converter raio em float
            raioF = Convert.ToSingle(raioS);
            //calcular volume
            volume = Math.PI * Math.Pow(raioF,2) * alturaF;
            //calcular area superficial
            areasup = 2 * Math.PI * raioF * (raioF * alturaF);
            //apresentar os resultados
            Console.WriteLine($"O volume é {volume:f3}");
            Console.WriteLine("A área de superfície é {0:f3}",areasup);
            //debug neste pc de merda
            Console.ReadKey();
        }
    }
}
