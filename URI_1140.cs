using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1140
    {
        public static void Run()
        {
            {
            string cadeia = "";
            do
            {
                cadeia = Console.ReadLine();
                string[] siglasSeparadas = cadeia.Split();
                string sigla = "";
                bool tautograma = false;
                bool palavra = true;
                foreach (string n in siglasSeparadas)
                {
                    palavra = Char.IsLetter(n, 0);
                    sigla += n.Substring(0, 1);
                    if (cadeia.Substring(0, 1).Equals(sigla.Substring(sigla.Length - 1), StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        tautograma = false;
                        break;
                    }

                    else
                    {
                        tautograma = true;
                    }

                }

                if (palavra == false)
                {

                }
                else if (tautograma == false)
                {
                    Console.WriteLine("N");
                }
                else
                {
                    Console.WriteLine("Y");
                }

            }
            while (cadeia != "*");


        }
    }
}
