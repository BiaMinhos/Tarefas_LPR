using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Beatriz");

            Reserva r1 = new Reserva(cliente);
            Console.WriteLine(r1.ID);
            Reserva r2 = new Reserva(cliente);
            Console.WriteLine(r2.ID);

            cliente.novaReserva(r1);
            Cliente cliente = new Cliente

        }
    }
}
