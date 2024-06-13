using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaDeEstoque
{
    class Program
    {
       struct Produto
        {
            string Nome;
            int Codigo;
            double Preco;
            int Quantidade;
        }
        static void Main(string[] args)
        {
            Produto[] loja = new Produto[3];
            loja[0]= new Produto { Nome=}
        }
    }
}

/*Exercício 1) RESOLVA EM C#
Defina uma struct Produto que contenha
os seguintes campos: Nome, Codigo,
Preco e Quantidade. Crie um programa
que permita ao usuário inserir dados de 3
produtos e, em seguida, exiba o valor
total em estoque (considerando o preço e
a quantidade de cada produto).*/
