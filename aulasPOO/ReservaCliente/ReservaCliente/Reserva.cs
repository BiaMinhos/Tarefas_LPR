using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCliente
{
    class Reserva
    {
        public int ID { get;}
        Cliente cliente;
        static int cont = 1;

        public Reserva(Cliente cliente)
        {
            this.cliente = cliente;
            this.ID = cont;
            cont++;
        }
    }
}
