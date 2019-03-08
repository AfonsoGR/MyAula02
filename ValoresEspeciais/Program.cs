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

            Console.WriteLine(sbmax);
            Console.WriteLine(dbmax);
            Console.WriteLine(ulmax);

            //f5 up in da house
            Console.ReadKey();
        }
    }
}
