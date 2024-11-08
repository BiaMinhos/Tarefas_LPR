using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudant1 = new Estudante("Bia", 34);

            //PILAR DE ENCAPSULAMENTO
            //estudant1.nome = "Bianca";
            //Console.WriteLine(estudant1.nome);

            //ACESSO DE ATRIBUTO POR MEIO GET
            Console.WriteLine(estudant1.getNome());
            var x = estudant1.getNome();

            //ALTERAÇÃO DE VALOR POR MEIO SET
            estudant1.setNome("Bianca");
            string y = "Bernardo";
            estudant1.setNome(y);

            Estudante e1 = new("Beatriz", 34);
            Turma t1 = new Turma(34);
            Console.WriteLine(t1.ID);
            t1.addEstudante(e1);
            t1.addEstudante(new Estudante("Mateus",34));
            e1.setMediaNotas(99);

            t1.mostrarEstudante();
        }
    }
}
