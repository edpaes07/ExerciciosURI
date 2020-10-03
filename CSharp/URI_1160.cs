using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Urionlinejudge.Desafios
{
    public class URI_1160
    {
        public static void Run()
        {
            int i = 0;
            int QTD_caso_teste = int.Parse(Console.ReadLine());

            while (QTD_caso_teste >= 1)
            {
                QTD_caso_teste = QTD_caso_teste - 1;
                String[] valores = Console.ReadLine().Split(' ');
                int PA = int.Parse(valores[0]);
                int PB = int.Parse(valores[1]);

                float G1 = float.Parse(valores[2]);
                float G2 = float.Parse(valores[3]);

                while (PA <= PB && i <= 100)
                {
                    i = i + 1;
                    PA = (int)Math.Floor(PA * (1 + (G1 / 100)));
                    PB = (int)Math.Floor(PB * (1 + (G2 / 100)));
                }

                if (i > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");

                }
                else
                {
                    Console.WriteLine(i + " anos.");
                }
                PA = 0;
                PB = 0;
                i = 0;
            }
        }
    }
}