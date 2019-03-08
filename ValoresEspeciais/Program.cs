using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //valores maximos e minimos
            sbyte sbmax = sbyte.MaxValue;
            double dbmax = double.MaxValue;
            ulong ulmax = ulong.MaxValue;
            int imax = short.MaxValue;
            sbyte sbmin = sbyte.MinValue;
            double dbmin = double.MinValue;
            ulong ulmin = ulong.MinValue;
            int imin = short.MinValue;

            //variáveis float
            float f1, f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f); // True !!!
            Console.WriteLine("\n"); //spacing in console

            //apresentação de valores máximos e mínimos
            Console.WriteLine(sbmax);
            Console.WriteLine(dbmax);
            Console.WriteLine(ulmax);
            Console.WriteLine(imax);
            Console.WriteLine("\n"); //spacing in console
            Console.WriteLine(sbmin);
            Console.WriteLine(dbmin);
            Console.WriteLine(ulmin);
            Console.WriteLine(imin);
            Console.WriteLine("\n"); //spacing in console

            //overflow de inteiros
            Console.WriteLine((short)(imax + 1));
            Console.WriteLine("\n"); //spacing in console

            //infinitos e overflow
            //double x = double. PositiveInfinity;
            //double x = 2 * double.MaxValue;
            //Console.WriteLine(x);

            //f5 up in da house
            Console.ReadKey();
        }
    }
}
