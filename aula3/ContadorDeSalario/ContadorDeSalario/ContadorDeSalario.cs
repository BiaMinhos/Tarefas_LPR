using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu numero: ");
            int funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu numero de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor que recebe por hora: ");
            double valor = double.Parse(Console.ReadLine());
            double salario = (horas * valor);
            Console.Write("O funcionraio {0} tem {1:F2} de salario" ,funcionario,salario);
            Console.ReadKey();
        }
    }
}
