using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение R1: ");
            string R1 = Console.ReadLine();
            Console.Write("Введите значение R2: ");
            string R2 = Console.ReadLine();
            Console.Write("Введите значение R3: ");
            string R3 = Console.ReadLine();
            double V1 = 4 * Math.Pow(Convert.ToDouble(R1), 3) * Math.PI / 3;
            double V2 = 4 * Math.Pow(Convert.ToDouble(R2), 3) * Math.PI / 3;
            double V3 = 4 * Math.Pow(Convert.ToDouble(R3), 3) * Math.PI / 3;
            double Z = (V1 + V2 + V3) / 3;
            Console.Write("(V1 + V2 + V3) / 3 = " + Z.ToString());

            Console.ReadKey();
        }
    }
}
