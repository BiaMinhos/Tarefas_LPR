using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolhaDoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Para saber quais são suas habilidades, escolha a qual classe deseja pertencer e depois insira sua escolha:\n 1-Guerreira\n 2-Mago\n 3-Arqueira");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "Guerreira":
                    Console.WriteLine("Ataque Pesado, Defesa Total");
                    break;
                case "Mago":
                    Console.WriteLine("Bola de Fogo, Escudo de Gelo");
                    break;
                case "Arqueiro":
                    Console.WriteLine("Flecha Precisa, Disparo Triplo");
                    break;
            }
            Console.ReadKey();
        }
    }
}
