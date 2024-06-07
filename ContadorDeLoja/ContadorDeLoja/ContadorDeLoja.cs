using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o codigo da peca 1: ");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quatidade da peca 1: ");
            int quantidade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitario da peca 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o codigo da peca 2: ");
                 int codigo2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Insira a quatidade da peca 2: ");
                 int quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitario da peca 2: ");
                 double valor2 = double.Parse(Console.ReadLine());
                   double total = (quantidade1 * valor1 + quantidade2 * valor2);
            Console.WriteLine("O total da sua compra foi de R$ {0} reais " ,total);
            Console.ReadKey();
        }
    }
}
