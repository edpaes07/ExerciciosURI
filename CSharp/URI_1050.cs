using System;
using System.Collections.Generic;
using System.Text;

namespace Urionlinejudge.Desafios
{
    public class URI_1050
    {
        public static void Run()
        {
			int input = Int32.Parse(Console.ReadLine());
			string resposta = "";
			switch (input)
			{
				case 61:
					resposta = "Brasilia";
					break;
				case 71:
					resposta = "Salvador";
					break;
				case 11:
					resposta = "Sao Paulo";
					break;
				case 21:
					resposta = "Rio de Janeiro";
					break;
				case 32:
					resposta = "Juiz de Fora";
					break;
				case 19:
					resposta = "Campinas";
					break;
				case 27:
					resposta = "Vitoria";
					break;
				case 31:
					resposta = "Belo Horizonte";
					break;
				default:
					resposta = "DDD nao cadastrado";
					break;
			}
			Console.WriteLine(resposta);

		}
    }
}
