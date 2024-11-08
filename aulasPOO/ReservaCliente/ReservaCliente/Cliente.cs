   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCliente
{
    class Cliente
    {
        public string nome { get; set; }
        List<Reserva> reservas = new List<Reserva>();

        public Cliente(string nome)
        {
            this.nome = nome;
        }
        public void novaReserva (string local, int data, Reserva aux)
        {
            // reservas.Add(new Reserva(this));
            reservas.Add(aux);
        }
        public void mostraReservas()
        {
            Console.WriteLine("Cliente" + nome);
            foreach (Reserva r in reservas)
            {
                Console.WriteLine("Reserva"+)
            }
        }
    }
}
