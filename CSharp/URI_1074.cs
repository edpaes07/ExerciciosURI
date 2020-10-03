using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1074
    {
        public static void Run()
        {
            {
                {
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string par, positivo;
                        int x = int.Parse(Console.ReadLine());
                        if (x == 0)
                        {
                            Console.WriteLine("NULL");
                        }

                        else if (x % 2 == 0)
                        {
                            par = "EVEN";
                            if (x > 0)
                            {
                                positivo = "POSITIVE";
                            }
                            else
                            {
                                positivo = "NEGATIVE";
                            }
                            Console.WriteLine(par + " " + positivo);
                        }

                        else
                        {
                            par = "ODD";
                            if (x > 0)
                            {
                                positivo = "POSITIVE";
                            }
                            else
                            {
                                positivo = "NEGATIVE";
                            }
                            Console.WriteLine(par + " " + positivo);
                        }

                    }
                }
            }
        }
    }
}