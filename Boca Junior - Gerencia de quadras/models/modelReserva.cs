using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelReserva
    {
        private int codReserva;
        private modelCliente cliente;
        private string data;
        private int mensal;
        private string quadra;
        private string horarioEntrada;
        private string horarioSaida;
        private int reserva;

        public int Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }

        public string HorarioSaida
        {
            get { return horarioSaida; }
            set { horarioSaida = value; }
        }

        public string HorarioEntrada
        {
            get { return horarioEntrada; }
            set { horarioEntrada = value; }
        }

        public string Quadra
        {
            get { return quadra; }
            set { quadra = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public int Mensal
        {
            get { return mensal; }
            set { mensal = value; }
        }

        public int CodReserva
        {
            get { return codReserva; }
            set { codReserva = value; }
        }
        internal modelCliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

    }
}
