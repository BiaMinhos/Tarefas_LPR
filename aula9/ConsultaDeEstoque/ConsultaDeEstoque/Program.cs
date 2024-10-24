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
           public string Nome;
            public int Codigo;
            public double Preco;
            public int Quantidade;
        }
        string n1, n2, n3;
        int c1, c2, c3;
        float p1, p2, p3;
        int q1, q2, q3;
        static void Main(string[] args)
        {
            Produto[] loja = new Produto[3];
            loja[0] = new Produto { Nome = n1, Codigo = c1, Preco = p1, Quantidade = q1 };
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