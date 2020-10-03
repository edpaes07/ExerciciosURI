using System;
using System.Collections.Generic;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1005
    {
        public static void Run()
        {


            double A = double.Parse(Console.ReadLine());

            double B = double.Parse(Console.ReadLine());

            double MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));

        }
    }
}
