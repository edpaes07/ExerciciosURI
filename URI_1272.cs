using System;
using System.Collections.Generic;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1272
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string frase = Console.ReadLine().Trim(); 

                if (frase.Length > 0)
                {
                    string[] palavras = frase.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string inicial in palavras)
                    {
                        Console.Write(inicial.Substring(0, 1).ToLower());
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(frase);
                }
            }
        }
    }
}
