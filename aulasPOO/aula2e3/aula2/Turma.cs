using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Turma
    {
        public int ID { get; }
        List<Estudante> estudantes = new List<Estudante>();

        public Turma(int iD)
        {
            ID = iD;
        }

        public void addEstudante (Estudante estudante)
        {
            estudantes.Add(estudante);
        }

        public void mostrarEstudante()
        {
            foreach(var estudante in estudantes)
            {
                Console.WriteLine(estudante.getNome());

            }
        }

        public void 
    }
}
