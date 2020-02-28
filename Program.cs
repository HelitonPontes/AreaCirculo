using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //area = π . raio2
            double area,raio1;
            double P = 3.14159;
            float raio = float.Parse(Console.ReadLine());

            raio1 = double.Parse(raio.ToString("#0.00"));

            area = P * (raio1 * raio1);

            Console.WriteLine("A=" + area.ToString("#0.0000"));

        }
    }
}
