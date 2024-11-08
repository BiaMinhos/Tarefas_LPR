using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    internal class Estudante
    {
        //ENCAPSULAMENTO  ==>  ATRIBUTO PRIVADOS
        string nome;
        public int turma { get; set; }
        double mediaNotas;

        //CONSTRUTOR = MÉTODO ESPECIAL PÚBLICO
        public Estudante(string nome, int turma)
        {
            this.nome = nome;
            this.turma = turma;
        }

        //// GET = MÉTODO ESPECIAL
        //public  string getNome()
        //{
        //    return nome;
        //}

        //// SET = MÉTODO ESPECIAL
        //public string setNome(string nome)
        //{
        //    this.nome = nome;
        //}

        //// SET = MÉTODO ESPECIAL
        //public void setMediaNotas(int novaNota)
        //{
        //    if(novaNota>0){};
        //}

        // METODO GETSET = METODO ESPECIAL
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

}
