using System;
using System.Collections.Generic;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1002
    {
        public static void Run()
        {

            double n = 3.14159;

            Console.WriteLine("Digite o raio:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("A=" + ((a * a) * n).ToString("F4"));

        }
    }
}
