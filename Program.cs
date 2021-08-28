using System;

namespace upn_T1_q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double lado1, lado2, areaRectangulo;
            Console.WriteLine("Bienvenido al programa de cálculo de perímetro de un rectangulo");
            Console.Write("Ingrese lado1: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese lado2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            areaRectangulo = 2 * (lado1 + lado2);
            Console.WriteLine("El perímetro del rectangulo es: " + Convert.ToString(areaRectangulo));

        }
    }
}
