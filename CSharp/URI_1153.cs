using System;
using System.Collections.Generic;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1153
    {
        public static void Run()
        {
            {
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            if (num != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    fatorial = fatorial * i;
                }
            }

            Console.WriteLine(fatorial);
        }

        internal static void Run()
        {
            throw new NotImplementedException();
        }
    }
}
